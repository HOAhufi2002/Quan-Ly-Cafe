using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL;

namespace QL_CaPhe.BLL
{
    class SuCoBLL
    {
        SuCoDAL dal = new SuCoDAL();
        public bool Insert(SuCo a)
        {
            return dal.Insert(a);
        }
    }
}
