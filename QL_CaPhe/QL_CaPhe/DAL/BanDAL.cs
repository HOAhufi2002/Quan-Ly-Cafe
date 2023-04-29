using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
namespace QL_CaPhe.DAL
{
    class BanDAL
    {
        BANTableAdapter ban;
        public BanDAL()
        {
            ban = new BANTableAdapter();
        }
        public int soluongban()
        {
            return (int)ban.SoLuongBan();
        }
    }
}
