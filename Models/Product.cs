using System;
using System.ComponentModel.DataAnnotations;

namespace DemoDotNetMVC.Models
{
    [Table "Product"]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}