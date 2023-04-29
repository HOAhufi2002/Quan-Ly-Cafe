using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe.GUI
{
    public partial class frmChiTietSuCo : Form
    {
        string masuco;
        public frmChiTietSuCo(string masuco)
        {
            InitializeComponent();
            this.masuco = masuco;
        }

        private void frmChiTietSuCo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.SUCO' table. You can move, or remove it, as needed.
            this.sUCOTableAdapter.Fill(this.qL_CaPhe.SUCO);
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_CaPhe.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_CaPhe.KHACHHANG);
            loaddata();
        }
        void loaddata()
        {
            DataTable a = this.sUCOTableAdapter.GetData_ChiTietMa(masuco);
            txt_infCast_Incident.Text = a.Rows[0][4].ToString();
            txt_infCategory_Incident.Text = a.Rows[0][0].ToString();
            txt_infName_Incident.Text = a.Rows[0][1].ToString();
            txt_Solve_Incident.Text = a.Rows[0][3].ToString();
            dtp_NgayLap.Text = a.Rows[0][2].ToString();
            cbo_Employee_Incident.SelectedValue = a.Rows[0][6].ToString();
            cbo_Name_Custumer_Incident.SelectedValue = a.Rows[0][5].ToString();
        }

        private void frmChiTietSuCo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void ptb_RemoveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
