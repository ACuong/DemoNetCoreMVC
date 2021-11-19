using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
 
    public class Teacher : Person
    {
        
        [Display(Name ="Mã Giáo viên")]
        public int TeacherId { get; set; }

        [Display(Name ="Địa Chỉ")]
        public string DiaChi { get; set; }
    }
}