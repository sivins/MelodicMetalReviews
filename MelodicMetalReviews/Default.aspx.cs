﻿using MelodicMetalReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MelodicMetalReviews
{
    public partial class Default : System.Web.UI.Page
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