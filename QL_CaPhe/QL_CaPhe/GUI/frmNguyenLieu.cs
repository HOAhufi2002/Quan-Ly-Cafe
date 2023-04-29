using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CaPhe.DTO;
using QL_CaPhe.BLL;
using DocumentFormat.OpenXml.Drawing;


namespace QL_CaPhe.GUI
{
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
        }
        int phanquyen;
        public frmNguyenLieu(int pq)
        {
            InitializeComponent();
            phanquyen = pq;
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            rdo_CanNhap.Checked = false;
            rdo_HetHan.Checked = false;
            // TODO: This line of code loads data into the 'qL_CaPhe.NGUYENLIEU' table. You can move, or remove it, as needed.
            this.nGUYENLIEUTableAdapter.Fill(this.qL_CaPhe.NGUYENLIEU);
            
            thongke();
         
        }
        void thongke()
        {
            lbl_Total_Material.Text = dgv_NguyenLieu.RowCount.ToString(); ;
            lbl_TotalCast_Material.Text = String.Format("{0: #,##}", int.Parse(this.nGUYENLIEUTableAdapter.TongChiPhi_NguyenLieu().ToString()));
        }
        private void btn_themPN_Click(object sender, EventArgs e)
        {
            frmNhapNguyenLieu a = new frmNhapNguyenLieu();
            a.Owner = this;
            this.Hide();
            a.Show();
        }

        private void Ve_toolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    frmAdmin a = new frmAdmin();
        //    a.Owner = this;
        //    this.Hide();
        //    a.Show();
            //nGUYENLIEUBindingSource
            //nGUYENLIEUTableAdapter
        }

        private void Luu_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                nGUYENLIEUBindingSource.EndEdit();
                nGUYENLIEUTableAdapter.Update(qL_CaPhe.NGUYENLIEU);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void In_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nGUYENLIEUTableAdapter.Fill(this.qL_CaPhe.NGUYENLIEU);
            thongke();
            rdo_CanNhap.Checked = false;
            rdo_HetHan.Checked = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                //this.nGUYENLIEUTableAdapter.FillBy(this.qL_CaPhe.NGUYENLIEU, comboBox2.SelectedValue.ToString());
        }

        private void rdo_CanNhap_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_CanNhap.Checked)
                this.nGUYENLIEUTableAdapter.FillBy_CanNhap(this.qL_CaPhe.NGUYENLIEU);
        }

        private void rdo_HetHan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_HetHan.Checked)
                this.nGUYENLIEUTableAdapter.FillBy_HetHan(this.qL_CaPhe.NGUYENLIEU);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TimKiem_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nGUYENLIEUTableAdapter.FillBy_TimKiem(qL_CaPhe.NGUYENLIEU, Text_toolStripTextBox.Text);
        }

    }
}
