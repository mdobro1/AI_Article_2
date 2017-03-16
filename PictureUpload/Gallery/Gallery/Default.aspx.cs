using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


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