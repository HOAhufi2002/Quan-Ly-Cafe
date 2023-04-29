using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_CaPhe.GUI
{
    public partial class frm_NhanVien : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        int pq;
        public frm_NhanVien(int i)
        {
            InitializeComponent();
            pq = i;
        }
        void phanquyen()
        {
            if(pq == 1)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }
        private void btn_themPN_Click(object sender, EventArgs e)
        {
            Frm_ThemNV frm = new Frm_ThemNV();
            frm.Show();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'qL_CaPhe1.NHANVIEN' table. You can move, or remove it, as needed.


            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);
            labeltongnv.Text = (dgv_nhanvien.RowCount - 1).ToString();

        }

        private void btn_SearchEmployee_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from nhanvien where hoten=N'" + txtnamesearch.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            con.Close();
            dgv_nhanvien.DataSource = table;
        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(this.Validate())
            {
                nHANVIENBindingSource.EndEdit();
                nHANVIENTableAdapter.Update(qL_CaPhe.NHANVIEN);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {    
            MessageBox.Show("Tải lại thành công");
            this.nHANVIENTableAdapter.Fill(qL_CaPhe.NHANVIEN);
           
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TaiKhoan fk = new frm_TaiKhoan();
            fk.Show();
        }
    }
}
