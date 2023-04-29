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
    public partial class frmXemBieuDo : Form
    {
        public frmXemBieuDo()
        {
            InitializeComponent();
        }
        public frmXemBieuDo(int thuvao, int chi, int suco)
        {
            InitializeComponent();
            this.thuvao = thuvao;
            this.chi = chi;
            this.suco = suco;
        }
        int thuvao, chi, suco;
        private void frmXemBieuDo_Load(object sender, EventArgs e)
        {
            chart1.Series["DoanhThu"].Points.Clear();
            chart1.Series["DoanhThu"].Points.Add((double)thuvao);
            chart1.Series["DoanhThu"].Points[0].Label = "Thu vào";
            chart1.Series["DoanhThu"].Points.Add((double)chi);
            chart1.Series["DoanhThu"].Points[1].Label = "Chi";
            chart1.Series["DoanhThu"].Points.Add((double)suco);
            chart1.Series["DoanhThu"].Points[2].Label = "Sự cố";
        }

        private void frmXemBieuDo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
