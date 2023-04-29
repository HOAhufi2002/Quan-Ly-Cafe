namespace QL_CaPhe.GUI
{
    partial class frmNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguyenLieu));
            this.rdo_CanNhap = new System.Windows.Forms.RadioButton();
            this.lbl_TotalCast_Material = new System.Windows.Forms.Label();
            this.lbl_Total_Material = new System.Windows.Forms.Label();
            this.rdo_HetHan = new System.Windows.Forms.RadioButton();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.dgv_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_TaiLai = new System.Windows.Forms.ToolStripMenuItem();
            this.nGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuCo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NguyenLieu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Ve_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Luu_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SuCo_bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.nGUYENLIEUTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NGUYENLIEUTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themPN = new System.Windows.Forms.Button();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            this.NguyenLieu_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuCo_bindingNavigator)).BeginInit();
            this.SuCo_bindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdo_CanNhap
            // 
            this.rdo_CanNhap.AutoSize = true;
            this.rdo_CanNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_CanNhap.Location = new System.Drawing.Point(15, 33);
            this.rdo_CanNhap.Name = "rdo_CanNhap";
            this.rdo_CanNhap.Size = new System.Drawing.Size(170, 22);
            this.rdo_CanNhap.TabIndex = 75;
            this.rdo_CanNhap.TabStop = true;
            this.rdo_CanNhap.Text = "Những món cần nhập";
            this.rdo_CanNhap.UseVisualStyleBackColor = true;
            this.rdo_CanNhap.CheckedChanged += new System.EventHandler(this.rdo_CanNhap_CheckedChanged);
            // 
            // lbl_TotalCast_Material
            // 
            this.lbl_TotalCast_Material.AutoSize = true;
            this.lbl_TotalCast_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TotalCast_Material.Location = new System.Drawing.Point(1306, 350);
            this.lbl_TotalCast_Material.Name = "lbl_TotalCast_Material";
            this.lbl_TotalCast_Material.Size = new System.Drawing.Size(24, 18);
            this.lbl_TotalCast_Material.TabIndex = 77;
            this.lbl_TotalCast_Material.Text = "__";
            // 
            // lbl_Total_Material
            // 
            this.lbl_Total_Material.AutoSize = true;
            this.lbl_Total_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Total_Material.Location = new System.Drawing.Point(1319, 391);
            this.lbl_Total_Material.Name = "lbl_Total_Material";
            this.lbl_Total_Material.Size = new System.Drawing.Size(24, 18);
            this.lbl_Total_Material.TabIndex = 78;
            this.lbl_Total_Material.Text = "__";
            // 
            // rdo_HetHan
            // 
            this.rdo_HetHan.AutoSize = true;
            this.rdo_HetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_HetHan.Location = new System.Drawing.Point(15, 72);
            this.rdo_HetHan.Name = "rdo_HetHan";
            this.rdo_HetHan.Size = new System.Drawing.Size(139, 22);
            this.rdo_HetHan.TabIndex = 74;
            this.rdo_HetHan.TabStop = true;
            this.rdo_HetHan.Text = "Món sắp hết hạn";
            this.rdo_HetHan.UseVisualStyleBackColor = true;
            this.rdo_HetHan.CheckedChanged += new System.EventHandler(this.rdo_HetHan_CheckedChanged);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label86.Location = new System.Drawing.Point(1177, 391);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(123, 18);
            this.label86.TabIndex = 81;
            this.label86.Text = "Tổng nguyên liệu:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label87.Location = new System.Drawing.Point(498, 596);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(0, 18);
            this.label87.TabIndex = 82;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label55.Location = new System.Drawing.Point(1177, 350);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(92, 18);
            this.label55.TabIndex = 83;
            this.label55.Text = "Tổng chi phí:";
            // 
            // dgv_NguyenLieu
            // 
            this.dgv_NguyenLieu.AllowUserToAddRows = false;
            this.dgv_NguyenLieu.AutoGenerateColumns = false;
            this.dgv_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.soLuongNhapDataGridViewTextBoxColumn,
            this.soLuongXuatDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn});
            this.dgv_NguyenLieu.ContextMenuStrip = this.MenuStrip;
            this.dgv_NguyenLieu.DataSource = this.nGUYENLIEUBindingSource;
            this.dgv_NguyenLieu.Location = new System.Drawing.Point(12, 59);
            this.dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            this.dgv_NguyenLieu.RowTemplate.Height = 24;
            this.dgv_NguyenLieu.Size = new System.Drawing.Size(1119, 460);
            this.dgv_NguyenLieu.TabIndex = 76;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "Mã hàng";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "Tên hàng";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            this.soLuongNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.HeaderText = "Số lượng nhập";
            this.soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            // 
            // soLuongXuatDataGridViewTextBoxColumn
            // 
            this.soLuongXuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.soLuongXuatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuat";
            this.soLuongXuatDataGridViewTextBoxColumn.HeaderText = "Số lượng xuất";
            this.soLuongXuatDataGridViewTextBoxColumn.Name = "soLuongXuatDataGridViewTextBoxColumn";
            this.soLuongXuatDataGridViewTextBoxColumn.Width = 123;
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Xoa,
            this.tsm_TaiLai});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(119, 52);
            // 
            // tsm_Xoa
            // 
            this.tsm_Xoa.Name = "tsm_Xoa";
            this.tsm_Xoa.Size = new System.Drawing.Size(118, 24);
            this.tsm_Xoa.Text = "Xóa";
            // 
            // tsm_TaiLai
            // 
            this.tsm_TaiLai.Name = "tsm_TaiLai";
            this.tsm_TaiLai.Size = new System.Drawing.Size(118, 24);
            this.tsm_TaiLai.Text = "Tải lại";
            // 
            // nGUYENLIEUBindingSource
            // 
            this.nGUYENLIEUBindingSource.DataMember = "NGUYENLIEU";
            this.nGUYENLIEUBindingSource.DataSource = this.qL_CaPhe;
            // 
            // qL_CaPhe
            // 
            this.qL_CaPhe.DataSetName = "QL_CaPhe";
            this.qL_CaPhe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TimKiem_toolStripMenuItem
            // 
            this.TimKiem_toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TimKiem_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.Search;
            this.TimKiem_toolStripMenuItem.Name = "TimKiem_toolStripMenuItem";
            this.TimKiem_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.TimKiem_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.TimKiem_toolStripMenuItem.Click += new System.EventHandler(this.TimKiem_toolStripMenuItem_Click);
            // 
            // Text_toolStripTextBox
            // 
            this.Text_toolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Text_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_toolStripTextBox.Name = "Text_toolStripTextBox";
            this.Text_toolStripTextBox.Size = new System.Drawing.Size(130, 25);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // monToolStripMenuItem
            // 
            this.monToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.monToolStripMenuItem.Name = "monToolStripMenuItem";
            this.monToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.monToolStripMenuItem.Text = "Món";
            // 
            // SuCo_ToolStripMenuItem
            // 
            this.SuCo_ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SuCo_ToolStripMenuItem.Name = "SuCo_ToolStripMenuItem";
            this.SuCo_ToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.SuCo_ToolStripMenuItem.Text = "Sự cố";
            // 
            // NguyenLieu_menuStrip
            // 
            this.NguyenLieu_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.NguyenLieu_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NguyenLieu_menuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NguyenLieu_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.NguyenLieu_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NguyenLieu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ve_toolStripMenuItem,
            this.Luu_toolStripMenuItem,
            this.In_toolStripMenuItem,
            this.Tai_toolStripMenuItem,
            this.TimKiem_toolStripMenuItem,
            this.Text_toolStripTextBox,
            this.adminToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.monToolStripMenuItem,
            this.SuCo_ToolStripMenuItem});
            this.NguyenLieu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.NguyenLieu_menuStrip.Name = "NguyenLieu_menuStrip";
            this.NguyenLieu_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.NguyenLieu_menuStrip.Size = new System.Drawing.Size(1497, 29);
            this.NguyenLieu_menuStrip.TabIndex = 84;
            this.NguyenLieu_menuStrip.Text = "MenuMon";
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
            this.Ve_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.Ve_toolStripMenuItem.Click += new System.EventHandler(this.Ve_toolStripMenuItem_Click);
            // 
            // Luu_toolStripMenuItem
            // 
            this.Luu_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.diskette;
            this.Luu_toolStripMenuItem.Name = "Luu_toolStripMenuItem";
            this.Luu_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Luu_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.Luu_toolStripMenuItem.Click += new System.EventHandler(this.Luu_toolStripMenuItem_Click);
            // 
            // In_toolStripMenuItem
            // 
            this.In_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.In_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.printing1;
            this.In_toolStripMenuItem.Name = "In_toolStripMenuItem";
            this.In_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.In_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.In_toolStripMenuItem.Click += new System.EventHandler(this.In_toolStripMenuItem_Click);
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.sync;
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // SuCo_bindingNavigator
            // 
            this.SuCo_bindingNavigator.AddNewItem = null;
            this.SuCo_bindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.SuCo_bindingNavigator.BindingSource = this.nGUYENLIEUBindingSource;
            this.SuCo_bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.SuCo_bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.SuCo_bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.SuCo_bindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SuCo_bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SuCo_bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SuCo_bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.SuCo_bindingNavigator.Location = new System.Drawing.Point(12, 18);
            this.SuCo_bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.SuCo_bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.SuCo_bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.SuCo_bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.SuCo_bindingNavigator.Name = "SuCo_bindingNavigator";
            this.SuCo_bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.SuCo_bindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuCo_bindingNavigator.Size = new System.Drawing.Size(242, 27);
            this.SuCo_bindingNavigator.TabIndex = 85;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // nGUYENLIEUTableAdapter
            // 
            this.nGUYENLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SuCo_bindingNavigator);
            this.groupBox1.Controls.Add(this.dgv_NguyenLieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 538);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(347, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // btn_themPN
            // 
            this.btn_themPN.Location = new System.Drawing.Point(1190, 446);
            this.btn_themPN.Name = "btn_themPN";
            this.btn_themPN.Size = new System.Drawing.Size(186, 55);
            this.btn_themPN.TabIndex = 87;
            this.btn_themPN.Text = "Thêm phiếu nhập";
            this.btn_themPN.UseVisualStyleBackColor = true;
            this.btn_themPN.Click += new System.EventHandler(this.btn_themPN_Click);
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox42.Image = global::QL_CaPhe.Properties.Resources.z3830054331805_aa0582cba2d4824768746a049c3a6e3f;
            this.pictureBox42.Location = new System.Drawing.Point(1187, 43);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(186, 141);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox42.TabIndex = 79;
            this.pictureBox42.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_CanNhap);
            this.groupBox2.Controls.Add(this.rdo_HetHan);
            this.groupBox2.Location = new System.Drawing.Point(1176, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_CaPhe;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1497, 778);
            this.Controls.Add(this.btn_themPN);
            this.Controls.Add(this.NguyenLieu_menuStrip);
            this.Controls.Add(this.lbl_TotalCast_Material);
            this.Controls.Add(this.lbl_Total_Material);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNguyenLieu";
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            this.NguyenLieu_menuStrip.ResumeLayout(false);
            this.NguyenLieu_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuCo_bindingNavigator)).EndInit();
            this.SuCo_bindingNavigator.ResumeLayout(false);
            this.SuCo_bindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_CanNhap;
        private System.Windows.Forms.Label lbl_TotalCast_Material;
        private System.Windows.Forms.Label lbl_Total_Material;
        private System.Windows.Forms.RadioButton rdo_HetHan;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.DataGridView dgv_NguyenLieu;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_Xoa;
        private System.Windows.Forms.ToolStripMenuItem tsm_TaiLai;
        private System.Windows.Forms.ToolStripMenuItem Ve_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Luu_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuCo_ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip NguyenLieu_menuStrip;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator SuCo_bindingNavigator;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource nGUYENLIEUBindingSource;
        private DAL.QL_CaPheTableAdapters.NGUYENLIEUTableAdapter nGUYENLIEUTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}