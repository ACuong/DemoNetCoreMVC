using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Display(Name ="Tên Loài vật")]
        public string AnimalName { get; set; }
    }
}