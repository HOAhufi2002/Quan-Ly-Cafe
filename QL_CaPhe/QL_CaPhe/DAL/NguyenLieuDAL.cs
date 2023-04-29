using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Windows.Forms;
using System.Data;

namespace QL_CaPhe.DAL
{
    class NguyenLieuDAL
    {
        NGUYENLIEUTableAdapter dsnguyenlieu;
        DataConnect con;
        public NguyenLieuDAL()
        {
            con = new DataConnect();
            dsnguyenlieu = new NGUYENLIEUTableAdapter();
        }
        public bool Insert(NguyenLieu a)
        {
            try
            {
                int i = (int)dsnguyenlieu.KtraKhoa(a.MaHang);
                if (i == 0)
                {
                    i = dsnguyenlieu.Insert(a.MaHang, a.TenHang, DateTime.Now, a.NgayHetHan, a.SoLuongNhap, 0, a.DonViTinh, a.DonGia, a.MaNV);
                    if (i >= 1)
                        return true;

                }
                    return false;
            }
            catch 
            {
                return false;
            }
        }
        
    }
}
