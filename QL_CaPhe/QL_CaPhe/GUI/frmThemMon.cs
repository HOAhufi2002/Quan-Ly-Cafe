using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CaPhe.DTO;
using QL_CaPhe.BLL;

namespace QL_CaPhe.GUI
{
    public partial class frmThemMon : Form
    {
        public frmThemMon()
        {
            InitializeComponent();
        }
        MonBLL mon = new MonBLL();
        private void frmThemMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.LOAIMON' table. You can move, or remove it, as needed.
            this.lOAIMONTableAdapter.Fill(this.qL_CaPhe.LOAIMON);
        }
        Mon ganDuLieu()
        {
            Mon a = new Mon();
            a.MaMon = txt_Category_DrinkFood.Text;
            a.TenMon = txt_Name_DrinkFood.Text;
            if (rdo_Con_DrinkFood.Checked)
                a.TrangThai = true;
            else
                a.TrangThai = false;
            a.Gia = int.Parse(txt_Cash_DrinkFood.Text);
            a.Maloai = cbo_Category.SelectedValue.ToString();
            return a;
        }

        private void ptb_AddAccount_Click(object sender, EventArgs e)
        {
            Mon a = ganDuLieu();
            bool kq = mon.Insert(a);
            if(kq)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Mã đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

        private void txt_Cash_DrinkFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ptb_RemoveAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            this.Hide();
            this.Owner.Show();
        }
    }
}
