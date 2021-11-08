using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Display(Name ="Tên")]
        public string StudentName { get; set; }

        [Display(Name ="Địa chỉ")]
        public String Adress { get; set; }
    }
}