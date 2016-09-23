using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MelodicMetalReviews.Models
{
    public class Band
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BandID { get; set; }

        [Required, StringLength(100), Display(Name = "Band Name")]
        public string BandName { get; set; }

        [Required, StringLength(10000)]
        public string Bio { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}