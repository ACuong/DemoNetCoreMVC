using System;
using System.ComponentModel.DataAnnotations;

namespace DemoDotNetMVC.Models
{
    [Table "Student"]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Adress { get; set; }
    }
}