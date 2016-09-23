using MelodicMetalReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MelodicMetalReviews.Logic
{
    public class AddAlbums
    {
        public bool AddAlbum (
            string albumName,
            int bandId,
            DateTime releaseDate,
            decimal rating,
            string review,
            string imagePath
            )
        {
            var myAlbum = new Album();
            myAlbum.AlbumName = albumName;
            myAlbum.BandID = bandId;
            myAlbum.ReleaseDate = releaseDate;
            myAlbum.Rating = rating;
            myAlbum.Review = review;
            myAlbum.ImagePath = imagePath;

            using (AlbumContext _db = new AlbumContext())
            {
                _db.Albums.Add(myAlbum);
                _db.SaveChanges();
            }

            return true;
        }
    }
}