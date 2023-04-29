using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CaPhe.BLL;
using QL_CaPhe.DTO;
using Xceed.Words.NET;
using System.Diagnostics;

namespace QL_CaPhe.GUI
{
    public partial class frmGoiMon : Form
    {
        LoaiMonBLL lm;
        GoiMon gm;
        BanBLL ban;
        NhanVien nv;
        public frmGoiMon()
        {

            lm = new LoaiMonBLL();
            gm = new GoiMon();
            ban = new BanBLL();
            InitializeComponent();
        }
        public frmGoiMon(NhanVien nv)
        {

            lm = new LoaiMonBLL();
            gm = new GoiMon();
            ban = new BanBLL();
            this.nv = nv;
            InitializeComponent();
        }
        void taoban()
        {
            int sl = ban.soluongban();
            int x = 25;
            int y = 40;
            int dem = sl / 3;
            int du = sl % 3;
            int soban = 1;
            for (int i = 0; i < dem; i++)
            {
                if (soban > 1)
                {
                    x += 120;
                }
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Enabled = true;
                    btn.Name = "B0" + soban;
                    string name = "Bàn " + soban;
                    btn.Text = name;
                    btn.Width = 100;
                    btn.Height = 100;
                    Point a = new Point(x, y);
                    btn.Location = a;
                    if (y <= (55 + (150 * (dem - 2))))
                        y += 150;
                    else
                        y = 40;
                    soban++;
                    btn.Click += new EventHandler(btn_Ban_click);
                    this.panel_Ban.Controls.Add(btn);

                }
            }
        }
        string maban, mahd;
        private void btn_Ban_click(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            maban = t.Name;
            panel_chon.Enabled = true;
            panel_goimon.Enabled = true;
            panel_Ban.Enabled = false;
            if (gm.hd.FirstOrDefault(r => r.MaBan == maban) != null)
            {
                lbl_tongtien.Text = "0";
                mahd = gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD;
                tinhsthanhtien(mahd);
                dgv_Order.DataSource = null;
                dgv_Order.DataSource = gm.cthd.Where(r => r.MaHD == mahd).ToList();
            }
            else
            {
                lbl_tongtien.Text = "0";
                HoaDon a = new HoaDon();
                a.MaHD = random();
                mahd = a.MaHD;
                a.MaBan = maban;
                gm.hd.Add(a);
                dgv_Order.DataSource = gm.cthd.Where(r => r.MaHD == a.MaHD).ToList();
            }

        }
        void taobuttonloai()
        {
            List<LoaiMon> l = lm.Getdata();
            int sl = lm.soluongLoaiMon();
            int x = 10;
            int y = 5;
            int dem = sl / 4;
            if (dem == 0)
                dem++;
            int soban = 0;
            int x1 = x;
            for (int j = 0; j < sl; j++)
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.Enabled = true;
                btn.Name = l[soban].Maloai;
                btn.Text = l[soban].TenLoai;
                btn.Width = 120;
                btn.Height = 50;
                Point a = new Point(x, y);
                btn.Location = a;
                if (x <= (x1 + (150 * sl)))
                    x += 150;
                else
                    x = 20;
                soban++;
                btn.Click += new EventHandler(btn_click);
                this.panel_goimon.Controls.Add(btn);
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            // TODO: This line of code loads data into the 'qL_CaPhe.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.FillBy_MaLoai_TrangThai(this.qL_CaPhe.MON, t.Name);


        }
        void khoitao()
        {
            panel_chon.Enabled = false;
            panel_goimon.Enabled = false;
            panel_Ban.Enabled = true;
            taobuttonloai();
            taoban();
        }
        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            khoitao();
            lbl_tongtien.Text = "0";
            //lbl_thungan.Text = nv.HoTen;
        }
        void tinhsthanhtien(string mahd)
        {
            gm.hd.FirstOrDefault(t => t.MaHD == mahd).ThanhTien = gm.cthd.Where(x => x.MaHD == gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD).ToList().Sum(t => t.ThanhTien);
        }
        private void dgv_DsMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                gm.hd.FirstOrDefault(t => t.MaBan == maban).NgayThanhLap = DateTime.Today;
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.MaHD = mahd;
                ct.MaMon = dgv_DsMon[0, e.RowIndex].Value.ToString();
                ct.SoLuong = 1;
                ct.ThanhTien = ct.SoLuong * int.Parse(dgv_DsMon[2, e.RowIndex].Value.ToString());
                ChiTietHoaDon a = gm.cthd.FirstOrDefault(r => r.MaMon == ct.MaMon && r.MaHD == mahd);
                if (a == null)
                    gm.cthd.Add(ct);
                else
                    gm.cthd.FirstOrDefault(r => r.MaMon == ct.MaMon && r.MaHD == gm.hd.FirstOrDefault(t => t.MaBan == maban).MaHD).SoLuong += 1;
                gm.cthd.FirstOrDefault(r => r.MaMon == ct.MaMon && r.MaHD == mahd).ThanhTien = gm.cthd.FirstOrDefault(r => r.MaMon == ct.MaMon && r.MaHD == mahd).SoLuong * int.Parse(dgv_DsMon[2, e.RowIndex].Value.ToString());
                tinhsthanhtien(ct.MaHD);
                dgv_Order.DataSource = null;
                dgv_Order.DataSource = gm.cthd.Where(t => t.MaHD == gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD).ToList();
                lbl_tongtien.Text = gm.cthd.Where(x => x.MaHD == gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD).ToList().Sum(t => t.ThanhTien).ToString("##,##");
                tinhsthanhtien(mahd);
                tinhtiensaugiam(0);
            }
            catch
            {
                MessageBox.Show("Lỗi 9182:");
            }
         

        }
        string random()
        {
            Random a = new Random();
            string ma = "HD";
            for (int i = 0; i < 3; i++)
            {
                ma += a.Next(1, 99).ToString();
            }
            return ma;
        }

        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            gm.cthd.RemoveAll(t => t.MaHD == gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD);
            lbl_tongtien.Text = "0";
            dgv_Order.DataSource = null;
            dgv_Order.DataSource = gm.cthd;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(dgv_Order[2, dong].Value.ToString()) > 0 && gm.cthd.Where(t => t.MaHD == mahd).ToList().Count > 0)
                {


                    gm.cthd.FirstOrDefault(r => r.MaMon == dgv_Order[0, dong].Value.ToString() && r.MaHD == mahd).SoLuong -= 1;
                    for (int i = 0; i < dgv_DsMon.RowCount; i++)
                    {
                        if (dgv_Order[0, dong].Value.ToString() == dgv_DsMon[0, i].Value.ToString())
                            gm.cthd.FirstOrDefault(r => r.MaMon == dgv_Order[0, dong].Value.ToString() && r.MaHD == mahd).ThanhTien = gm.cthd.FirstOrDefault(r => r.MaMon == dgv_Order[0, dong].Value.ToString() && r.MaHD == mahd).SoLuong * int.Parse(dgv_DsMon[2, dong].Value.ToString());

                    }
                    lbl_tongtien.Text = gm.cthd.Where(x => x.MaHD == gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD).ToList().Sum(t => t.ThanhTien).ToString("##,##");


                }
                else
                {

                    gm.cthd.RemoveAll(t => t.MaMon == dgv_Order[0, dong].Value.ToString() && t.MaHD == mahd);
                    if (gm.cthd.Where(t => t.MaHD == mahd).ToList().Count == 0)
                        lbl_tongtien.Text = "0";
                }
                dgv_Order.DataSource = null;
                dgv_Order.DataSource = gm.cthd.Where(r => r.MaHD == mahd).ToList();


            }
            catch
            {
                return;
            }
        }
        int dong = 0;
        private void dgv_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dgv_Order_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gm.cthd.FirstOrDefault(r => r.MaMon == dgv_Order[0, e.RowIndex].Value.ToString()).SoLuong = int.Parse(dgv_Order[2, e.RowIndex].Value.ToString());
            for (int i = 0; i < dgv_DsMon.RowCount; i++)
            {
                if (dgv_Order[0, e.RowIndex].Value.ToString() == dgv_DsMon[0, i].Value.ToString())
                    gm.cthd.FirstOrDefault(r => r.MaMon == dgv_Order[0, e.RowIndex].Value.ToString()).ThanhTien = gm.cthd.FirstOrDefault(r => r.MaMon == dgv_Order[0, e.RowIndex].Value.ToString()).SoLuong * int.Parse(dgv_DsMon[2, e.RowIndex].Value.ToString());
            }
            dgv_Order.DataSource = null;
            dgv_Order.DataSource = gm.cthd;
        }

        private void btn_ThoatHD_Click(object sender, EventArgs e)
        {
            khoitao();

        }
        void tinhtiensaugiam(double i )
        {
            double tongtien= double.Parse(lbl_tongtien.Text);
            double giamgia = (tongtien * i);
            gm.hd.FirstOrDefault(t => t.MaHD == mahd).MaGiam = decimal.Parse(giamgia.ToString());
            lbl_Giamgia.Text = giamgia.ToString("##,##");
            double tongtienfinal = (tongtien - giamgia);
            gm.hd.FirstOrDefault(t => t.MaHD == mahd).ThanhTien = decimal.Parse(tongtienfinal.ToString());
            lbl_Tongtienfinal.Text = tongtienfinal.ToString("##,##");
        }
        private void btn_NhapKH_Click(object sender, EventArgs e)
        {
            frmNhapTTKH frm = new frmNhapTTKH();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            gm.kh = frm.khachhangorder();
            gm.hd.FirstOrDefault(t => t.MaHD == mahd).MaKH = gm.kh.MaKH;
            lbl_khachHang.Text = gm.kh.TenKH;
            if(gm.kh.DiemTichLuy>10)
            {
                tinhtiensaugiam(0.1);
             
            }
            else
            {
                if(gm.kh.DiemTichLuy>20)
                {
                    tinhtiensaugiam(0.15);
                }
                else
                {
                    if (gm.kh.DiemTichLuy > 30)
                    {
                        tinhtiensaugiam(0.2);
                    }
                    else
                    {
                        tinhtiensaugiam(0);
                    }
                }
                    

            }
        }

        private void dgv_Order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbl_tongtien.Text = gm.cthd.Where(x => x.MaHD == gm.hd.FirstOrDefault(r => r.MaBan == maban).MaHD).ToList().Sum(t => t.ThanhTien).ToString("##,##");
        }
       
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
           
           
            try
            {
                int dem = 10;
                HoaDonBLL hdbll = new HoaDonBLL();
                ChiTietHoaDonBLL cthdbll = new ChiTietHoaDonBLL();
                if(hdbll.Insert(gm.hd.FirstOrDefault(t=>t.MaHD == mahd)))
                {
                    foreach (var item in gm.cthd)
                    {
                        if (cthdbll.Insert(item))
                            dem = 0;
                    }
                    if( dem==0)
                    MessageBox.Show("Thanh toán thành công", "Thông Báo");
                }
               
             

            }
            catch
            {
                MessageBox.Show("Thanh toán thất bại","Thông Báo");
            }
         

        }

        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Ban frm = new frm_Ban();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật");
            }
        }

        private void frmGoiMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(r== DialogResult.No)
            {
                e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                //#region one
                //string fileName = "exempleWord.docx";
                //var doc = DocX.Create(fileName);
                //doc.InsertParagraph("QUẢN LÝ QUÁN CÀ PHÊ");
                //#endregion


                //string title = "Hoá đơn bán hàng";
                //string dc = "140 Lê Trọng Tấn , Quận Tân Phú , Thành Phố Hồ Chí Minh";
                //string tennv = lbl_thungan.Text;
                //string x = "Mã Món=============Số Lượng============Thành Tiền======================";
                //doc.InsertParagraph(title);
                //doc.InsertParagraph("Địa chỉ: " + dc);
                //doc.InsertParagraph("Nhân viên: " + tennv);
                //doc.InsertParagraph(x);

                //for (int i = 0; i < dgv_Order.RowCount ; i++)
                //{
                //    string a = dgv_Order.Rows[i].Cells[0].Value.ToString();
                //    string b = dgv_Order.Rows[i].Cells[2].Value.ToString();
                //    string c = dgv_Order.Rows[i].Cells[3].Value.ToString();
                //    string row = a + "\t" + "\t" + "\t" + b + "\t" + "\t" + "\t" + c;
                //    doc.InsertParagraph(row);
                //}
         
                //string y = "===================================================================";
                //doc.InsertParagraph(y);
                //string kh = lbl_khachHang.Text.ToString();
                //doc.InsertParagraph("Tên Khách Hàng: " + kh);
                //string khach = lbl_tongtien.Text.ToString();
                //doc.InsertParagraph("Thành Tiền: " + khach);
                //string tong = lbl_Giamgia.Text.ToString();
                //doc.InsertParagraph("Giảm Giá :" + tong); 
                //string du = lbl_Tongtienfinal.Text.ToString();
                //doc.InsertParagraph("Tổng Tiền Phải Trả sau khuyến mãi :" + du);
                //#region part of one
                //doc.Save();
                //Process.Start("WINWORD.EXE", fileName);
                //#endregion
            InHoaDon frm = new InHoaDon(mahd);
            frm.ShowDialog();
        }
    }
}
