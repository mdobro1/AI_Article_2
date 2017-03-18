using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
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

        private void showImage(string image)
        {

            // TODO call EvaluateImage here

            //   string type = "raw";
            //    string urlImage = "";
            //   var expectSizeException = false;


            object imageTag = Session[image];

            if (imageTag == null)
                imageTag = true;

            var imageOK = (bool)imageTag;

            if (!imageOK)
            {
                bigImg.ImageUrl = "~/Gfx/stop.jpg";
                NotAllowedPlaceHolder.Visible = true;
            }
            else
            {
                if (image != null)
                    bigImg.ImageUrl = "~/Pictures/" + image;
                else
                {
                    bigImg.ImageUrl = "~/Gfx/empty.jpg";
                    NoPicturePlaceHolder.Visible = true;
                }
            }

            bigImgDisplay.Visible = true;
        }

        private static async System.Threading.Tasks.Task<EvaluateImageResult> EvaluateImage(
            string type, string urlImage, byte[] rawImage, bool expectSizeException)
        {
            var moderator =
                new ModeratorClient("?");


            EvaluateImageResult result = null;


            switch (type)
            {
                case "url":
                    {
                        result = await moderator.EvaluateImageAsync(
                                    urlImage, DataRepresentationType.Url, expectSizeException);
                        break;
                    }
                case "raw":
                    {
                        result = await moderator.EvaluateImageAsync(
                                    new System.IO.MemoryStream(rawImage), expectSizeException);
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

                Gallery modelGallery = new Gallery();

                modelGallery.SaveImage(stream, upload);
                Session["Uploadsuccses"] = true;
                Response.Redirect("Default.aspx?img=" + upload);
            }
        }
    }
}