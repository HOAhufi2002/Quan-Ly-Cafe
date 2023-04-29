using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using QL_CaPhe.DTO;
namespace QL_CaPhe.DAL
{
    class ChiTietHoaDonDAL
    {
         CHITIETHOADONTableAdapter cthd;
         public ChiTietHoaDonDAL()
        {
            cthd = new CHITIETHOADONTableAdapter();
        }
        public bool Insert(ChiTietHoaDon a)
        {
            try
            {
                int i = (int)cthd.Insert(a.MaMon,a.MaHD,a.SoLuong,a.ThanhTien);
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
