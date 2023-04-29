using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL;
using QL_CaPhe.DTO;
namespace QL_CaPhe.BLL
{
    class HoaDonBLL
    {
        HoaDonDAL dal;
        public HoaDonBLL()
        {
            dal = new HoaDonDAL();
        }
        public bool Insert(HoaDon a)
        {
            return dal.Insert(a);
        }

    }
}
