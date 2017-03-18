using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.ContentModerator;
using Microsoft.CognitiveServices.ContentModerator.Contract.Image;


namespace Gallery
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NotAllowedPlaceHolder.Visible = false;
                NoPicturePlaceHolder.Visible = false;
                SuccessMessagePlaceHolder.Visible = false;

                showImage(Request.QueryString["img"]);
            }

            if (Session["Uploadsuccses"] != null)
            {
                SuccessMessagePlaceHolder.Visible = true;
                Session.Remove("Uploadsuccses");
            }

            PicList.DataSource = Gallery.GetImageNames();
            PicList.DataBind();
        }

        private async void showImage(string image)
        {
            bigImg.ImageUrl = "~/Gfx/stop.jpg";
            NotAllowedPlaceHolder.Visible = true;

            bool imageOK = false;

            var msRawImage = new MemoryStream();
            var imageFileContent = (Stream)Session["FileContent"];

            if (imageFileContent != null)
            {
                await imageFileContent.CopyToAsync(msRawImage);
                var evaluationResult = await EvaluateImage(msRawImage.ToArray());

                imageOK = true;
            }

            if (imageOK && image != null)
            {
                bigImg.ImageUrl = "~/Pictures/" + image;
                NotAllowedPlaceHolder.Visible = false;
                NoPicturePlaceHolder.Visible = false;
            }
            else
            {
                bigImg.ImageUrl = "~/Gfx/empty.jpg";
                NoPicturePlaceHolder.Visible = true;
            }            

            bigImgDisplay.Visible = true;
        }

        private static async Task<EvaluateImageResult> EvaluateImage(
            string urlImage)
        {
            return await EvaluateImage("url", urlImage, null, true);
        }

        private static async Task<EvaluateImageResult> EvaluateImage(
            byte[] rawImage)
        {
            return await EvaluateImage("raw", null, rawImage, true);
        }

        private static async Task<EvaluateImageResult> EvaluateImage(
            string type, string urlImage, byte[] rawImage, bool cacheImage)
        {
            // init
            EvaluateImageResult result = null;
            var moderator = new ModeratorClient("?");
            
            // go
            switch (type)
            {
                case "url":
                    {
                        result = await moderator.EvaluateImageAsync(
                                    urlImage, DataRepresentationType.Url, cacheImage);
                        break;
                    }
                case "raw":
                    {
                        result = await moderator.EvaluateImageAsync(
                                    new System.IO.MemoryStream(rawImage), cacheImage);
                        break;
                    }
            }

            return result;
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var upload = PictureFileUpload.FileName;
                var stream = PictureFileUpload.FileContent;
                Session["FileContent"] = stream;

                Gallery modelGallery = new Gallery();

                modelGallery.SaveImage(stream, upload);
                Session["Uploadsuccses"] = true;
                Response.Redirect("Default.aspx?img=" + upload);
            }
        }
    }
}