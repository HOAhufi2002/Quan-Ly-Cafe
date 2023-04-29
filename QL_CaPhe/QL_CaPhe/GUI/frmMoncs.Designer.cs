using QL_CaPhe;
namespace QL_CaPhe.GUI
{
    partial class frmMoncs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoncs));
            this.rdo_Most_DrinkFood = new System.Windows.Forms.RadioButton();
            this.rdo_Least_DrinkFood = new System.Windows.Forms.RadioButton();
            this.dgv_Mon = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_TongMon = new System.Windows.Forms.Label();
            this.lbl_Con = new System.Windows.Forms.Label();
            this.lbl_NgungBan = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_MaLoai = new System.Windows.Forms.ComboBox();
            this.lOAIMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lOAIMONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.LOAIMONTableAdapter();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Ve_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Luu_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.mONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.MONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.Mon_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_Most_DrinkFood
            // 
            this.rdo_Most_DrinkFood.AutoSize = true;
            this.rdo_Most_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_Most_DrinkFood.Location = new System.Drawing.Point(1120, 283);
            this.rdo_Most_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Most_DrinkFood.Name = "rdo_Most_DrinkFood";
            this.rdo_Most_DrinkFood.Size = new System.Drawing.Size(142, 24);
            this.rdo_Most_DrinkFood.TabIndex = 7;
            this.rdo_Most_DrinkFood.TabStop = true;
            this.rdo_Most_DrinkFood.Text = "Bán nhiều nhất";
            this.rdo_Most_DrinkFood.UseVisualStyleBackColor = true;
            this.rdo_Most_DrinkFood.CheckedChanged += new System.EventHandler(this.rdo_Most_DrinkFood_CheckedChanged);
            // 
            // rdo_Least_DrinkFood
            // 
            this.rdo_Least_DrinkFood.AutoSize = true;
            this.rdo_Least_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_Least_DrinkFood.Location = new System.Drawing.Point(1120, 328);
            this.rdo_Least_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Least_DrinkFood.Name = "rdo_Least_DrinkFood";
            this.rdo_Least_DrinkFood.Size = new System.Drawing.Size(111, 24);
            this.rdo_Least_DrinkFood.TabIndex = 8;
            this.rdo_Least_DrinkFood.TabStop = true;
            this.rdo_Least_DrinkFood.Text = "Bán ít nhất";
            this.rdo_Least_DrinkFood.UseVisualStyleBackColor = true;
            // 
            // dgv_Mon
            // 
            this.dgv_Mon.AllowUserToAddRows = false;
            this.dgv_Mon.AllowUserToOrderColumns = true;
            this.dgv_Mon.AutoGenerateColumns = false;
            this.dgv_Mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.Gia,
            this.Trangthai,
            this.MaLoai});
            this.dgv_Mon.DataSource = this.mONBindingSource;
            this.dgv_Mon.Location = new System.Drawing.Point(23, 91);
            this.dgv_Mon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Mon.Name = "dgv_Mon";
            this.dgv_Mon.RowTemplate.Height = 24;
            this.dgv_Mon.Size = new System.Drawing.Size(1016, 570);
            this.dgv_Mon.TabIndex = 38;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.Name = "TenMon";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // Trangthai
            // 
            this.Trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trangthai.DataPropertyName = "TrangThai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaLoai
            // 
            this.MaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoai.DataPropertyName = "Maloai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.qL_CaPhe;
            // 
            // qL_CaPhe
            // 
            this.qL_CaPhe.DataSetName = "QL_CaPhe";
            this.qL_CaPhe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1243, 217);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 95;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1158, 214);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 94;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_TongMon
            // 
            this.lbl_TongMon.AutoSize = true;
            this.lbl_TongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TongMon.Location = new System.Drawing.Point(1300, 430);
            this.lbl_TongMon.Name = "lbl_TongMon";
            this.lbl_TongMon.Size = new System.Drawing.Size(24, 18);
            this.lbl_TongMon.TabIndex = 91;
            this.lbl_TongMon.Text = "__";
            // 
            // lbl_Con
            // 
            this.lbl_Con.AutoSize = true;
            this.lbl_Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Con.Location = new System.Drawing.Point(1300, 510);
            this.lbl_Con.Name = "lbl_Con";
            this.lbl_Con.Size = new System.Drawing.Size(24, 18);
            this.lbl_Con.TabIndex = 92;
            this.lbl_Con.Text = "__";
            // 
            // lbl_NgungBan
            // 
            this.lbl_NgungBan.AutoSize = true;
            this.lbl_NgungBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NgungBan.Location = new System.Drawing.Point(1300, 470);
            this.lbl_NgungBan.Name = "lbl_NgungBan";
            this.lbl_NgungBan.Size = new System.Drawing.Size(24, 18);
            this.lbl_NgungBan.TabIndex = 93;
            this.lbl_NgungBan.Text = "__";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label72.Location = new System.Drawing.Point(1125, 470);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(137, 18);
            this.label72.TabIndex = 86;
            this.label72.Text = "Số món ngừng bán:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label70.Location = new System.Drawing.Point(1125, 510);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(90, 18);
            this.label70.TabIndex = 87;
            this.label70.Text = "Số món còn";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label69.Location = new System.Drawing.Point(1125, 430);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(101, 18);
            this.label69.TabIndex = 88;
            this.label69.Text = "Tổng số món:";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.Image = global::QL_CaPhe.Properties.Resources.z3830054331805_aa0582cba2d4824768746a049c3a6e3f;
            this.pictureBox25.Location = new System.Drawing.Point(1113, 52);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(187, 158);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox25.TabIndex = 90;
            this.pictureBox25.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_MaLoai);
            this.groupBox1.Controls.Add(this.dgv_Mon);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(29, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1068, 678);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            // 
            // cbo_MaLoai
            // 
            this.cbo_MaLoai.DataSource = this.lOAIMONBindingSource;
            this.cbo_MaLoai.DisplayMember = "TenLoai";
            this.cbo_MaLoai.FormattingEnabled = true;
            this.cbo_MaLoai.Location = new System.Drawing.Point(838, 33);
            this.cbo_MaLoai.Name = "cbo_MaLoai";
            this.cbo_MaLoai.Size = new System.Drawing.Size(220, 26);
            this.cbo_MaLoai.TabIndex = 40;
            this.cbo_MaLoai.ValueMember = "Maloai";
            this.cbo_MaLoai.SelectedIndexChanged += new System.EventHandler(this.cbo_MaLoai_SelectedIndexChanged);
            // 
            // lOAIMONBindingSource
            // 
            this.lOAIMONBindingSource.DataMember = "LOAIMON";
            this.lOAIMONBindingSource.DataSource = this.qL_CaPhe;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.BindingSource = this.mONBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 19);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1062, 50);
            this.bindingNavigator1.TabIndex = 39;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 47);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 47);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 47);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 47);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 47);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 47);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // lOAIMONTableAdapter
            // 
            this.lOAIMONTableAdapter.ClearBeforeFill = true;
            // 
            // Mon_menuStrip
            // 
            this.Mon_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Mon_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mon_menuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Mon_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Mon_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mon_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ve_toolStripMenuItem,
            this.Luu_toolStripMenuItem1,
            this.In_toolStripMenuItem,
            this.Tai_toolStripMenuItem,
            this.TimKiem_toolStripMenuItem,
            this.Text_toolStripTextBox});
            this.Mon_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Mon_menuStrip.Name = "Mon_menuStrip";
            this.Mon_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Mon_menuStrip.Size = new System.Drawing.Size(1365, 28);
            this.Mon_menuStrip.TabIndex = 97;
            this.Mon_menuStrip.Text = "MenuMon";
            // 
            // Ve_toolStripMenuItem
            // 
            this.Ve_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ve_toolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ve_toolStripMenuItem.ForeColor = System.Drawing.Color.Transparent;
            this.Ve_toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Ve_toolStripMenuItem.Image")));
            this.Ve_toolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Ve_toolStripMenuItem.Name = "Ve_toolStripMenuItem";
            this.Ve_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Ve_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.Ve_toolStripMenuItem.Click += new System.EventHandler(this.Ve_toolStripMenuItem_Click);
            // 
            // Luu_toolStripMenuItem1
            // 
            this.Luu_toolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Luu_toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("Luu_toolStripMenuItem1.Image")));
            this.Luu_toolStripMenuItem1.Name = "Luu_toolStripMenuItem1";
            this.Luu_toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Luu_toolStripMenuItem1.Size = new System.Drawing.Size(32, 24);
            this.Luu_toolStripMenuItem1.Click += new System.EventHandler(this.Luu_toolStripMenuItem1_Click_1);
            // 
            // In_toolStripMenuItem
            // 
            this.In_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.In_toolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.In_toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("In_toolStripMenuItem.Image")));
            this.In_toolStripMenuItem.Name = "In_toolStripMenuItem";
            this.In_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.In_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.In_toolStripMenuItem.Click += new System.EventHandler(this.In_toolStripMenuItem_Click);
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Tai_toolStripMenuItem.Image")));
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // TimKiem_toolStripMenuItem
            // 
            this.TimKiem_toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TimKiem_toolStripMenuItem.Image = global::QL_CaPhe.Properties.Resources.Search;
            this.TimKiem_toolStripMenuItem.Name = "TimKiem_toolStripMenuItem";
            this.TimKiem_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.TimKiem_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.TimKiem_toolStripMenuItem.Click += new System.EventHandler(this.TimKiem_toolStripMenuItem_Click);
            // 
            // Text_toolStripTextBox
            // 
            this.Text_toolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Text_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_toolStripTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.Text_toolStripTextBox.Name = "Text_toolStripTextBox";
            this.Text_toolStripTextBox.Size = new System.Drawing.Size(149, 24);
            this.Text_toolStripTextBox.Enter += new System.EventHandler(this.Text_toolStripTextBox_Enter);
            this.Text_toolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_toolStripTextBox_KeyPress);
            // 
            // btn_themmon
            // 
            this.btn_themmon.Location = new System.Drawing.Point(1113, 367);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(211, 48);
            this.btn_themmon.TabIndex = 14;
            this.btn_themmon.Text = "Thêm món";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // frmMoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1365, 722);
            this.Controls.Add(this.rdo_Least_DrinkFood);
            this.Controls.Add(this.btn_themmon);
            this.Controls.Add(this.rdo_Most_DrinkFood);
            this.Controls.Add(this.Mon_menuStrip);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.lbl_TongMon);
            this.Controls.Add(this.lbl_Con);
            this.Controls.Add(this.lbl_NgungBan);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMoncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMoncs_FormClosing);
            this.Load += new System.EventHandler(this.frmMoncs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_Most_DrinkFood;
        private System.Windows.Forms.RadioButton rdo_Least_DrinkFood;
        private System.Windows.Forms.DataGridView dgv_Mon;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_TongMon;
        private System.Windows.Forms.Label lbl_Con;
        private System.Windows.Forms.Label lbl_NgungBan;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.GroupBox groupBox1;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource lOAIMONBindingSource;
        private DAL.QL_CaPheTableAdapters.LOAIMONTableAdapter lOAIMONTableAdapter;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private DAL.QL_CaPheTableAdapters.MONTableAdapter mONTableAdapter;
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
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Ve_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Luu_toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.Button btn_themmon;
        private System.Windows.Forms.ComboBox cbo_MaLoai;
    }
}