using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL;
namespace QL_CaPhe.BLL
{
    class BanBLL
    {
        BanDAL ban;
        public BanBLL()
        {
            ban = new BanDAL();
        }
        public int soluongban()
        {
            return ban.soluongban();
        }
    }
}
