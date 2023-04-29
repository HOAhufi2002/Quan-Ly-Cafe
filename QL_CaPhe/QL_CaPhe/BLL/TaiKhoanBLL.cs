using QL_CaPhe.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
namespace QL_CaPhe.BLL
{
    class TaiKhoanBLL
    {
        TaiKhoanDAL dal;
        public TaiKhoanBLL()
        {
            dal = new TaiKhoanDAL();
        }
        public string Insert(string tendangnhap, string matkhau)
        {
            return dal.Insert(tendangnhap, matkhau);
        }
        public List<TaiKhoan> thongtintaikhoan(string tendangnhap)
        {
            return dal.thongtintaikhoan(tendangnhap);
        }
        public bool kiemTraDN(TaiKhoan a)
        {
            return dal.kiemTraDN(a);
        }
    }
}
