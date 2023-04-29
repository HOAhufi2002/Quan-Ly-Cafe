using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
namespace QL_CaPhe.DAL
{
    class GoiMonDAL
    {
        GoiMon gm;
        public GoiMonDAL(List<HoaDon> a, KhachHang b, Ban c)
        {
            gm = new GoiMon();
            gm.hd = a;
            gm.ban = c;
            gm.kh = b;
        }


    }
}
