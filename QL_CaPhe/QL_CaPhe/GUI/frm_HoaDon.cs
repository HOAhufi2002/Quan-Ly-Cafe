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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }
        HoaDonBLL hd = new HoaDonBLL();

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_CaPhe.CHITIETHOADON' table. You can move, or remove it, as needed.
            this.cHITIETHOADONTableAdapter.Fill(this.qL_CaPhe.CHITIETHOADON);
            // TODO: This line of code loads data into the 'qL_CaPhe.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qL_CaPhe.HOADON);
            txt_Total_Bill.Text = hOADONTableAdapter.TongHoaDon().ToString();
            txt_Total_FoodDrink_Bill.Text = hOADONTableAdapter.TongThanhTien().ToString();
        }

        private void Luu_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.hOADONBindingSource.EndEdit();
                this.hOADONTableAdapter.Update(qL_CaPhe.HOADON);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = cHITIETHOADONTableAdapter.GetDataBy(txt_Inf_CategoryBill.Text);
        }
    }
}
