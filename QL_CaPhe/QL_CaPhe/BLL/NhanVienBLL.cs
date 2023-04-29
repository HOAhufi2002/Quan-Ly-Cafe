using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL;
namespace QL_CaPhe.BLL
{
    class NhanVienBLL
    {
        NhanVienDAL dal;
        public NhanVienBLL()
        {
            dal = new NhanVienDAL();
        }
        public List<NhanVien> Thongtinnhanvien(string tendangnhap)
        {
            return dal.Thongtinnhanvien(tendangnhap);
        }
        public int phanquyen(string macv)
        {
            return dal.phanquyen(macv);
        }
    }
}
