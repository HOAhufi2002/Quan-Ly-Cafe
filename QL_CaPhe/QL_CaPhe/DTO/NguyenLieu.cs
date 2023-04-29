using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DTO
{
    class NguyenLieu
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int SoLuongNhap { get; set; }
        public int SoLuongXuat { get; set; }
        public string DonViTinh { get; set; }
        public double DonGia { get; set; }
        public string MaNV { get; set; }
    }
}
