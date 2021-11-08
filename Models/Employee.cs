using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoDotNetMVC.Models
{
     public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name ="Tên Nhân Viên")]
        public string EmployeeName { get; set; }

        [Display(Name ="Số điện thoại Nhân Viên")]
        public int PhoneNumber { get; set; }
    }
}