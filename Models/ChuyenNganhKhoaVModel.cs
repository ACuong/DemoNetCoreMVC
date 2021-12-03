using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DemoDotNetMVC.Models
{
    public class ChuyenNganhKhoaVModel
    {
        public List<ChuyenNganh> ChuyenNganhs { get; set; }
        public SelectList ChuyenSauList { get; set; }
        public string ChuyenSauIn { get; set; }
        public string SearchString { get; set; }
    }
}