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
    public partial class frm_Ban : Form
    {
        public frm_Ban()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Ban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.qL_CaPhe.BAN);
         

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.bANBindingSource.EndEdit();
                this.bANTableAdapter.Update(qL_CaPhe.BAN);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
