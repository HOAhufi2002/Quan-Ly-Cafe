using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CaPhe.BLL;
using QL_CaPhe.DTO;
namespace QL_CaPhe.GUI
{
    //Phân quyền 0 là admin
    // Phân quyền 1 là quản lý
    // Phần quyền 2 là thu ngân
    //Phân quyền 3 là quản lý kho
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        int phanquyen;
        public frm_TrangChu(NhanVien a, int i )
        {
            InitializeComponent();
            nv = a;
            phanquyen = i;
        }
        NhanVien nv;
        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            btn_MuaHang_Click(sender, e);
        }

        private void btn_MuaHang_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.panel8.Controls.Clear();
                if (phanquyen == 3)
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (phanquyen >= 0)
                {
                    frmGoiMon  frm = new frmGoiMon(nv);
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
           catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
         
          try
            {
               
                this.panel8.Controls.Clear();
                if (phanquyen == 3)
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (phanquyen >= 0)
                {
                    frm_NhanVien frm = new frm_NhanVien(phanquyen);
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.panel8.Controls.Clear();
                if (phanquyen == 3)
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (phanquyen >= 0)
                {
                    frm_KhachHang frm = new frm_KhachHang();
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.panel8.Controls.Clear();
                if (phanquyen == 3)
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (phanquyen >= 0)
                {
                    frm_HoaDon frm = new frm_HoaDon();
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
           
        }

        private void btn_NguyenLieu_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.panel8.Controls.Clear();
               
                if (phanquyen >= 0)
                {
                    frmNguyenLieu frm = new frmNguyenLieu(phanquyen);
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.panel8.Controls.Clear();
                if (phanquyen == 3 || phanquyen == 2)
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (phanquyen == 0)
                {
                    frm_TaiKhoan frm = new frm_TaiKhoan();
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_SuCo_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.panel8.Controls.Clear();
                if (phanquyen == 3)
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (phanquyen >= 0)
                {
                    FrmSuCo frm = new FrmSuCo();
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                this.panel8.Controls.Clear();
                
                if (phanquyen >= 0)
                {
                    frmDoanhThu frm = new frmDoanhThu();
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_Mon_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.panel8.Controls.Clear();
                if (phanquyen >= 0)
                {
                    frmMoncs frm = new frmMoncs();
                    frm.TopLevel = false;
                    this.panel8.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void frm_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                e.Cancel = false;
            }
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            this.Close();
            frm.ShowDialog();
        }

       
    }
}
