namespace QL_CaPhe.GUI
{
    partial class frmNhapNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapNguyenLieu));
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.dtp_HSD = new System.Windows.Forms.DateTimePicker();
            this.label116 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.txt_DonVi = new System.Windows.Forms.TextBox();
            this.txt_Cast_Material = new System.Windows.Forms.TextBox();
            this.txt_QuanityImport_Material = new System.Windows.Forms.TextBox();
            this.txt_Name_Material = new System.Windows.Forms.TextBox();
            this.txt_Category_Material = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptb_RemoveAccount = new System.Windows.Forms.PictureBox();
            this.ptb_AddAccount = new System.Windows.Forms.PictureBox();
            this.nHANVIENTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RemoveAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.DataSource = this.nHANVIENBindingSource;
            this.cbo_NhanVien.DisplayMember = "HoTen";
            this.cbo_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Location = new System.Drawing.Point(185, 232);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(315, 28);
            this.cbo_NhanVien.TabIndex = 5;
            this.cbo_NhanVien.ValueMember = "MaNV";
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
            // dtp_HSD
            // 
            this.dtp_HSD.CustomFormat = "MM/dd/yyyy";
            this.dtp_HSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_HSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_HSD.Location = new System.Drawing.Point(185, 183);
            this.dtp_HSD.Name = "dtp_HSD";
            this.dtp_HSD.Size = new System.Drawing.Size(315, 27);
            this.dtp_HSD.TabIndex = 4;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label116.Location = new System.Drawing.Point(20, 239);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(129, 20);
            this.label116.TabIndex = 36;
            this.label116.Text = "Nhân viên nhập:";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label111.Location = new System.Drawing.Point(20, 341);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(40, 20);
            this.label111.TabIndex = 36;
            this.label111.Text = "Giá:";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label112.Location = new System.Drawing.Point(20, 290);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(93, 20);
            this.label112.TabIndex = 36;
            this.label112.Text = "Đơn vị tính:";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label113.Location = new System.Drawing.Point(20, 188);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(109, 20);
            this.label113.TabIndex = 36;
            this.label113.Text = "Hạn sử dụng:";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label94.Location = new System.Drawing.Point(20, 137);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(120, 20);
            this.label94.TabIndex = 36;
            this.label94.Text = "Số lượng nhập:";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label109.Location = new System.Drawing.Point(20, 86);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(83, 20);
            this.label109.TabIndex = 36;
            this.label109.Text = "Tên hàng:";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label95.Location = new System.Drawing.Point(20, 35);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(78, 20);
            this.label95.TabIndex = 36;
            this.label95.Text = "Mã hàng:";
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DonVi.Location = new System.Drawing.Point(185, 283);
            this.txt_DonVi.Multiline = true;
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Size = new System.Drawing.Size(315, 26);
            this.txt_DonVi.TabIndex = 6;
            // 
            // txt_Cast_Material
            // 
            this.txt_Cast_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Cast_Material.Location = new System.Drawing.Point(185, 334);
            this.txt_Cast_Material.Multiline = true;
            this.txt_Cast_Material.Name = "txt_Cast_Material";
            this.txt_Cast_Material.Size = new System.Drawing.Size(315, 26);
            this.txt_Cast_Material.TabIndex = 7;
            this.txt_Cast_Material.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cast_Material_KeyPress);
            // 
            // txt_QuanityImport_Material
            // 
            this.txt_QuanityImport_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_QuanityImport_Material.Location = new System.Drawing.Point(185, 132);
            this.txt_QuanityImport_Material.Multiline = true;
            this.txt_QuanityImport_Material.Name = "txt_QuanityImport_Material";
            this.txt_QuanityImport_Material.Size = new System.Drawing.Size(315, 26);
            this.txt_QuanityImport_Material.TabIndex = 3;
            this.txt_QuanityImport_Material.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuanityImport_Material_KeyPress);
            // 
            // txt_Name_Material
            // 
            this.txt_Name_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name_Material.Location = new System.Drawing.Point(185, 81);
            this.txt_Name_Material.Multiline = true;
            this.txt_Name_Material.Name = "txt_Name_Material";
            this.txt_Name_Material.Size = new System.Drawing.Size(315, 26);
            this.txt_Name_Material.TabIndex = 2;
            // 
            // txt_Category_Material
            // 
            this.txt_Category_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Category_Material.Location = new System.Drawing.Point(185, 30);
            this.txt_Category_Material.Multiline = true;
            this.txt_Category_Material.Name = "txt_Category_Material";
            this.txt_Category_Material.Size = new System.Drawing.Size(315, 26);
            this.txt_Category_Material.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "PHIẾU NHẬP HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label111);
            this.groupBox1.Controls.Add(this.cbo_NhanVien);
            this.groupBox1.Controls.Add(this.txt_Name_Material);
            this.groupBox1.Controls.Add(this.label112);
            this.groupBox1.Controls.Add(this.label109);
            this.groupBox1.Controls.Add(this.label116);
            this.groupBox1.Controls.Add(this.label113);
            this.groupBox1.Controls.Add(this.txt_DonVi);
            this.groupBox1.Controls.Add(this.label94);
            this.groupBox1.Controls.Add(this.txt_Cast_Material);
            this.groupBox1.Controls.Add(this.txt_QuanityImport_Material);
            this.groupBox1.Controls.Add(this.dtp_HSD);
            this.groupBox1.Controls.Add(this.label95);
            this.groupBox1.Controls.Add(this.txt_Category_Material);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 378);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // ptb_RemoveAccount
            // 
            this.ptb_RemoveAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_RemoveAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptb_RemoveAccount.Image")));
            this.ptb_RemoveAccount.Location = new System.Drawing.Point(369, 470);
            this.ptb_RemoveAccount.Name = "ptb_RemoveAccount";
            this.ptb_RemoveAccount.Size = new System.Drawing.Size(50, 38);
            this.ptb_RemoveAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_RemoveAccount.TabIndex = 38;
            this.ptb_RemoveAccount.TabStop = false;
            this.ptb_RemoveAccount.Click += new System.EventHandler(this.ptb_RemoveAccount_Click);
            // 
            // ptb_AddAccount
            // 
            this.ptb_AddAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_AddAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptb_AddAccount.Image")));
            this.ptb_AddAccount.Location = new System.Drawing.Point(142, 470);
            this.ptb_AddAccount.Name = "ptb_AddAccount";
            this.ptb_AddAccount.Size = new System.Drawing.Size(50, 38);
            this.ptb_AddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_AddAccount.TabIndex = 40;
            this.ptb_AddAccount.TabStop = false;
            this.ptb_AddAccount.Click += new System.EventHandler(this.ptb_AddAccount_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 525);
            this.Controls.Add(this.ptb_RemoveAccount);
            this.Controls.Add(this.ptb_AddAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhapNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapNguyenLieu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapNguyenLieu_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RemoveAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.DateTimePicker dtp_HSD;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TextBox txt_DonVi;
        private System.Windows.Forms.TextBox txt_Cast_Material;
        private System.Windows.Forms.TextBox txt_QuanityImport_Material;
        private System.Windows.Forms.TextBox txt_Name_Material;
        private System.Windows.Forms.TextBox txt_Category_Material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptb_AddAccount;
        private System.Windows.Forms.PictureBox ptb_RemoveAccount;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}