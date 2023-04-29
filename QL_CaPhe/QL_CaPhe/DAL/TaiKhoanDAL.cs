using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Data;
using System.Windows.Forms;
namespace QL_CaPhe.DAL
{
    
    class TaiKhoanDAL
    {
        SqlConnection conn;
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        //public string insert(string MaNV, string TenDangNhap, string HoTen, string GioiTinh, DateTime NgaySinh, string SdtNV, ComboBox MaCV)
        //{
        //    conn.Open();
        //    string sql = "";
        //    SqlCommand cmd;
        //    sql = "set dateformat dmy; Insert into NHANVIEN values('" + MaNV + "','" + TenDangNhap + "', N'" + HoTen + "', N'" + GioiTinh + "', '" + SdtNV + "', cast('" + DateTime.Parse(NgaySinh.ToString()).ToString("d") + "' as date) ,'" + MaCV.SelectedValue.ToString() + "')";
        //    cmd = new SqlCommand(sql, conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
        //    return sql;
        //}
        public string Insert(string tendangnhap, string matkhau)
        {

            connect.Open();
            string sql = "";
            SqlCommand cmd;
            sql = "insert into taikhoan values('" + tendangnhap + "', '" + matkhau + "')";
            cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
            return sql;


        }
        
        
        
        TAIKHOANTableAdapter tk;
        DataConnect con;
        public TaiKhoanDAL()
        {
            tk= new TAIKHOANTableAdapter();
            con = new DataConnect();
            conn = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        }
        public List<TaiKhoan> thongtintaikhoan(string tendangnhap)
        {
            DataTable dt = tk.ThongTin_taikhoan(tendangnhap);
            List<TaiKhoan> k = con.ListTable<TaiKhoan>(dt);
            return k;
        }
        public bool kiemTraDN(TaiKhoan a)
        {
            try
            {
                int i = int.Parse(tk.KiemtraTaiKhoan(a.TenDangNhap, a.MatKhau).ToString());
                if (i == 1)
                {
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
