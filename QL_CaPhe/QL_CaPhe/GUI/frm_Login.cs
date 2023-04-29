using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CaPhe.DTO;
using QL_CaPhe.BLL;
namespace QL_CaPhe.GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        NhanVienBLL nvbll;
        TaiKhoanBLL tk;
        private void ptb_DangNhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn vui lòng điền mật khẩu");
                return;
            }
            if (String.IsNullOrEmpty(txt_Tendangnhap.Text))
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập");
                return;
            }
            tk = new TaiKhoanBLL();
            nvbll = new NhanVienBLL();
            TaiKhoan a = new TaiKhoan();
            a.TenDangNhap = txt_Tendangnhap.Text;
            a.MatKhau = txt_MatKhau.Text;
            if (tk.kiemTraDN(a))
            {

                a = tk.thongtintaikhoan(a.TenDangNhap)[0];
                NhanVien nva = nvbll.Thongtinnhanvien(a.TenDangNhap)[0];
                int i = nvbll.phanquyen(nva.MaCV);
                frm_TrangChu frm = new frm_TrangChu(nva, nvbll.phanquyen(nva.MaCV));
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ptb_DangNhap_Click(sender, e);
            }
        }
    }
}
