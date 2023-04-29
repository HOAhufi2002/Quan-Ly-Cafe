using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using QL_CaPhe.DTO;
using System.Data;
namespace QL_CaPhe.DAL
{
    class LoaiMonDAL
    {
        LOAIMONTableAdapter loai;
        public LoaiMonDAL()
        {
            loai = new LOAIMONTableAdapter();
        }
        public int soluongLoaiMon()
        {
            return (int)loai.SoLuongLoaiMon();
        }
        public List<LoaiMon> Getdata()
        {
            DataConnect con = new DataConnect();
            return con.ListTable<LoaiMon>(loai.GetData());
        }
    }
}
