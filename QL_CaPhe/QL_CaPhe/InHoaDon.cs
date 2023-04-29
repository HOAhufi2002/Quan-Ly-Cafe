using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        string mahd;
        public InHoaDon(string ma)
        {
            InitializeComponent();
            mahd = ma;
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_CaPheDataSet.ChiTietHD' table. You can move, or remove it, as needed.
            this.ChiTietHDTableAdapter.Fill(this.QL_CaPheDataSet.ChiTietHD,mahd);

            this.reportViewer1.RefreshReport();
        }

        private void InHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                e.Cancel = false;
            }
        }
    }
}
