using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QL_CaPhe.DTO
{
    class GoiMon
    {
        public Ban ban { get; set; }
        public List<HoaDon> hd {get; set;}
        public List<ChiTietHoaDon> cthd { get; set; }
        public KhachHang kh { get; set; }
        public GoiMon()
        {
            ban = new Ban();
            hd = new List<HoaDon>();
            cthd = new List<ChiTietHoaDon>();
            kh = new KhachHang();
        }
    }
}
