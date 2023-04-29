using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DTO
{
    class MuaHang
    {
        public HoaDon hd { get; set; }
        public ChiTietHoaDon cthd { get; set; }

        public KhachHang kh { get; set; }
        public MuaHang()
        {
            hd = new HoaDon();
            cthd = new ChiTietHoaDon();
            kh = new KhachHang();
        }
    }
}
