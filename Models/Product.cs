using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name ="Tên sản phẩm")]
        public string ProductName { get; set; }

        [Display(Name ="Đơn giá")]
        public int UnitPrice { get; set; }

        [Display(Name ="Số lượng")]
        public int Quantity { get; set; }
    }
}