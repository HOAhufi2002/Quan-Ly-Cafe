namespace QL_CaPhe.GUI
{
    partial class frmGoiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoiMon));
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_XoaAll = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.btn_NhapKH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_thungan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_khachHang = new System.Windows.Forms.Label();
            this.dgv_DsMon = new System.Windows.Forms.DataGridView();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Ban = new System.Windows.Forms.Panel();
            this.btn_ThemBan = new System.Windows.Forms.Button();
            this.panel_goimon = new System.Windows.Forms.Panel();
            this.btn_ThoatHD = new System.Windows.Forms.Button();
            this.panel_chon = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Tongtienfinal = new System.Windows.Forms.Label();
            this.lbl_Giamgia = new System.Windows.Forms.Label();
            this.mONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.MONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            this.panel_goimon.SuspendLayout();
            this.panel_chon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Order
            // 
            this.dgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Location = new System.Drawing.Point(10, 7);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowTemplate.Height = 24;
            this.dgv_Order.Size = new System.Drawing.Size(573, 259);
            this.dgv_Order.TabIndex = 1;
            this.dgv_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellClick);
            this.dgv_Order.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellEndEdit);
            this.dgv_Order.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellValueChanged);
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tongtien.Location = new System.Drawing.Point(1389, 16);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(34, 25);
            this.lbl_tongtien.TabIndex = 92;
            this.lbl_tongtien.Text = "__";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(606, 157);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 45);
            this.btn_Xoa.TabIndex = 93;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_XoaAll
            // 
            this.btn_XoaAll.Location = new System.Drawing.Point(738, 157);
            this.btn_XoaAll.Name = "btn_XoaAll";
            this.btn_XoaAll.Size = new System.Drawing.Size(134, 45);
            this.btn_XoaAll.TabIndex = 93;
            this.btn_XoaAll.Text = "Xóa tất cả";
            this.btn_XoaAll.UseVisualStyleBackColor = true;
            this.btn_XoaAll.Click += new System.EventHandler(this.btn_XoaAll_Click);
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Location = new System.Drawing.Point(606, 214);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(126, 52);
            this.btn_InHoaDon.TabIndex = 93;
            this.btn_InHoaDon.Text = "Tính Tiền";
            this.btn_InHoaDon.UseVisualStyleBackColor = true;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // btn_NhapKH
            // 
            this.btn_NhapKH.Location = new System.Drawing.Point(606, 93);
            this.btn_NhapKH.Name = "btn_NhapKH";
            this.btn_NhapKH.Size = new System.Drawing.Size(266, 52);
            this.btn_NhapKH.TabIndex = 93;
            this.btn_NhapKH.Text = "Thông tin khách hàng";
            this.btn_NhapKH.UseVisualStyleBackColor = true;
            this.btn_NhapKH.Click += new System.EventHandler(this.btn_NhapKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Thu ngân: ";
            // 
            // lbl_thungan
            // 
            this.lbl_thungan.AutoSize = true;
            this.lbl_thungan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_thungan.Location = new System.Drawing.Point(165, 16);
            this.lbl_thungan.Name = "lbl_thungan";
            this.lbl_thungan.Size = new System.Drawing.Size(90, 24);
            this.lbl_thungan.TabIndex = 92;
            this.lbl_thungan.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(547, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 92;
            this.label5.Text = "Khách hàng:";
            // 
            // lbl_khachHang
            // 
            this.lbl_khachHang.AutoSize = true;
            this.lbl_khachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_khachHang.Location = new System.Drawing.Point(670, 16);
            this.lbl_khachHang.Name = "lbl_khachHang";
            this.lbl_khachHang.Size = new System.Drawing.Size(90, 24);
            this.lbl_khachHang.TabIndex = 92;
            this.lbl_khachHang.Text = "Unknown";
            // 
            // dgv_DsMon
            // 
            this.dgv_DsMon.AllowUserToAddRows = false;
            this.dgv_DsMon.AllowUserToDeleteRows = false;
            this.dgv_DsMon.AutoGenerateColumns = false;
            this.dgv_DsMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DsMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn});
            this.dgv_DsMon.DataSource = this.mONBindingSource;
            this.dgv_DsMon.Location = new System.Drawing.Point(10, 90);
            this.dgv_DsMon.Name = "dgv_DsMon";
            this.dgv_DsMon.ReadOnly = true;
            this.dgv_DsMon.RowTemplate.Height = 24;
            this.dgv_DsMon.Size = new System.Drawing.Size(862, 201);
            this.dgv_DsMon.TabIndex = 1;
            this.dgv_DsMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsMon_CellClick);
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "Mã món";
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewCheckBoxColumn
            // 
            this.trangThaiDataGridViewCheckBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            this.trangThaiDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(1257, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "Thành tiền:";
            // 
            // panel_Ban
            // 
            this.panel_Ban.Location = new System.Drawing.Point(12, 54);
            this.panel_Ban.Name = "panel_Ban";
            this.panel_Ban.Size = new System.Drawing.Size(505, 578);
            this.panel_Ban.TabIndex = 94;
            // 
            // btn_ThemBan
            // 
            this.btn_ThemBan.Location = new System.Drawing.Point(384, 5);
            this.btn_ThemBan.Name = "btn_ThemBan";
            this.btn_ThemBan.Size = new System.Drawing.Size(133, 43);
            this.btn_ThemBan.TabIndex = 0;
            this.btn_ThemBan.Text = "Thêm bàn";
            this.btn_ThemBan.UseVisualStyleBackColor = true;
            this.btn_ThemBan.Click += new System.EventHandler(this.btn_ThemBan_Click);
            // 
            // panel_goimon
            // 
            this.panel_goimon.Controls.Add(this.btn_ThoatHD);
            this.panel_goimon.Controls.Add(this.dgv_DsMon);
            this.panel_goimon.Location = new System.Drawing.Point(551, 54);
            this.panel_goimon.Name = "panel_goimon";
            this.panel_goimon.Size = new System.Drawing.Size(889, 304);
            this.panel_goimon.TabIndex = 95;
            // 
            // btn_ThoatHD
            // 
            this.btn_ThoatHD.Location = new System.Drawing.Point(749, 23);
            this.btn_ThoatHD.Name = "btn_ThoatHD";
            this.btn_ThoatHD.Size = new System.Drawing.Size(123, 43);
            this.btn_ThoatHD.TabIndex = 2;
            this.btn_ThoatHD.Text = "Thoát hóa đơn";
            this.btn_ThoatHD.UseVisualStyleBackColor = true;
            this.btn_ThoatHD.Click += new System.EventHandler(this.btn_ThoatHD_Click);
            // 
            // panel_chon
            // 
            this.panel_chon.Controls.Add(this.button1);
            this.panel_chon.Controls.Add(this.btn_XoaAll);
            this.panel_chon.Controls.Add(this.btn_InHoaDon);
            this.panel_chon.Controls.Add(this.dgv_Order);
            this.panel_chon.Controls.Add(this.btn_Xoa);
            this.panel_chon.Controls.Add(this.btn_NhapKH);
            this.panel_chon.Controls.Add(this.label7);
            this.panel_chon.Controls.Add(this.label4);
            this.panel_chon.Controls.Add(this.lbl_Tongtienfinal);
            this.panel_chon.Controls.Add(this.lbl_Giamgia);
            this.panel_chon.Location = new System.Drawing.Point(551, 365);
            this.panel_chon.Name = "panel_chon";
            this.panel_chon.Size = new System.Drawing.Size(889, 276);
            this.panel_chon.TabIndex = 96;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 52);
            this.button1.TabIndex = 97;
            this.button1.Text = "Xuất Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(610, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(610, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Giảm KM:";
            // 
            // lbl_Tongtienfinal
            // 
            this.lbl_Tongtienfinal.AutoSize = true;
            this.lbl_Tongtienfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Tongtienfinal.Location = new System.Drawing.Point(747, 58);
            this.lbl_Tongtienfinal.Name = "lbl_Tongtienfinal";
            this.lbl_Tongtienfinal.Size = new System.Drawing.Size(27, 20);
            this.lbl_Tongtienfinal.TabIndex = 92;
            this.lbl_Tongtienfinal.Text = "__";
            // 
            // lbl_Giamgia
            // 
            this.lbl_Giamgia.AutoSize = true;
            this.lbl_Giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Giamgia.Location = new System.Drawing.Point(747, 25);
            this.lbl_Giamgia.Name = "lbl_Giamgia";
            this.lbl_Giamgia.Size = new System.Drawing.Size(27, 20);
            this.lbl_Giamgia.TabIndex = 92;
            this.lbl_Giamgia.Text = "__";
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // frmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1522, 672);
            this.Controls.Add(this.btn_ThemBan);
            this.Controls.Add(this.panel_Ban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_khachHang);
            this.Controls.Add(this.lbl_thungan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_goimon);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.panel_chon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoiMon_FormClosing);
            this.Load += new System.EventHandler(this.frmGoiMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            this.panel_goimon.ResumeLayout(false);
            this.panel_chon.ResumeLayout(false);
            this.panel_chon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_XoaAll;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_NhapKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_thungan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_khachHang;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private DAL.QL_CaPheTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.DataGridView dgv_DsMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Ban;
        private System.Windows.Forms.Panel panel_goimon;
        private System.Windows.Forms.Panel panel_chon;
        private System.Windows.Forms.Button btn_ThoatHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Tongtienfinal;
        private System.Windows.Forms.Label lbl_Giamgia;
        private System.Windows.Forms.Button btn_ThemBan;
        private System.Windows.Forms.Button button1;
    }
}