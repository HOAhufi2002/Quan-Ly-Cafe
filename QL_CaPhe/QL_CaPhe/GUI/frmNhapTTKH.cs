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
    public partial class frmNhapTTKH : Form
    {
        KhachHangBLL khbll;
        KhachHang kh;
        public frmNhapTTKH()
        {
            InitializeComponent();
        }
        void khoitao()
        {
            this.Width = 350;
            this.Height = 150;
        }
        private void frmNhapTTKH_Load(object sender, EventArgs e)
        {
            khbll = new KhachHangBLL();
            kh = new KhachHang();
            khoitao();
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            this.Height = 300;
        }

        private void btn_Kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txt_Sdt.Text))
                {
                    MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                if(khbll.kiemtraKH(txt_Sdt.Text))
                {
                    kh = khbll.ThongTinKH(txt_Sdt.Text)[0];
                    MessageBox.Show("Khách hàng đã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Khách hàng chưa đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống: 0192", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        KhachHang gandulieu()
        {
            kh.MaKH = random();
            kh.TenKH = txt_tenKH.Text;
            kh.SDT = txt_sdt2.Text;
            return kh;
        }
        string random()
        {
            Random a = new Random();
            string ma = "KH";
            for (int i = 0; i < 3; i++)
            {
                ma += a.Next(1, 99).ToString();
            }
            return ma;
        }
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_tenKH.Text) || String.IsNullOrEmpty(txt_tenKH.Text))
                {
                    MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return ;
                }
                if(khbll.Insert(gandulieu()))
                {
                    MessageBox.Show("Khách hàng đã đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    panel1.Enabled = true;
                    khoitao();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    panel1.Enabled = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống: 0291", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }
        internal KhachHang khachhangorder()
        {
            return kh;
        }
        private void btn_Chapnhan_Click(object sender, EventArgs e)
        {
            if (!khbll.kiemtraKH(txt_Sdt.Text))
            {
                MessageBox.Show("Khách hàng chưa đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                kh = khbll.ThongTinKH(txt_Sdt.Text)[0];
            }
            this.Close();
            
        }
    }
}
