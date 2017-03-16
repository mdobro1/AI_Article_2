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

                string image = Request.QueryString["img"];

                object imageTag = Session[image];

                var imageOK = true;
                if (imageTag != null)
                    imageOK = (bool)imageTag;

                bigImgDisplay.Visible = true;

                if (!imageOK)
                {
                    if (image != null)
                        ShowNotApproved();
                    else
                        ShowEmptyState();
                }
                else
                {
                    if (image != null)
                        bigImg.ImageUrl = "~/Pictures/" + image;
                    else
                        ShowEmptyState();

                }
            }
            if (Session["Uploadsuccses"] != null)
            {
                SuccessMessagePlaceHolder.Visible = true;
                Session.Remove("Uploadsuccses");
            }
 
            PicList.DataSource = Gallery.GetImageNames();
            PicList.DataBind();
        }

        private void ShowNotApproved()
        {
            bigImg.ImageUrl = "~/Gfx/stop.jpg";
            NotAllowedPlaceHolder.Visible = true;
            NoPicturePlaceHolder.Visible = false;
        }

        private void ShowEmptyState()
        {
            bigImg.ImageUrl = "~/Gfx/empty.jpg";
            NotAllowedPlaceHolder.Visible = false;
            NoPicturePlaceHolder.Visible = true;
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