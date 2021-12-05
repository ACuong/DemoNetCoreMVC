using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoDotNetMVC.Models
{
     public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "Thiếu tên nhân viên .")]
        [Display(Name ="Tên Nhân Viên")]
        public string EmployeeName { get; set; }


        [RegularExpression(@"^[0-9\s-]*$")]
        [Required(ErrorMessage = "Thiếu số điện thoại .")]

        [StringLength(10)]
        [Display(Name ="Số điện thoại Nhân Viên")]
        public int PhoneNumber { get; set; }
    }
}