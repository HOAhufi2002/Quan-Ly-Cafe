using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Data;
namespace QL_CaPhe.BLL
{
    class MonBLL
    {
        MonDAL dal = new MonDAL();
        public List<Mon> GetList( )
        {
            return dal.GetList();
        }
        public List<Mon> GetList_MaLoai(string maloai)
        {
            return dal.GetList_Maloai(maloai);
        }
        public bool Insert(Mon a)
        {
            return dal.Insert(a);
        }
        public bool Delete(Mon a)
        {
            return dal.Delete(a);
        }
        public bool Update(Mon a)
        {
            return dal.Update(a);
        }
        public int? SLCon()
        {
            return dal.SLCon();

        }
        public int? SLHet()
        {
            return dal.SLHet();
        }
        public int? TongMon()
        {
            return dal.TongMon();
        }

    }
}
