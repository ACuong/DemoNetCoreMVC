using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDotNetMVC.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Adress { get; set; }
    }
}