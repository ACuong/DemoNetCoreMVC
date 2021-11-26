using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Movies
    {
        [Key]
        public string MoviesID { get; set; }

        [Display(Name ="Tên")]
        public string MoviesName { get; set; }
    }
}