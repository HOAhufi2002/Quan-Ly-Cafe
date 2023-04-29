using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL;
namespace QL_CaPhe.BLL
{
    class LoaiMonBLL
    {
        LoaiMonDAL lm;
        public LoaiMonBLL()
        {
            lm = new LoaiMonDAL();
        }
        public int soluongLoaiMon()
        {
            return lm.soluongLoaiMon();
        }
        public List<LoaiMon> Getdata()
        {
            return lm.Getdata();
        }
    }
}
