namespace QL_CaPhe.GUI
{
    partial class FrmSuCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuCo));
            this.rdo_Top_Least_Incident = new System.Windows.Forms.RadioButton();
            this.dgv_SuCo = new System.Windows.Forms.DataGridView();
            this.lbl_TongSC = new System.Windows.Forms.Label();
            this.NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lbl_TongCP = new System.Windows.Forms.Label();
            this.NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xemchitiet = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rdo_Top_Most_Incident = new System.Windows.Forms.RadioButton();
            this.label71 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.monToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuCo_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Ve_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchSựCốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_themSuCo = new System.Windows.Forms.Button();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.maBienBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBienBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaiQuyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUCOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.sUCOTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.SUCOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuCo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuCo_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUCOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            this.SuspendLayout();
            // 
            // rdo_Top_Least_Incident
            // 
            this.rdo_Top_Least_Incident.AutoSize = true;
            this.rdo_Top_Least_Incident.Location = new System.Drawing.Point(1268, 218);
            this.rdo_Top_Least_Incident.Name = "rdo_Top_Least_Incident";
            this.rdo_Top_Least_Incident.Size = new System.Drawing.Size(142, 21);
            this.rdo_Top_Least_Incident.TabIndex = 58;
            this.rdo_Top_Least_Incident.TabStop = true;
            this.rdo_Top_Least_Incident.Text = "Top chi phí ít nhất";
            this.rdo_Top_Least_Incident.UseVisualStyleBackColor = true;
            this.rdo_Top_Least_Incident.CheckedChanged += new System.EventHandler(this.rdo_Top_Least_Incident_CheckedChanged);
            // 
            // dgv_SuCo
            // 
            this.dgv_SuCo.AllowUserToAddRows = false;
            this.dgv_SuCo.AutoGenerateColumns = false;
            this.dgv_SuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBienBanDataGridViewTextBoxColumn,
            this.tenBienBanDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.giaiQuyetDataGridViewTextBoxColumn,
            this.chiPhiDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn});
            this.dgv_SuCo.DataSource = this.sUCOBindingSource;
            this.dgv_SuCo.Location = new System.Drawing.Point(6, 64);
            this.dgv_SuCo.Name = "dgv_SuCo";
            this.dgv_SuCo.RowTemplate.Height = 24;
            this.dgv_SuCo.Size = new System.Drawing.Size(1199, 397);
            this.dgv_SuCo.TabIndex = 54;
            this.dgv_SuCo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SuCo_CellClick);
            // 
            // lbl_TongSC
            // 
            this.lbl_TongSC.AutoSize = true;
            this.lbl_TongSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TongSC.Location = new System.Drawing.Point(1358, 313);
            this.lbl_TongSC.Name = "lbl_TongSC";
            this.lbl_TongSC.Size = new System.Drawing.Size(24, 18);
            this.lbl_TongSC.TabIndex = 11;
            this.lbl_TongSC.Text = "__";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayKetThuc.CustomFormat = "MM/dd/yyyy";
            this.NgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayKetThuc.Location = new System.Drawing.Point(539, 23);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Size = new System.Drawing.Size(117, 24);
            this.NgayKetThuc.TabIndex = 51;
            this.NgayKetThuc.Value = new System.DateTime(2022, 11, 19, 22, 36, 20, 0);
            // 
            // lbl_TongCP
            // 
            this.lbl_TongCP.AutoSize = true;
            this.lbl_TongCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TongCP.Location = new System.Drawing.Point(1363, 349);
            this.lbl_TongCP.Name = "lbl_TongCP";
            this.lbl_TongCP.Size = new System.Drawing.Size(24, 18);
            this.lbl_TongCP.TabIndex = 11;
            this.lbl_TongCP.Text = "__";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayBatDau.CustomFormat = "MM/dd/yyyy";
            this.NgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayBatDau.Location = new System.Drawing.Point(322, 23);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Size = new System.Drawing.Size(121, 24);
            this.NgayBatDau.TabIndex = 51;
            this.NgayBatDau.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Tim.Location = new System.Drawing.Point(449, 20);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 27);
            this.btn_Tim.TabIndex = 74;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.btn_Xemchitiet);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.dgv_SuCo);
            this.groupBox1.Controls.Add(this.NgayKetThuc);
            this.groupBox1.Controls.Add(this.NgayBatDau);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1225, 483);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // btn_Xemchitiet
            // 
            this.btn_Xemchitiet.Location = new System.Drawing.Point(1040, 25);
            this.btn_Xemchitiet.Name = "btn_Xemchitiet";
            this.btn_Xemchitiet.Size = new System.Drawing.Size(165, 34);
            this.btn_Xemchitiet.TabIndex = 79;
            this.btn_Xemchitiet.Text = "Xem chi tiết";
            this.btn_Xemchitiet.UseVisualStyleBackColor = true;
            this.btn_Xemchitiet.Click += new System.EventHandler(this.btn_Xemchitiet_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(977, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.BindingSource = this.sUCOBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 20);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1219, 27);
            this.bindingNavigator1.TabIndex = 75;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // rdo_Top_Most_Incident
            // 
            this.rdo_Top_Most_Incident.AutoSize = true;
            this.rdo_Top_Most_Incident.Location = new System.Drawing.Point(1268, 269);
            this.rdo_Top_Most_Incident.Name = "rdo_Top_Most_Incident";
            this.rdo_Top_Most_Incident.Size = new System.Drawing.Size(170, 21);
            this.rdo_Top_Most_Incident.TabIndex = 57;
            this.rdo_Top_Most_Incident.TabStop = true;
            this.rdo_Top_Most_Incident.Text = "Top chi phí nhiều nhất";
            this.rdo_Top_Most_Incident.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label71.Location = new System.Drawing.Point(1265, 349);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(92, 18);
            this.label71.TabIndex = 50;
            this.label71.Text = "Tổng chi phí:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label73.Location = new System.Drawing.Point(1265, 313);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(87, 18);
            this.label73.TabIndex = 48;
            this.label73.Text = "Tổng sự cố:";
            // 
            // monToolStripMenuItem
            // 
            this.monToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.monToolStripMenuItem.Name = "monToolStripMenuItem";
            this.monToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.monToolStripMenuItem.Text = "Món";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
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
            this.toolStripMenuItem1,
            this.In_toolStripMenuItem,
            this.Tai_toolStripMenuItem,
            this.TimKiem_toolStripMenuItem,
            this.Text_toolStripTextBox,
            this.adminToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.monToolStripMenuItem});
            this.SuCo_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.SuCo_menuStrip.Name = "SuCo_menuStrip";
            this.SuCo_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SuCo_menuStrip.Size = new System.Drawing.Size(1493, 29);
            this.SuCo_menuStrip.TabIndex = 76;
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
            this.Ve_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.Ve_toolStripMenuItem.Click += new System.EventHandler(this.Ve_toolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::QL_CaPhe.Properties.Resources.diskette;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 25);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.In_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.In_toolStripMenuItem.Click += new System.EventHandler(this.In_toolStripMenuItem_Click);
            // 
            // xuấtDanhSáchSựCốToolStripMenuItem
            // 
            this.xuấtDanhSáchSựCốToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchSựCốToolStripMenuItem.Name = "xuấtDanhSáchSựCốToolStripMenuItem";
            this.xuấtDanhSáchSựCốToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchSựCốToolStripMenuItem.Text = "Xuất danh sách sự cố";
            this.xuấtDanhSáchSựCốToolStripMenuItem.Click += new System.EventHandler(this.xuấtDanhSáchSựCốToolStripMenuItem_Click);
            // 
            // xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem
            // 
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Name = "xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem";
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Text = "Xuất danh sách chi phí ít nhất";
            this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem.Click += new System.EventHandler(this.xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem_Click);
            // 
            // xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem
            // 
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Name = "xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem";
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Text = "Xuất danh sách chi phí nhiều nhất";
            this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem.Click += new System.EventHandler(this.xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem_Click);
            // 
            // xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem
            // 
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Name = "xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem";
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Text = "Xuất danh sách sự cố theo thời gian";
            this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem.Click += new System.EventHandler(this.xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem_Click);
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.sync;
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
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
            // btn_themSuCo
            // 
            this.btn_themSuCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_themSuCo.Location = new System.Drawing.Point(1268, 397);
            this.btn_themSuCo.Name = "btn_themSuCo";
            this.btn_themSuCo.Size = new System.Drawing.Size(186, 38);
            this.btn_themSuCo.TabIndex = 79;
            this.btn_themSuCo.Text = "Nhập sự cố";
            this.btn_themSuCo.UseVisualStyleBackColor = true;
            this.btn_themSuCo.Click += new System.EventHandler(this.btn_themSuCo_Click);
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox35.Image = global::QL_CaPhe.Properties.Resources.z3830054331805_aa0582cba2d4824768746a049c3a6e3f;
            this.pictureBox35.Location = new System.Drawing.Point(1268, 57);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(186, 141);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox35.TabIndex = 74;
            this.pictureBox35.TabStop = false;
            // 
            // maBienBanDataGridViewTextBoxColumn
            // 
            this.maBienBanDataGridViewTextBoxColumn.DataPropertyName = "MaBienBan";
            this.maBienBanDataGridViewTextBoxColumn.HeaderText = "Mã biên bảng";
            this.maBienBanDataGridViewTextBoxColumn.Name = "maBienBanDataGridViewTextBoxColumn";
            this.maBienBanDataGridViewTextBoxColumn.Width = 188;
            // 
            // tenBienBanDataGridViewTextBoxColumn
            // 
            this.tenBienBanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenBienBanDataGridViewTextBoxColumn.DataPropertyName = "TenBienBan";
            this.tenBienBanDataGridViewTextBoxColumn.HeaderText = "Tên biên bảng";
            this.tenBienBanDataGridViewTextBoxColumn.Name = "tenBienBanDataGridViewTextBoxColumn";
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lậo";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // giaiQuyetDataGridViewTextBoxColumn
            // 
            this.giaiQuyetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaiQuyetDataGridViewTextBoxColumn.DataPropertyName = "GiaiQuyet";
            this.giaiQuyetDataGridViewTextBoxColumn.HeaderText = "Giải quyết";
            this.giaiQuyetDataGridViewTextBoxColumn.Name = "giaiQuyetDataGridViewTextBoxColumn";
            // 
            // chiPhiDataGridViewTextBoxColumn
            // 
            this.chiPhiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chiPhiDataGridViewTextBoxColumn.DataPropertyName = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.HeaderText = "Chi Phí";
            this.chiPhiDataGridViewTextBoxColumn.Name = "chiPhiDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã Khách hàng";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
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
            // sUCOTableAdapter
            // 
            this.sUCOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1493, 547);
            this.Controls.Add(this.btn_themSuCo);
            this.Controls.Add(this.rdo_Top_Most_Incident);
            this.Controls.Add(this.rdo_Top_Least_Incident);
            this.Controls.Add(this.lbl_TongSC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SuCo_menuStrip);
            this.Controls.Add(this.lbl_TongCP);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label71);
            this.Name = "FrmSuCo";
            this.Text = "FrmSuCo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSuCo_FormClosing);
            this.Load += new System.EventHandler(this.FrmSuCo_Load);
            this.Shown += new System.EventHandler(this.FrmSuCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuCo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.SuCo_menuStrip.ResumeLayout(false);
            this.SuCo_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUCOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_Top_Least_Incident;
        private System.Windows.Forms.DataGridView dgv_SuCo;
        private System.Windows.Forms.Label lbl_TongSC;
        private System.Windows.Forms.DateTimePicker NgayKetThuc;
        private System.Windows.Forms.Label lbl_TongCP;
        private System.Windows.Forms.DateTimePicker NgayBatDau;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Top_Most_Incident;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ToolStripMenuItem monToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip SuCo_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Ve_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox35;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource sUCOBindingSource;
        private DAL.QL_CaPheTableAdapters.SUCOTableAdapter sUCOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBienBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBienBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaiQuyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btn_Xemchitiet;
        private System.Windows.Forms.Button btn_themSuCo;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchSựCốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchChiPhíÍtNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchChiPhíNhiềuNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchSựCốTheoThờiGianToolStripMenuItem;
    }
}