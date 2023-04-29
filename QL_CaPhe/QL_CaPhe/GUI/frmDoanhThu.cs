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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void dgv_SuCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            rdo_Thang.Checked = true;
            cbo_thang.Text = DateTime.Today.Month.ToString();
            nGUYENLIEUTableAdapter.FillBy_thanhtien_thang(qL_CaPhe.NGUYENLIEU, DateTime.Today.Year, DateTime.Today.Month);
            sUCOTableAdapter.FillBy_ThanhTien_Thang(qL_CaPhe.SUCO, DateTime.Today.Year, DateTime.Today.Month);
            hOADONTableAdapter.FillBy_ThanhTien_HD(qL_CaPhe.HOADON, DateTime.Today.Year, DateTime.Today.Month);

        }

        private void cbo_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
           nGUYENLIEUTableAdapter.FillBy_thanhtien_thang(qL_CaPhe.NGUYENLIEU, DateTime.Today.Year, int.Parse(cbo_thang.SelectedItem.ToString()));
           sUCOTableAdapter.FillBy_ThanhTien_Thang(qL_CaPhe.SUCO,DateTime.Today.Year, int.Parse(cbo_thang.SelectedItem.ToString()));
           hOADONTableAdapter.FillBy_ThanhTien_HD(qL_CaPhe.HOADON,DateTime.Today.Year, int.Parse(cbo_thang.SelectedItem.ToString()));
        }

        private void rdo_Thang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Thang.Checked)
                cbo_thang.Enabled = true;
        }

        private void dtp_Ngay_ValueChanged(object sender, EventArgs e)
        {

           // DateTime t = dtp_Ngay.Value;
           //nGUYENLIEUTableAdapter.FillBy_thanhtien_Ngay(qL_CaPhe.NGUYENLIEU,t.Year, t.Month, t.Day);
           // sUCOTableAdapter.FillBy_ThanhTien_Ngay(qL_CaPhe.SUCO,t.Year, t.Month, t.Day);
           //hOADONTableAdapter.FillBy_ThanhTien_ngay(qL_CaPhe.HOADON,t.Year, t.Month, t.Day);
        }

        private void rdo_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Ngay.Checked)
            {
                dtp_Ngay.Enabled = true;
                dtp_Ngay_KT.Enabled = true;
                cbo_thang.Enabled = false;
                btn_tim.Enabled = true;
            }
        }

        private void Ve_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
            int ColumnsCount = a.Columns.Count + 1;
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
            toExcel(this.hOADONTableAdapter.GetData());
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            nGUYENLIEUTableAdapter.FillBy_thanhtien_thang(qL_CaPhe.NGUYENLIEU, DateTime.Today.Year, DateTime.Today.Month);
            sUCOTableAdapter.FillBy_ThanhTien_Thang(qL_CaPhe.SUCO, DateTime.Today.Year, DateTime.Today.Month);
            hOADONTableAdapter.FillBy_ThanhTien_HD(qL_CaPhe.HOADON, DateTime.Today.Year, DateTime.Today.Month);
        }

        private void btn_Tính_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rdo_Ngay.Checked)
                {
                    MessageBox.Show("Bạn phải chọn ngày để tính");
                    return;
                }
                   
                tinhdoanhthu();
            }
            catch 
            {
                MessageBox.Show("Lỗi giá trị", "Cảnh báo");
            }

        }
        double thuvao = 0, chi = 0, suco = 0;
        void tinhdoanhthu()
        {
           
            DateTime t = dtp_Ngay.Value;
            //if (int.Parse(hOADONTableAdapter.ScalarQuery_ThanhTien_Ngay_HD(t.Day, t.Month, t.Year).ToString()) == null)
            //    thuvao =  0;
            //else
            //thuvao = int.Parse(hOADONTableAdapter.ScalarQuery_ThanhTien_Ngay_HD(t.Day, t.Month, t.Year).ToString());
            //chi = nGUYENLIEUTableAdapter.ScalarQuery_TongTien_Ngay(qL_CaPhe.NGUYENLIEU,t.Year, t.Month, t.Day);
            suco = sUCOTableAdapter.FillBy_ThanhTien_Ngay(qL_CaPhe.SUCO, t.Year, t.Month, t.Day);
            for (int i = 0; i < dgv_NguyenLieu.Rows.Count;i++ )
            {
                chi += double.Parse(dgv_NguyenLieu[3, i].Value.ToString());
            }
            for (int i = 0; i < this.dgv_SuCo.Rows.Count; i++)
            {
                suco += double.Parse(this.dgv_SuCo[2, i].Value.ToString());
            }
            for (int i = 0; i < this.dgv_HoaDon.Rows.Count; i++)
            {
                thuvao += double.Parse(this.dgv_HoaDon[4, i].Value.ToString());
            }
            lbl_TongTienChi.Text = String.Format("{0: #,##}", chi);
            lbl_TongTienThuVao.Text = String.Format("{0: #,##}", thuvao);
            lbl_ChiPhiSuCo.Text = String.Format("{0: #,##}",suco);
            int tt = (int)thuvao - (int)chi - (int)suco;
            lbl_LoiNhuan.Text = String.Format("{0: #,##}", tt);
        }
       
        private void btn_XemBieuDo_Click(object sender, EventArgs e)
        {
            DateTime t = dtp_Ngay.Value;
            tinhdoanhthu();
            frmXemBieuDo new_form = new frmXemBieuDo((int)thuvao, (int)chi, (int)suco);
            new_form.Show();
        }

        private void frmDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try{
                 this.nGUYENLIEUTableAdapter.FillByTheoKhoangTG_NguyenLieu(qL_CaPhe.NGUYENLIEU, dtp_Ngay.Value, dtp_Ngay_KT.Value);
                 this.hOADONTableAdapter.FillBy_TheoKhoangTG_HD(qL_CaPhe.HOADON, dtp_Ngay.Value, dtp_Ngay_KT.Value);
                 this.sUCOTableAdapter.FillBy_TheoKhoangTG_Suco(qL_CaPhe.SUCO, dtp_Ngay.Value, dtp_Ngay_KT.Value);
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật");
            }
           
        }

      

    }
}
