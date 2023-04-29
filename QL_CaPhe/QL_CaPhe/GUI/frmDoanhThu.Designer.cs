namespace QL_CaPhe.GUI
{
    partial class frmDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.label99 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_XemBieuDo = new System.Windows.Forms.Button();
            this.btn_Tính = new System.Windows.Forms.Button();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.rdo_Thang = new System.Windows.Forms.RadioButton();
            this.rdo_Ngay = new System.Windows.Forms.RadioButton();
            this.lbl_TongTienThuVao = new System.Windows.Forms.Label();
            this.lbl_TongTienChi = new System.Windows.Forms.Label();
            this.lbl_ChiPhiSuCo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_SuCo = new System.Windows.Forms.DataGridView();
            this.tenBienBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUCOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.dgv_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_LoiNhuan = new System.Windows.Forms.Label();
            this.dtp_Ngay_KT = new System.Windows.Forms.DateTimePicker();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuCo_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Ve_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchSựCốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nGUYENLIEUTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NGUYENLIEUTableAdapter();
            this.sUCOTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.SUCOTableAdapter();
            this.hOADONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.HOADONTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUCOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuCo_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label99.Location = new System.Drawing.Point(320, 577);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(0, 18);
            this.label99.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.btn_XemBieuDo);
            this.groupBox1.Controls.Add(this.btn_Tính);
            this.groupBox1.Controls.Add(this.cbo_thang);
            this.groupBox1.Controls.Add(this.rdo_Thang);
            this.groupBox1.Controls.Add(this.rdo_Ngay);
            this.groupBox1.Controls.Add(this.lbl_TongTienThuVao);
            this.groupBox1.Controls.Add(this.lbl_TongTienChi);
            this.groupBox1.Controls.Add(this.lbl_ChiPhiSuCo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv_SuCo);
            this.groupBox1.Controls.Add(this.dgv_NguyenLieu);
            this.groupBox1.Controls.Add(this.dgv_HoaDon);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtp_Ngay_KT);
            this.groupBox1.Controls.Add(this.dtp_Ngay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 682);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản doanh thu";
            // 
            // btn_tim
            // 
            this.btn_tim.Enabled = false;
            this.btn_tim.Location = new System.Drawing.Point(584, 23);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(87, 30);
            this.btn_tim.TabIndex = 86;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_XemBieuDo
            // 
            this.btn_XemBieuDo.Location = new System.Drawing.Point(1128, 541);
            this.btn_XemBieuDo.Name = "btn_XemBieuDo";
            this.btn_XemBieuDo.Size = new System.Drawing.Size(137, 35);
            this.btn_XemBieuDo.TabIndex = 85;
            this.btn_XemBieuDo.Text = "Xem biểu đồ";
            this.btn_XemBieuDo.UseVisualStyleBackColor = true;
            this.btn_XemBieuDo.Click += new System.EventHandler(this.btn_XemBieuDo_Click);
            // 
            // btn_Tính
            // 
            this.btn_Tính.Location = new System.Drawing.Point(967, 541);
            this.btn_Tính.Name = "btn_Tính";
            this.btn_Tính.Size = new System.Drawing.Size(75, 35);
            this.btn_Tính.TabIndex = 85;
            this.btn_Tính.Text = "Tính";
            this.btn_Tính.UseVisualStyleBackColor = true;
            this.btn_Tính.Click += new System.EventHandler(this.btn_Tính_Click);
            // 
            // cbo_thang
            // 
            this.cbo_thang.Enabled = false;
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_thang.Location = new System.Drawing.Point(107, 23);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(121, 26);
            this.cbo_thang.TabIndex = 83;
            this.cbo_thang.SelectedIndexChanged += new System.EventHandler(this.cbo_thang_SelectedIndexChanged);
            // 
            // rdo_Thang
            // 
            this.rdo_Thang.AutoSize = true;
            this.rdo_Thang.Location = new System.Drawing.Point(17, 25);
            this.rdo_Thang.Name = "rdo_Thang";
            this.rdo_Thang.Size = new System.Drawing.Size(70, 22);
            this.rdo_Thang.TabIndex = 82;
            this.rdo_Thang.TabStop = true;
            this.rdo_Thang.Text = "Tháng";
            this.rdo_Thang.UseVisualStyleBackColor = true;
            this.rdo_Thang.CheckedChanged += new System.EventHandler(this.rdo_Thang_CheckedChanged);
            // 
            // rdo_Ngay
            // 
            this.rdo_Ngay.AutoSize = true;
            this.rdo_Ngay.Location = new System.Drawing.Point(991, 24);
            this.rdo_Ngay.Name = "rdo_Ngay";
            this.rdo_Ngay.Size = new System.Drawing.Size(63, 22);
            this.rdo_Ngay.TabIndex = 82;
            this.rdo_Ngay.TabStop = true;
            this.rdo_Ngay.Text = "Ngày";
            this.rdo_Ngay.UseVisualStyleBackColor = true;
            this.rdo_Ngay.CheckedChanged += new System.EventHandler(this.rdo_Ngay_CheckedChanged);
            // 
            // lbl_TongTienThuVao
            // 
            this.lbl_TongTienThuVao.AutoSize = true;
            this.lbl_TongTienThuVao.Location = new System.Drawing.Point(1125, 369);
            this.lbl_TongTienThuVao.Name = "lbl_TongTienThuVao";
            this.lbl_TongTienThuVao.Size = new System.Drawing.Size(24, 18);
            this.lbl_TongTienThuVao.TabIndex = 74;
            this.lbl_TongTienThuVao.Text = "__";
            // 
            // lbl_TongTienChi
            // 
            this.lbl_TongTienChi.AutoSize = true;
            this.lbl_TongTienChi.Location = new System.Drawing.Point(1125, 402);
            this.lbl_TongTienChi.Name = "lbl_TongTienChi";
            this.lbl_TongTienChi.Size = new System.Drawing.Size(24, 18);
            this.lbl_TongTienChi.TabIndex = 74;
            this.lbl_TongTienChi.Text = "__";
            // 
            // lbl_ChiPhiSuCo
            // 
            this.lbl_ChiPhiSuCo.AutoSize = true;
            this.lbl_ChiPhiSuCo.Location = new System.Drawing.Point(1125, 435);
            this.lbl_ChiPhiSuCo.Name = "lbl_ChiPhiSuCo";
            this.lbl_ChiPhiSuCo.Size = new System.Drawing.Size(24, 18);
            this.lbl_ChiPhiSuCo.TabIndex = 74;
            this.lbl_ChiPhiSuCo.Text = "__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tổng tiền thu vào:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tổng số chi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(984, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Chi phí sự cố";
            // 
            // dgv_SuCo
            // 
            this.dgv_SuCo.AllowUserToAddRows = false;
            this.dgv_SuCo.AllowUserToDeleteRows = false;
            this.dgv_SuCo.AutoGenerateColumns = false;
            this.dgv_SuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenBienBanDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.chiPhiDataGridViewTextBoxColumn});
            this.dgv_SuCo.DataSource = this.sUCOBindingSource;
            this.dgv_SuCo.Location = new System.Drawing.Point(730, 69);
            this.dgv_SuCo.Name = "dgv_SuCo";
            this.dgv_SuCo.ReadOnly = true;
            this.dgv_SuCo.RowTemplate.Height = 24;
            this.dgv_SuCo.Size = new System.Drawing.Size(604, 277);
            this.dgv_SuCo.TabIndex = 81;
            this.dgv_SuCo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuCo_CellContentClick);
            // 
            // tenBienBanDataGridViewTextBoxColumn
            // 
            this.tenBienBanDataGridViewTextBoxColumn.DataPropertyName = "TenBienBan";
            this.tenBienBanDataGridViewTextBoxColumn.HeaderText = "Tên Biên bản";
            this.tenBienBanDataGridViewTextBoxColumn.Name = "tenBienBanDataGridViewTextBoxColumn";
            this.tenBienBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiPhiDataGridViewTextBoxColumn
            // 
            this.chiPhiDataGridViewTextBoxColumn.DataPropertyName = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.HeaderText = "Chi phí";
            this.chiPhiDataGridViewTextBoxColumn.Name = "chiPhiDataGridViewTextBoxColumn";
            this.chiPhiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUCOBindingSource
            // 
            this.sUCOBindingSource.DataMember = "SUCO";
            this.sUCOBindingSource.DataSource = this.qL_CaPhe;
            // 
            // qL_CaPhe
            // 
            this.qL_CaPhe.DataSetName = "QL_CaPhe";
            this.qL_CaPhe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_NguyenLieu
            // 
            this.dgv_NguyenLieu.AllowUserToAddRows = false;
            this.dgv_NguyenLieu.AllowUserToDeleteRows = false;
            this.dgv_NguyenLieu.AutoGenerateColumns = false;
            this.dgv_NguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.ThanhTien});
            this.dgv_NguyenLieu.DataSource = this.nGUYENLIEUBindingSource;
            this.dgv_NguyenLieu.Location = new System.Drawing.Point(13, 69);
            this.dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            this.dgv_NguyenLieu.ReadOnly = true;
            this.dgv_NguyenLieu.RowTemplate.Height = 24;
            this.dgv_NguyenLieu.Size = new System.Drawing.Size(692, 277);
            this.dgv_NguyenLieu.TabIndex = 81;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "Mã hàng";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            this.maHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // nGUYENLIEUBindingSource
            // 
            this.nGUYENLIEUBindingSource.DataMember = "NGUYENLIEU";
            this.nGUYENLIEUBindingSource.DataSource = this.qL_CaPhe;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AllowUserToAddRows = false;
            this.dgv_HoaDon.AllowUserToDeleteRows = false;
            this.dgv_HoaDon.AutoGenerateColumns = false;
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.ngayLapHDDataGridViewTextBoxColumn,
            this.maBanDataGridViewTextBoxColumn,
            this.giamGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dgv_HoaDon.DataSource = this.hOADONBindingSource;
            this.dgv_HoaDon.Location = new System.Drawing.Point(13, 369);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(915, 297);
            this.dgv_HoaDon.TabIndex = 80;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLapHDDataGridViewTextBoxColumn
            // 
            this.ngayLapHDDataGridViewTextBoxColumn.DataPropertyName = "NgayLapHD";
            this.ngayLapHDDataGridViewTextBoxColumn.HeaderText = "Ngày lập hóa đơn";
            this.ngayLapHDDataGridViewTextBoxColumn.Name = "ngayLapHDDataGridViewTextBoxColumn";
            this.ngayLapHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maBanDataGridViewTextBoxColumn
            // 
            this.maBanDataGridViewTextBoxColumn.DataPropertyName = "MaBan";
            this.maBanDataGridViewTextBoxColumn.HeaderText = "Mã bàn";
            this.maBanDataGridViewTextBoxColumn.Name = "maBanDataGridViewTextBoxColumn";
            this.maBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giamGiaDataGridViewTextBoxColumn
            // 
            this.giamGiaDataGridViewTextBoxColumn.DataPropertyName = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giamGiaDataGridViewTextBoxColumn.Name = "giamGiaDataGridViewTextBoxColumn";
            this.giamGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qL_CaPhe;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_LoiNhuan);
            this.groupBox2.Location = new System.Drawing.Point(951, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 56);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lợi nhận";
            // 
            // lbl_LoiNhuan
            // 
            this.lbl_LoiNhuan.AutoSize = true;
            this.lbl_LoiNhuan.Location = new System.Drawing.Point(21, 25);
            this.lbl_LoiNhuan.Name = "lbl_LoiNhuan";
            this.lbl_LoiNhuan.Size = new System.Drawing.Size(24, 18);
            this.lbl_LoiNhuan.TabIndex = 74;
            this.lbl_LoiNhuan.Text = "__";
            // 
            // dtp_Ngay_KT
            // 
            this.dtp_Ngay_KT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_Ngay_KT.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dtp_Ngay_KT.Enabled = false;
            this.dtp_Ngay_KT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_Ngay_KT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Ngay_KT.Location = new System.Drawing.Point(721, 25);
            this.dtp_Ngay_KT.Name = "dtp_Ngay_KT";
            this.dtp_Ngay_KT.Size = new System.Drawing.Size(243, 24);
            this.dtp_Ngay_KT.TabIndex = 75;
            this.dtp_Ngay_KT.Value = new System.DateTime(2022, 11, 19, 22, 36, 20, 0);
            this.dtp_Ngay_KT.ValueChanged += new System.EventHandler(this.dtp_Ngay_ValueChanged);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_Ngay.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dtp_Ngay.Enabled = false;
            this.dtp_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Ngay.Location = new System.Drawing.Point(265, 25);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(243, 24);
            this.dtp_Ngay.TabIndex = 75;
            this.dtp_Ngay.Value = new System.DateTime(2022, 11, 19, 22, 36, 20, 0);
            this.dtp_Ngay.ValueChanged += new System.EventHandler(this.dtp_Ngay_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(964, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 74;
            // 
            // SuCo_menuStrip
            // 
            this.SuCo_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.SuCo_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SuCo_menuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SuCo_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.SuCo_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SuCo_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ve_toolStripMenuItem,
            this.In_toolStripMenuItem,
            this.Tai_toolStripMenuItem,
            this.TimKiem_toolStripMenuItem,
            this.Text_toolStripTextBox});
            this.SuCo_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.SuCo_menuStrip.Name = "SuCo_menuStrip";
            this.SuCo_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SuCo_menuStrip.Size = new System.Drawing.Size(1405, 28);
            this.SuCo_menuStrip.TabIndex = 77;
            this.SuCo_menuStrip.Text = "MenuMon";
            // 
            // Ve_toolStripMenuItem
            // 
            this.Ve_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ve_toolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ve_toolStripMenuItem.ForeColor = System.Drawing.Color.Transparent;
            this.Ve_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.left_arrow_symbol_in_a_circle1;
            this.Ve_toolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Ve_toolStripMenuItem.Name = "Ve_toolStripMenuItem";
            this.Ve_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Ve_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.Ve_toolStripMenuItem.Click += new System.EventHandler(this.Ve_toolStripMenuItem_Click);
            // 
            // In_toolStripMenuItem
            // 
            this.In_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.In_toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtDanhSáchSựCốToolStripMenuItem,
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem,
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem,
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem});
            this.In_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.printing1;
            this.In_toolStripMenuItem.Name = "In_toolStripMenuItem";
            this.In_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.In_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.In_toolStripMenuItem.Click += new System.EventHandler(this.In_toolStripMenuItem_Click);
            // 
            // xuấtDanhSáchSựCốToolStripMenuItem
            // 
            this.xuấtDanhSáchSựCốToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchSựCốToolStripMenuItem.Name = "xuấtDanhSáchSựCốToolStripMenuItem";
            this.xuấtDanhSáchSựCốToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchSựCốToolStripMenuItem.Text = "Xuất danh sách sự cố";
            // 
            // xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem
            // 
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Name = "xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem";
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Text = "Xuất danh sách chi phí ít nhất";
            // 
            // xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem
            // 
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Name = "xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem";
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Text = "Xuất danh sách chi phí nhiều nhất";
            // 
            // xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem
            // 
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Name = "xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem";
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Text = "Xuất danh sách sự cố theo thời gian";
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.sync;
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // TimKiem_toolStripMenuItem
            // 
            this.TimKiem_toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TimKiem_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.Search;
            this.TimKiem_toolStripMenuItem.Name = "TimKiem_toolStripMenuItem";
            this.TimKiem_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.TimKiem_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            // 
            // Text_toolStripTextBox
            // 
            this.Text_toolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Text_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_toolStripTextBox.Name = "Text_toolStripTextBox";
            this.Text_toolStripTextBox.Size = new System.Drawing.Size(130, 24);
            // 
            // nGUYENLIEUTableAdapter
            // 
            this.nGUYENLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // sUCOTableAdapter
            // 
            this.sUCOTableAdapter.ClearBeforeFill = true;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1405, 739);
            this.Controls.Add(this.SuCo_menuStrip);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoanhThu";
            this.Text = "Doanh thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUCOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SuCo_menuStrip.ResumeLayout(false);
            this.SuCo_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Tính;
        private System.Windows.Forms.ComboBox cbo_thang;
        private System.Windows.Forms.RadioButton rdo_Thang;
        private System.Windows.Forms.RadioButton rdo_Ngay;
        private System.Windows.Forms.Label lbl_TongTienThuVao;
        private System.Windows.Forms.Label lbl_TongTienChi;
        private System.Windows.Forms.Label lbl_ChiPhiSuCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_SuCo;
        private System.Windows.Forms.DataGridView dgv_NguyenLieu;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_LoiNhuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip SuCo_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Ve_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchSựCốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource nGUYENLIEUBindingSource;
        private DAL.QL_CaPheTableAdapters.NGUYENLIEUTableAdapter nGUYENLIEUTableAdapter;
        private System.Windows.Forms.BindingSource sUCOBindingSource;
        private DAL.QL_CaPheTableAdapters.SUCOTableAdapter sUCOTableAdapter;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DAL.QL_CaPheTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBienBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_XemBieuDo;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.DateTimePicker dtp_Ngay_KT;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;

    }
}