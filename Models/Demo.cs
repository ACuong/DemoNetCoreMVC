using System;
using System.ComponentModel.DataAnnotations;

namespace DemoDotNetMVC.Models
{
 
    public class Demo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}