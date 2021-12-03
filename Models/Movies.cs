using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Movies
    {
        [Key]
        
        public string MoviesID { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]        
        [Display(Name ="Tên")]
        public string MoviesName { get; set; }

        public string Genre { get; set; }


    }
}