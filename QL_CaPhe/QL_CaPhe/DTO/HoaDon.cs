using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DTO
{
    class HoaDon
    {
        public string MaHD { get; set; }
        public DateTime NgayThanhLap { get; set; }

        public string MaNV { get; set; }

        public string MaKH { get; set; }
        public string MaBan { get; set; }
        public decimal MaGiam { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
