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
using QL_CaPhe.DAL;
namespace QL_CaPhe.GUI
{
    public partial class frm_ThemTK : Form
    {
        public frm_ThemTK()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            DAL.TaiKhoanDAL dl = new DAL.TaiKhoanDAL();
            con.Open();
            dl.Insert(txt_account.Text, txt_pwd.Text);
           
            con.Close();
        }
    }
}
