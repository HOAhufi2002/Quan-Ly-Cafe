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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        KhachHangBLL kh = new KhachHangBLL();
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_CaPhe.KHACHHANG);
            textBox5.Text = kh.tongKH().ToString();
            textBox6.Text = kh.tongDTL().ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.FillByKHMoi(this.qL_CaPhe.KHACHHANG);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.FillByKHThanThiet(this.qL_CaPhe.KHACHHANG);
        }

        private void Luu_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.kHACHHANGBindingSource.EndEdit();
                this.kHACHHANGTableAdapter.Update(qL_CaPhe.KHACHHANG);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

    }
}
