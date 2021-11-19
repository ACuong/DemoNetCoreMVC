using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace DemoDotNetMVC.Models
{
 
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name ="Tên danh mục")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products {get;set;}
    }
}