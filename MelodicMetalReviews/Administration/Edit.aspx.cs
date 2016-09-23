using MelodicMetalReviews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MelodicMetalReviews.Administration
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Album> GetAlbums()
        {
            var _db = new AlbumContext();
            var query = _db.Albums;
            return query;
        }
        
        public IQueryable<Album> GetAlbum()
        {
            int albumId = Convert.ToInt32(Request.QueryString.Get("id"));
            DetailsView1.DefaultMode = DetailsViewMode.Edit;
            var db = new AlbumContext();
            var query = from album in db.Albums
                        where album.AlbumID == albumId
                        select album;
            return query;
        }

        public void UpdateAlbum(int albumID)
        {
            using (AlbumContext db = new AlbumContext())
            {
                Album item = null;
                item = db.Albums.Find(albumID);
                if (item == null)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", albumID));
                    return;
                }

                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }
        public void DeleteAlbum(int albumID)
        {
            using (AlbumContext db = new AlbumContext())
            {
                var item = new Album { AlbumID = albumID };
                db.Entry(item).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} no longer exists in the database", albumID));
                }
            }
        }
    }
}
