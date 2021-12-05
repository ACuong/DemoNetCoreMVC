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

        [StringLength(60, MinimumLength = 2)] 
        [Required(ErrorMessage = "Thiếu tên chuyên ngành .")]
        [Display(Name ="Tên Chuyen Nganh")]
        public string ChuyenNganhName { get; set; }


        [StringLength(60, MinimumLength = 2)] 
        [Required(ErrorMessage = "Thiếu tên chuyên sâu .")]
        public string ChuyenSau { get; set; }

        public int KhoaId { get; set; }
        public Khoa Khoa {get; set;}

        internal static Task<string> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}