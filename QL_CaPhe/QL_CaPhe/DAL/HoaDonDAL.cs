using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using QL_CaPhe.DTO;
namespace QL_CaPhe.DAL
{
    class HoaDonDAL
    {
        HOADONTableAdapter hd;
        public HoaDonDAL()
        {
            hd = new HOADONTableAdapter();
        }
        public bool Insert(HoaDon a)
        {
            try
            {
                int i = (int)hd.Insert(a.MaHD, a.NgayThanhLap,a.MaNV,a.MaKH,a.MaBan,a.MaGiam,a.ThanhTien);
                if (i == 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
