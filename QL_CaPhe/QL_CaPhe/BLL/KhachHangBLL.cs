using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL;
using QL_CaPhe.DTO;
namespace QL_CaPhe.BLL
{
    class KhachHangBLL
    {
        KhachHangDAL dal;
        public KhachHangBLL()
        {
            dal = new KhachHangDAL();
        }
        public bool kiemtraKH(string sdt)
        {
            return dal.kiemtraKH(sdt);
        }
         public bool Insert(KhachHang a)
        {
            return dal.Insert(a);
        }
         public List<KhachHang> ThongTinKH(string sdt)
         {
             return dal.ThongTinKH(sdt);
         }
         public int tongKH()
         {
             return dal.tongKH();
         }

         public int tongDTL()
         {
             return dal.tongDTL();
         }

    }
}
