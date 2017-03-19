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
                NotAllowedPlaceHolder_Racy.Visible = false;
                NotAllowedPlaceHolder_Adult.Visible = false;
                NoPicturePlaceHolder.Visible = false;
                SuccessMessagePlaceHolder.Visible = false;

                var image = Request.QueryString["img"];
                var stop = image != null && image.Contains("stop");
                var adult = image != null && image.Contains("adult");
                var racy = image != null && image.Contains("racy");

                showImage(image, !stop, adult, racy);
            }

            if (Session["Uploadsuccses"] != null)
            {
                SuccessMessagePlaceHolder.Visible = true;
                Session.Remove("Uploadsuccses");
            }

            PicList.DataSource = Gallery.GetImageNames();
            PicList.DataBind();
        }
        
        private void showImage(string image, bool imageOK, bool adult, bool racy)
        {
            if (!imageOK)
            {
                bigImg.ImageUrl = "~/Gfx/stop.jpg";

                NotAllowedPlaceHolder.Visible = !imageOK;
                NotAllowedPlaceHolder_Adult.Visible = adult;
                NotAllowedPlaceHolder_Racy.Visible = racy;
            }
            else
            {
                if (image != null)
                {
                    bigImg.ImageUrl = "~/Pictures/" + image;
                }
                else
                {
                    bigImg.ImageUrl = "~/Gfx/empty.jpg";
                    NoPicturePlaceHolder.Visible = true;
                }
            }

            bigImgDisplay.Visible = true;
        }

        private static async Task<EvaluateImageResult> EvaluateImage(
            string key, string urlImage)
        {
            return await EvaluateImage(key, "url", urlImage, null, true);
        }

        private static async Task<EvaluateImageResult> EvaluateRawImage(
            string key, Stream rawImage)
        {
            if (rawImage == null)
                return null;
            else
                return await EvaluateImage(key, "raw", null, rawImage, true);
        }

        private static async Task<EvaluateImageResult> EvaluateImage(string key,
            string type, string urlImage, Stream rawImage, bool cacheImage)
        {
            // init
            EvaluateImageResult result = null;
            var moderator = new ModeratorClient(key);
            
            // go
            switch (type)
            {
                case "url":
                    {
                        result = await moderator.EvaluateImageAsync(urlImage, DataRepresentationType.Url, cacheImage);
                        break;
                    }
                case "raw":
                    {
                        result = await moderator.EvaluateImageAsync(rawImage, cacheImage);
                        break;
                    }
            }

            return result;
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            RegisterAsyncTask(new System.Web.UI.PageAsyncTask(UploadHandler)); 
        }

        private async Task UploadHandler()
        {
            if (IsValid)
            {
                // init
                var fileUpload = PictureFileUpload.FileName;
                var streamUpload = PictureFileUpload.FileContent;
                Gallery modelGallery = new Gallery();

                // check
                var subscriptionKey = System.Configuration.ConfigurationManager.AppSettings["ContentModerator_SubscriptionKey"];
                var result = await EvaluateRawImage(subscriptionKey, streamUpload);

                bool imageOK = result != null && !result.IsImageAdultClassified && !result.IsImageRacyClassified;

                // evaluate
                if (imageOK)
                {
                    modelGallery.SaveImage(streamUpload, fileUpload);
                    Session["Uploadsuccses"] = true;
                    Response.Redirect("Default.aspx?img=" + fileUpload);
                }
                else
                {
                    var errUrl = "Default.aspx?img=stop";

                    if (result.IsImageAdultClassified)
                        errUrl += "-adult";

                    if (result.IsImageRacyClassified)
                        errUrl += "-racy";

                    Session["Uploadsuccses"] = false;
                    Response.Redirect(errUrl);
                }
            }
        }
    }
}