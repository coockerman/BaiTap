using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapSanPham
{
    internal class Product
    {
        public string MaSP { get; set; }
        public string NameSP { get; set; }
        public string FromSP { get; set; }
        public string YearSP { get; set; }

        public Product(string maSP, string nameSP, string fromSP, string yearSP)
        {
            MaSP = maSP;
            NameSP = nameSP;
            FromSP = fromSP;
            YearSP = yearSP;
        }
    }
}
