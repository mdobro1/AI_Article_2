using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Gallery
{
    public class Gallery
    {
        // Regex für zulässige erweiterungen
        private static readonly Regex ApprovedExenstions;

        static Gallery()
        {
            ApprovedExenstions = new Regex(@"^.*\.(gif|jpg|png)$");
        }

        /// <summary>
        /// Der Pfad, wo die Bilder gespeichert werden.
        /// </summary>
        public static string PhysicalUploadPath
        {
            get
            {
                return HttpContext.Current.Server.MapPath(@"Pictures/");
            }
            set
            {
                PhysicalUploadPath = value;
            }
        }

        //
        /// <summary>
        /// Methode, die das Bild und die Miniatüransicht (Thumbnail) speichert.
        /// </summary>
        /// <param name="stream">Datenstrom mit Bilddaten.</param>
        /// <param name="fileName">Dateiname des gespeicherten Bildes.</param>
        /// <returns>Dateiname des gespeicherten Bildes.</returns>
        public string SaveImage(Stream stream, string fileName)
        {
            int imageExist = 2;
            var image = System.Drawing.Image.FromStream(stream);
            var thumbnail = image.GetThumbnailImage(60, 45, null, System.IntPtr.Zero);

            try
            {
                // Überprüft , ob es sich um das richtige Format handelt.
                if (!IsValidImage(image))
                {
                    throw new InvalidDataException(Convert.ToString(image.RawFormat));
                }
                // Stellt sicher, dass der Dateiname eindeutig ist.
                while (ImageExits(fileName))
                {
                    string orginalFileName = Path.GetFileNameWithoutExtension(String.Format("{0}{1}", PhysicalUploadPath, fileName));
                    string fileNameChange = Path.GetExtension(String.Format("{0}{1}", PhysicalUploadPath, fileName));

                    fileName = String.Format("{0}{1}{2}", orginalFileName, imageExist, fileNameChange);

                    imageExist++;
                }
                image.Save(PhysicalUploadPath + fileName);
                thumbnail.Save(PhysicalUploadPath + @"thumb/" + fileName);
            }
            catch (Exception)
            {

                throw new ArgumentException("Das Bild konnte nicht gespeichert werden (es ist ein Fehler aufgetreten)!");
            }

            return fileName;
        }

        private bool IsValidImage(Image image)
        {
            return
              image.RawFormat.Guid == ImageFormat.Gif.Guid ||
              image.RawFormat.Guid == ImageFormat.Png.Guid ||
              image.RawFormat.Guid == ImageFormat.Jpeg.Guid;
            
        }

        public bool ImageExits(string name)
        {
            return File.Exists(String.Format("{0}{1}", PhysicalUploadPath, name));
        }

        /// <summary>
        /// Eine Liste mit Bilder-Dateinamen
        /// </summary>
        /// <returns>List-Objekt mit den Dateinamen der Gallerie-Bilder.</returns>
        public static List<string> GetImageNames()
        {
            string p = String.Format(PhysicalUploadPath + "thumb/");
            DirectoryInfo dirIn = new DirectoryInfo(p);
            FileInfo[] imagesNames = dirIn.GetFiles();
            List<string> list = new List<string>();


            foreach (var imageFile in imagesNames)
            {
                var imageName = imageFile.Name;
                list.Add(imageName);
            }

            return list;
        }
    }
}