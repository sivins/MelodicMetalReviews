using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MelodicMetalReviews.Models
{
    public class Album
    {
        [Key]
        [ScaffoldColumn(false)]
        public int AlbumID { get; set; }

        [Required, StringLength(100), Display(Name = "Album Name")]
        public string AlbumName { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(10000), Display(Name = "Review")]
        public string Review { get; set; }

        [Required]
        public decimal Rating { get; set; }

        public int BandID { get; set; }
        public virtual Band Band { get; set; }
        
    }
}