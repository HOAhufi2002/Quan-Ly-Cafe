using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Data;
using System.Collections.Generic;

namespace QL_CaPhe.BLL
{
    class NguyenLieuBLL
    {

        NguyenLieuDAL dal = new NguyenLieuDAL();
        public bool Insert(NguyenLieu a)
        {
            return dal.Insert(a);
        }
        
    }
}
