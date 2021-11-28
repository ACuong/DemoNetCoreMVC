using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace DemoDotNetMVC.Models
{
 
    public class ChuyenNganh
    {
        [Key]
        public int ChuyenNganhId { get; set; }


        [Display(Name ="Tên Chuyen Nganh")]
        public string ChuyenNganhName { get; set; }

        public int KhoaId { get; set; }
        public Khoa Khoa {get; set;}

        internal static Task<string> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}