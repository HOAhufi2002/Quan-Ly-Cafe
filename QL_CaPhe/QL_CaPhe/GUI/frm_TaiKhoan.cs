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
    public partial class frm_TaiKhoan : Form
    {
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_themPN_Click(object sender, EventArgs e)
        {
            frm_ThemTK frm = new frm_ThemTK();
            frm.Show();
        }

        private void Thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_CaPhe.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.qL_CaPhe.TAIKHOAN);
            lbl_Total_Material.Text = (dgv_mataikhoan.RowCount - 1).ToString();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" tải lại thành công ");
            this.tAIKHOANTableAdapter.Fill(this.qL_CaPhe.TAIKHOAN);
        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                tAIKHOANBindingSource.EndEdit();
                tAIKHOANTableAdapter.Update(qL_CaPhe.TAIKHOAN);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.Show();
        }

        private void In_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
