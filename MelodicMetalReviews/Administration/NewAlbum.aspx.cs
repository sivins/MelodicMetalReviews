using MelodicMetalReviews.Logic;
using MelodicMetalReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MelodicMetalReviews.Administration
{
    public partial class NewAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Band> GetBands()
        {
            var db = new AlbumContext();
            var query = db.Bands;
            return query;
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Images/");
            if (ImageUpload.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ImageUpload.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    //Save to Images folder.
                    ImageUpload.PostedFile.SaveAs(path + ImageUpload.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                //Add product data to DB.
                AddAlbums albums = new AddAlbums();
                bool addSuccess = albums.AddAlbum(
                        AlbumNameField.Text, 
                        Convert.ToInt32(BandPicker.SelectedValue), 
                        ReleaseDatePicker.SelectedDate, 
                        Convert.ToDecimal(RadioButtonList1.SelectedValue), 
                        ReviewField.Text, 
                        ("\\Images\\" + ImageUpload.FileName)
                    );
                if (addSuccess)
                {
                  // Reload the page.
                  string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                  Response.Redirect(pageUrl + "?ProductAction=add");
                }
                else
                {
                  LabelAddStatus.Text = "Unable to add new product to database.";
                }
          }
          else
          {
            LabelAddStatus.Text = "Unable to accept file type.";
          }
            
          
        }
    }
}