using System;
using System.ComponentModel.DataAnnotations;

namespace DemoDotNetMVC.Models
{
    [Table "Employee"]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int PhoneNumber { get; set; }
    }
}