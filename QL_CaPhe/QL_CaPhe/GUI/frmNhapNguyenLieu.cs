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
    public partial class frmNhapNguyenLieu : Form
    {
        public frmNhapNguyenLieu()
        {
            InitializeComponent();
        }
        NguyenLieuBLL nl = new NguyenLieuBLL();
        private void frmNhapNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            this.Hide();
            this.Owner.Show();
        }
        NguyenLieu ganDuLieu()
        {
            try
            {
                NguyenLieu a = new NguyenLieu();
                a.MaHang = txt_Category_Material.Text;
                a.TenHang = txt_Name_Material.Text;
                a.NgayHetHan = dtp_HSD.Value;
                a.SoLuongNhap = int.Parse(txt_QuanityImport_Material.Text);
                a.DonGia = double.Parse(txt_Cast_Material.Text);
                a.MaNV = cbo_NhanVien.SelectedValue.ToString();
                a.DonViTinh = txt_DonVi.Text;
                return a;
            }
            catch
            {
                return null;
            }
          
        }
        private void ptb_AddAccount_Click(object sender, EventArgs e)
        {
            NguyenLieu a = ganDuLieu();
            if (a == null)
            {
                MessageBox.Show("bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            bool kq = nl.Insert(a);
            if(kq)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");
                ptb_RemoveAccount_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Mã đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

        private void ptb_RemoveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);

        }

        private void txt_Cast_Material_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_QuanityImport_Material_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
