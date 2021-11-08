using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Display(Name ="Tên")]
        public string PersonName { get; set; }
    }
}