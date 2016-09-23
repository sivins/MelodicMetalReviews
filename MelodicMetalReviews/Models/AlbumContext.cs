using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MelodicMetalReviews.Models
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Band> Bands { get; set; }
    }
}