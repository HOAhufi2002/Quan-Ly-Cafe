using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CaPhe.DAL;
using System.Data.SqlClient;

namespace QL_CaPhe.GUI
{
    public partial class Frm_ThemNV : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        public Frm_ThemNV()
        {
            InitializeComponent();
        }

        private void Frm_ThemNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_CaPhe.NHANVIEN);

        }
        DAL.NhanVienDAL dal = new DAL.NhanVienDAL();
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            con.Open();
            dal.insert(txt_CategoryEmployee.Text,txt_tendangnhaplogin.Text, txt_NameEmployee.Text, txtsex.Text, DateTime.Parse(txt_DOB.Text), txt_Phone.Text, cbb_Position);
            con.Close();
        }
    }
}
