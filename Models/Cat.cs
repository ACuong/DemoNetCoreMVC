using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Cat : Animal
    {
       
       [Display(Name ="Mã Mèo")]
        public int CatlId { get; set; }

        [Display(Name ="Giống")]
        public string Giong { get; set; }
    }
}