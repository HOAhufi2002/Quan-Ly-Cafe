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
    public partial class frmMoncs : Form
    {
        public frmMoncs()
        {
            InitializeComponent();
        }
        MonBLL mon = new MonBLL();
        private void frmMoncs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_CaPhe.LOAIMON' table. You can move, or remove it, as needed.
            this.lOAIMONTableAdapter.Fill(this.qL_CaPhe.LOAIMON);
            // TODO: This line of code loads data into the 'qL_CaPhe.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Fill(qL_CaPhe.MON);
            rdo_Most_DrinkFood.Checked = false;
            thongke();
        }
        void thongke()
        {
            lbl_Con.Text = mon.SLCon().ToString();
            lbl_NgungBan.Text = mon.SLHet().ToString();
            lbl_TongMon.Text = mon.TongMon().ToString();
        }

        private void txt_Cash_DrinkFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        int i = 0;
        private void rdo_Most_DrinkFood_CheckedChanged(object sender, EventArgs e)
        {
            if(i==1)
            {
                if (rdo_Most_DrinkFood.Checked)
                    this.mONTableAdapter.FillBy1(qL_CaPhe.MON);
                if (!rdo_Most_DrinkFood.Checked)
                    this.mONTableAdapter.xuatSL_ItNhat(qL_CaPhe.MON);
                return;
            }
            i++;
           
        }
  
        private void Luu_toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                mONBindingSource.EndEdit();
                mONTableAdapter.Update(qL_CaPhe.MON);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void Ve_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mONTableAdapter.Fill(this.qL_CaPhe.MON);
            thongke();
            //dgv_Mon.DataSource = mONTableAdapter.GetData();
        }
        void toExcel(DataTable a, string excelFilePath = null)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            // Start Excel and get Application object.  
            excel = new Microsoft.Office.Interop.Excel.Application();
            // for making Excel visible  
            excel.Visible = false;
            excel.DisplayAlerts = false;
            // Creation a new Workbook  
            excelworkBook = excel.Workbooks.Add(Type.Missing);
            // Workk sheet  
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "Test work sheet";
            excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[a.Rows.Count + 1, a.Columns.Count]];
            excelCellrange.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;
            int ColumnsCount = a.Columns.Count;
            object[] Header = new object[ColumnsCount];

            // column headings               
            for (int i = 0; i < ColumnsCount; i++)
                Header[i] = a.Columns[i].ColumnName;

            Microsoft.Office.Interop.Excel.Range HeaderRange = excelSheet.get_Range((Microsoft.Office.Interop.Excel.Range)(excelSheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(excelSheet.Cells[1, ColumnsCount]));
            HeaderRange.Value = Header;
            HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            HeaderRange.Font.Bold = true;
            // rows
            for (var i = 0; i < a.Rows.Count; i++)
            {
                // to do: format datetime values before printing
                for (var j = 0; j < a.Columns.Count; j++)
                {
                    excelSheet.Cells[i + 2, j + 1] = a.Rows[i][j];
                }
            }
            if (!string.IsNullOrEmpty(excelFilePath))
            {
                try
                {
                    excelSheet.SaveAs(excelFilePath);
                    excel.Quit();
                    MessageBox.Show("Excel file saved!");
                }
                catch (Exception ex)
                {
                    throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                        + ex.Message);
                }
            }
            else
            { // no file path is given
                excel.Visible = true;
            }
        }
        private void In_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            toExcel(this.mONTableAdapter.GetData());
        }

        private void cbo_MaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_MaLoai.SelectedIndex>-1)
                this.mONTableAdapter.FillBy(qL_CaPhe.MON, cbo_MaLoai.SelectedValue.ToString());
            else
                this.mONTableAdapter.Fill(qL_CaPhe.MON);
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            frmThemMon a = new frmThemMon();
            a.Owner = this;
            a.ShowDialog();
        }

        private void TimKiem_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mONTableAdapter.FillBy_TimKiem(qL_CaPhe.MON, Text_toolStripTextBox.Text);
        }

        private void Text_toolStripTextBox_Enter(object sender, EventArgs e)
        {
            this.mONTableAdapter.FillBy_TimKiem(qL_CaPhe.MON, Text_toolStripTextBox.Text);
        }

        private void Text_toolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mONTableAdapter.FillBy_TimKiem(qL_CaPhe.MON, Text_toolStripTextBox.Text);
            }
        }

        private void frmMoncs_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        

    }
}
