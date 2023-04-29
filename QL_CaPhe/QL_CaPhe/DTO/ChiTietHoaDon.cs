using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DTO
{
    class ChiTietHoaDon
    {
        public string MaMon { get; set; }
        public string MaHD { get; set; }
        public int SoLuong { get; set; }

        public decimal ThanhTien { get; set; }
        public ChiTietHoaDon()
        {
            SoLuong = 0;
        }
    }
}
