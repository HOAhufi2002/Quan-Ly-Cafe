namespace QL_CaPhe.GUI
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.DoanhThu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Luu_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Custumer_Bill = new System.Windows.Forms.TextBox();
            this.txt_inf_DateBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Inf_CategoryBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.dtp_DateFinish_Bi = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateStart_Bill = new System.Windows.Forms.DateTimePicker();
            this.SuCo_bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Total_Bill = new System.Windows.Forms.TextBox();
            this.txt_Total_FoodDrink_Bill = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hOADONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.HOADONTableAdapter();
            this.cHITIETHOADONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.CHITIETHOADONTableAdapter();
            this.nHANVIENTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter();
            this.DoanhThu_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuCo_bindingNavigator)).BeginInit();
            this.SuCo_bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoanhThu_menuStrip
            // 
            this.DoanhThu_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.DoanhThu_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DoanhThu_menuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DoanhThu_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.DoanhThu_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DoanhThu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Luu_toolStripMenuItem,
            this.Tai_toolStripMenuItem,
            this.Thoat_ToolStripMenuItem,
            this.TimKiem_toolStripMenuItem,
            this.Text_toolStripTextBox});
            this.DoanhThu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.DoanhThu_menuStrip.Name = "DoanhThu_menuStrip";
            this.DoanhThu_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.DoanhThu_menuStrip.Size = new System.Drawing.Size(1630, 29);
            this.DoanhThu_menuStrip.TabIndex = 92;
            this.DoanhThu_menuStrip.Text = "MenuMon";
            // 
            // Luu_toolStripMenuItem
            // 
            this.Luu_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Luu_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.diskette;
            this.Luu_toolStripMenuItem.Name = "Luu_toolStripMenuItem";
            this.Luu_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Luu_toolStripMenuItem.Size = new System.Drawing.Size(32, 25);
            this.Luu_toolStripMenuItem.Click += new System.EventHandler(this.Luu_toolStripMenuItem_Click);
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(12, 25);
            // 
            // Thoat_ToolStripMenuItem
            // 
            this.Thoat_ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Thoat_ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat_ToolStripMenuItem.Name = "Thoat_ToolStripMenuItem";
            this.Thoat_ToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.Thoat_ToolStripMenuItem.Text = "Thoát";
            // 
            // TimKiem_toolStripMenuItem
            // 
            this.TimKiem_toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TimKiem_toolStripMenuItem.Name = "TimKiem_toolStripMenuItem";
            this.TimKiem_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.TimKiem_toolStripMenuItem.Size = new System.Drawing.Size(12, 25);
            // 
            // Text_toolStripTextBox
            // 
            this.Text_toolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Text_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_toolStripTextBox.Name = "Text_toolStripTextBox";
            this.Text_toolStripTextBox.Size = new System.Drawing.Size(130, 25);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nHANVIENBindingSource, "HoTen", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hOADONBindingSource, "MaNV", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.comboBox1.DataSource = this.nHANVIENBindingSource;
            this.comboBox1.DisplayMember = "HoTen";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(462, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 24);
            this.comboBox1.TabIndex = 113;
            this.comboBox1.ValueMember = "MaNV";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_CaPhe;
            // 
            // qL_CaPhe
            // 
            this.qL_CaPhe.DataSetName = "QL_CaPhe";
            this.qL_CaPhe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qL_CaPhe;
            // 
            // txt_Custumer_Bill
            // 
            this.txt_Custumer_Bill.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MaKH", true));
            this.txt_Custumer_Bill.Enabled = false;
            this.txt_Custumer_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Custumer_Bill.Location = new System.Drawing.Point(912, 117);
            this.txt_Custumer_Bill.Multiline = true;
            this.txt_Custumer_Bill.Name = "txt_Custumer_Bill";
            this.txt_Custumer_Bill.ReadOnly = true;
            this.txt_Custumer_Bill.Size = new System.Drawing.Size(264, 26);
            this.txt_Custumer_Bill.TabIndex = 109;
            // 
            // txt_inf_DateBill
            // 
            this.txt_inf_DateBill.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "NgayLapHD", true));
            this.txt_inf_DateBill.Enabled = false;
            this.txt_inf_DateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_inf_DateBill.Location = new System.Drawing.Point(912, 65);
            this.txt_inf_DateBill.Multiline = true;
            this.txt_inf_DateBill.Name = "txt_inf_DateBill";
            this.txt_inf_DateBill.ReadOnly = true;
            this.txt_inf_DateBill.Size = new System.Drawing.Size(264, 26);
            this.txt_inf_DateBill.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(784, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 111;
            this.label1.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(828, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 112;
            this.label3.Text = "Ngày";
            // 
            // txt_Inf_CategoryBill
            // 
            this.txt_Inf_CategoryBill.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MaHD", true));
            this.txt_Inf_CategoryBill.Enabled = false;
            this.txt_Inf_CategoryBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Inf_CategoryBill.Location = new System.Drawing.Point(462, 65);
            this.txt_Inf_CategoryBill.Multiline = true;
            this.txt_Inf_CategoryBill.Name = "txt_Inf_CategoryBill";
            this.txt_Inf_CategoryBill.ReadOnly = true;
            this.txt_Inf_CategoryBill.Size = new System.Drawing.Size(266, 26);
            this.txt_Inf_CategoryBill.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(362, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(348, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Mã hóa đơn";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThongKe.Location = new System.Drawing.Point(937, 173);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(144, 29);
            this.btn_ThongKe.TabIndex = 117;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            // 
            // dtp_DateFinish_Bi
            // 
            this.dtp_DateFinish_Bi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_DateFinish_Bi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_DateFinish_Bi.Location = new System.Drawing.Point(648, 180);
            this.dtp_DateFinish_Bi.Name = "dtp_DateFinish_Bi";
            this.dtp_DateFinish_Bi.Size = new System.Drawing.Size(262, 22);
            this.dtp_DateFinish_Bi.TabIndex = 116;
            // 
            // dtp_DateStart_Bill
            // 
            this.dtp_DateStart_Bill.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_DateStart_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_DateStart_Bill.Location = new System.Drawing.Point(351, 180);
            this.dtp_DateStart_Bill.Name = "dtp_DateStart_Bill";
            this.dtp_DateStart_Bill.Size = new System.Drawing.Size(262, 22);
            this.dtp_DateStart_Bill.TabIndex = 115;
            // 
            // SuCo_bindingNavigator
            // 
            this.SuCo_bindingNavigator.AddNewItem = null;
            this.SuCo_bindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.SuCo_bindingNavigator.BindingSource = this.hOADONBindingSource;
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
            this.SuCo_bindingNavigator.Location = new System.Drawing.Point(33, 173);
            this.SuCo_bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.SuCo_bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.SuCo_bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.SuCo_bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.SuCo_bindingNavigator.Name = "SuCo_bindingNavigator";
            this.SuCo_bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.SuCo_bindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuCo_bindingNavigator.Size = new System.Drawing.Size(242, 27);
            this.SuCo_bindingNavigator.TabIndex = 114;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 24);
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn1,
            this.soLuongDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.cHITIETHOADONBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(937, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(648, 313);
            this.dataGridView2.TabIndex = 119;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "Mã món";
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            // 
            // maHDDataGridViewTextBoxColumn1
            // 
            this.maHDDataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.maHDDataGridViewTextBoxColumn1.Name = "maHDDataGridViewTextBoxColumn1";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn1
            // 
            this.thanhTienDataGridViewTextBoxColumn1.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn1.HeaderText = "Thành tiền";
            this.thanhTienDataGridViewTextBoxColumn1.Name = "thanhTienDataGridViewTextBoxColumn1";
            // 
            // cHITIETHOADONBindingSource
            // 
            this.cHITIETHOADONBindingSource.DataMember = "CHITIETHOADON";
            this.cHITIETHOADONBindingSource.DataSource = this.qL_CaPhe;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.ngayLapHDDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.maBanDataGridViewTextBoxColumn,
            this.giamGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOADONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 313);
            this.dataGridView1.TabIndex = 118;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            // 
            // ngayLapHDDataGridViewTextBoxColumn
            // 
            this.ngayLapHDDataGridViewTextBoxColumn.DataPropertyName = "NgayLapHD";
            this.ngayLapHDDataGridViewTextBoxColumn.HeaderText = "Ngày lập hóa đơn";
            this.ngayLapHDDataGridViewTextBoxColumn.Name = "ngayLapHDDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // maBanDataGridViewTextBoxColumn
            // 
            this.maBanDataGridViewTextBoxColumn.DataPropertyName = "MaBan";
            this.maBanDataGridViewTextBoxColumn.HeaderText = "Mã bàn";
            this.maBanDataGridViewTextBoxColumn.Name = "maBanDataGridViewTextBoxColumn";
            // 
            // giamGiaDataGridViewTextBoxColumn
            // 
            this.giamGiaDataGridViewTextBoxColumn.DataPropertyName = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.giamGiaDataGridViewTextBoxColumn.Name = "giamGiaDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // txt_Total_Bill
            // 
            this.txt_Total_Bill.Enabled = false;
            this.txt_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Total_Bill.Location = new System.Drawing.Point(772, 576);
            this.txt_Total_Bill.Multiline = true;
            this.txt_Total_Bill.Name = "txt_Total_Bill";
            this.txt_Total_Bill.ReadOnly = true;
            this.txt_Total_Bill.Size = new System.Drawing.Size(104, 26);
            this.txt_Total_Bill.TabIndex = 120;
            // 
            // txt_Total_FoodDrink_Bill
            // 
            this.txt_Total_FoodDrink_Bill.Enabled = false;
            this.txt_Total_FoodDrink_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Total_FoodDrink_Bill.Location = new System.Drawing.Point(986, 576);
            this.txt_Total_FoodDrink_Bill.Multiline = true;
            this.txt_Total_FoodDrink_Bill.Name = "txt_Total_FoodDrink_Bill";
            this.txt_Total_FoodDrink_Bill.ReadOnly = true;
            this.txt_Total_FoodDrink_Bill.Size = new System.Drawing.Size(93, 26);
            this.txt_Total_FoodDrink_Bill.TabIndex = 121;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label25.Location = new System.Drawing.Point(904, 579);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 18);
            this.label25.TabIndex = 123;
            this.label25.Text = "Tổng tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(645, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 18);
            this.label11.TabIndex = 122;
            this.label11.Text = "Tổng số hóa đơn";
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETHOADONTableAdapter
            // 
            this.cHITIETHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1630, 619);
            this.Controls.Add(this.txt_Total_Bill);
            this.Controls.Add(this.txt_Total_FoodDrink_Bill);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.dtp_DateFinish_Bi);
            this.Controls.Add(this.dtp_DateStart_Bill);
            this.Controls.Add(this.SuCo_bindingNavigator);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Custumer_Bill);
            this.Controls.Add(this.txt_inf_DateBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Inf_CategoryBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoanhThu_menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.DoanhThu_menuStrip.ResumeLayout(false);
            this.DoanhThu_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuCo_bindingNavigator)).EndInit();
            this.SuCo_bindingNavigator.ResumeLayout(false);
            this.SuCo_bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip DoanhThu_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Luu_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Thoat_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Custumer_Bill;
        private System.Windows.Forms.TextBox txt_inf_DateBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Inf_CategoryBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DateTimePicker dtp_DateFinish_Bi;
        private System.Windows.Forms.DateTimePicker dtp_DateStart_Bill;
        private System.Windows.Forms.BindingNavigator SuCo_bindingNavigator;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Total_Bill;
        private System.Windows.Forms.TextBox txt_Total_FoodDrink_Bill;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label11;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DAL.QL_CaPheTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.BindingSource cHITIETHOADONBindingSource;
        private DAL.QL_CaPheTableAdapters.CHITIETHOADONTableAdapter cHITIETHOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}