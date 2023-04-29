using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QL_CaPhe.DAL
{
    public class NhanVienDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        public string insert(string MaNV,string TenDangNhap, string HoTen, string GioiTinh, DateTime NgaySinh, string SdtNV, ComboBox MaCV)
        {
            conn.Open();
            string sql = "";
            SqlCommand cmd;
            sql = "set dateformat dmy; Insert into NHANVIEN values('" + MaNV + "','" + TenDangNhap + "', N'" + HoTen + "', N'" + GioiTinh + "', '" + SdtNV + "', cast('" + DateTime.Parse(NgaySinh.ToString()).ToString("d") + "' as date) ,'" + MaCV.SelectedValue.ToString() + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
            return sql;
        }
        public string delete(string manv)
        {
            conn.Open();
            string sql = "";
            SqlCommand cmd;
            sql = "delete from Nhanvien where MaNV ='" + manv + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("xóa tài khoản nhân viên thành công", "Thông báo");
            conn.Close();
            return sql;
        }
        
        
        NHANVIENTableAdapter nv;
        DataConnect con;
        public NhanVienDAL()
        {
            nv = new NHANVIENTableAdapter();
            con = new DataConnect();
        }
        public List<NhanVien> Thongtinnhanvien(string tendangnhap)
        {
            DataTable dt = nv.ThongTin_NhanVien_MaNV(tendangnhap);
            List<NhanVien> k = con.ListTable<NhanVien>(dt);
            return k;
        }
        public int phanquyen(string macv)
        {
            try
            {
                int i = (int)nv.Phanquyen(macv);
                return i;
            }
            catch
            {
                return 0;
            }
        }
    }
}
