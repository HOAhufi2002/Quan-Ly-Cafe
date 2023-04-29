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
    public partial class frmPhieuNhapSuCo : Form
    {
        public frmPhieuNhapSuCo()
        {
            InitializeComponent();
        }
        SuCoBLL sc = new SuCoBLL();
        SuCo ganDuLieu()
        {
            try
            {
                SuCo a = new SuCo();
                a.MaBienBan = txt_infCategory_Incident.Text ;
                a.TenBienBan = txt_infName_Incident.Text;
                a.GiaiQuyet = txt_Solve_Incident.Text;
                a.ChiPhi = decimal.Parse(txt_infCast_Incident.Text);
                a.MaKH = cbo_Name_Custumer_Incident.SelectedValue.ToString();
                a.MaNV = cbo_Employee_Incident.SelectedValue.ToString();
                a.NgayLap = dtp_NgayLap.Value;
                return a;
            }
            catch
            {
                return null;
            }

        }
        private void ptb_AddAccount_Click(object sender, EventArgs e)
        {
            SuCo a = ganDuLieu();
            if (a == null)
            {
                MessageBox.Show("bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            bool kq = sc.Insert(a);
            if (kq)
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

        private void frmPhieuNhapSuCo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txt_infCast_Incident_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmPhieuNhapSuCo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_CaPhe.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_CaPhe.KHACHHANG);

        }

       
    }
}
