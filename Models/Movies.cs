

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Movies
    {
        [Key]
        
        public string MoviesID { get; set; }


        [StringLength(60, MinimumLength = 3)] // độ dài text nhiều nhất 60, ngắn nhất 3 từ - tất cả ký tự
        [Required(ErrorMessage = "Tên không được để trống")]        // không được để trống 
        [Display(Name ="Tên phim")]
        public string MoviesName { get; set; }


        [Range(1, 100)] // giá trị trong khoảng
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
       
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] // bắt đầu bằng chữ hoa A-Z và có thể thêm các ký tự A-Z, a-z
        [Required(ErrorMessage = "Thiếu thể loại .")]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] // bắt đầu bằng chữ hoa A-Z và có thể thêm các ký tự A-Z, a-z, số từ 0-9
        [StringLength(5)] // độ dài bằng 5
        [Required] // không đưuọc để trống
        public string Rating { get; set; }    
    }
}