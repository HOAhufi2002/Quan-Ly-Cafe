using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL;
using QL_CaPhe.DTO;
namespace QL_CaPhe.BLL
{
    class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL dal;
        public ChiTietHoaDonBLL()
        {
            dal = new ChiTietHoaDonDAL();
        }
        public bool Insert(ChiTietHoaDon a)
        {
            return dal.Insert(a);
        }

    }
}
