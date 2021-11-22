using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DemoDotNetMVC.Models
{
 
    public class Khoa
    {
        [Key]
        public int KhoaId { get; set; }

        [Display(Name ="Tên Khoa")]
        public string KhoaName { get; set; }
        public ICollection<ChuyenNganh> ChuyenNganhs {get;set;}
    }
}