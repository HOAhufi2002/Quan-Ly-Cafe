namespace QL_CaPhe.GUI
{
    partial class frmPhieuNhapSuCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapSuCo));
            this.grb_Incident = new System.Windows.Forms.GroupBox();
            this.cbo_Employee_Incident = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.cbo_Name_Custumer_Incident = new System.Windows.Forms.ComboBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label83 = new System.Windows.Forms.Label();
            this.txt_Solve_Incident = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.txt_infCast_Incident = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.txt_infCategory_Incident = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.txt_infName_Incident = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptb_RemoveAccount = new System.Windows.Forms.PictureBox();
            this.ptb_AddAccount = new System.Windows.Forms.PictureBox();
            this.kHACHHANGTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.KHACHHANGTableAdapter();
            this.nHANVIENTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter();
            this.grb_Incident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RemoveAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Incident
            // 
            this.grb_Incident.Controls.Add(this.cbo_Employee_Incident);
            this.grb_Incident.Controls.Add(this.cbo_Name_Custumer_Incident);
            this.grb_Incident.Controls.Add(this.label83);
            this.grb_Incident.Controls.Add(this.txt_Solve_Incident);
            this.grb_Incident.Controls.Add(this.label79);
            this.grb_Incident.Controls.Add(this.dtp_NgayLap);
            this.grb_Incident.Controls.Add(this.label78);
            this.grb_Incident.Controls.Add(this.label77);
            this.grb_Incident.Controls.Add(this.txt_infCast_Incident);
            this.grb_Incident.Controls.Add(this.label101);
            this.grb_Incident.Controls.Add(this.txt_infCategory_Incident);
            this.grb_Incident.Controls.Add(this.label76);
            this.grb_Incident.Controls.Add(this.txt_infName_Incident);
            this.grb_Incident.Controls.Add(this.label1);
            this.grb_Incident.Controls.Add(this.label75);
            this.grb_Incident.Location = new System.Drawing.Point(44, 80);
            this.grb_Incident.Name = "grb_Incident";
            this.grb_Incident.Size = new System.Drawing.Size(481, 426);
            this.grb_Incident.TabIndex = 77;
            this.grb_Incident.TabStop = false;
            this.grb_Incident.Text = "Biên bản";
            // 
            // cbo_Employee_Incident
            // 
            this.cbo_Employee_Incident.DataSource = this.nHANVIENBindingSource;
            this.cbo_Employee_Incident.DisplayMember = "HoTen";
            this.cbo_Employee_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Employee_Incident.FormattingEnabled = true;
            this.cbo_Employee_Incident.Location = new System.Drawing.Point(143, 79);
            this.cbo_Employee_Incident.Name = "cbo_Employee_Incident";
            this.cbo_Employee_Incident.Size = new System.Drawing.Size(300, 26);
            this.cbo_Employee_Incident.TabIndex = 2;
            this.cbo_Employee_Incident.ValueMember = "MaNV";
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
            // cbo_Name_Custumer_Incident
            // 
            this.cbo_Name_Custumer_Incident.DataSource = this.kHACHHANGBindingSource;
            this.cbo_Name_Custumer_Incident.DisplayMember = "TenKH";
            this.cbo_Name_Custumer_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Name_Custumer_Incident.FormattingEnabled = true;
            this.cbo_Name_Custumer_Incident.Location = new System.Drawing.Point(143, 31);
            this.cbo_Name_Custumer_Incident.Name = "cbo_Name_Custumer_Incident";
            this.cbo_Name_Custumer_Incident.Size = new System.Drawing.Size(300, 26);
            this.cbo_Name_Custumer_Incident.TabIndex = 1;
            this.cbo_Name_Custumer_Incident.ValueMember = "MaKH";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qL_CaPhe;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label83.Location = new System.Drawing.Point(-107, 62);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(87, 18);
            this.label83.TabIndex = 26;
            this.label83.Text = "Mã hóa đơn";
            // 
            // txt_Solve_Incident
            // 
            this.txt_Solve_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Solve_Incident.Location = new System.Drawing.Point(143, 311);
            this.txt_Solve_Incident.Multiline = true;
            this.txt_Solve_Incident.Name = "txt_Solve_Incident";
            this.txt_Solve_Incident.Size = new System.Drawing.Size(300, 91);
            this.txt_Solve_Incident.TabIndex = 7;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label79.Location = new System.Drawing.Point(15, 175);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(92, 18);
            this.label79.TabIndex = 13;
            this.label79.Text = "Mã biên bản:";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_NgayLap.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dtp_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(143, 265);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(300, 24);
            this.dtp_NgayLap.TabIndex = 6;
            this.dtp_NgayLap.Value = new System.DateTime(2022, 11, 19, 22, 36, 20, 0);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label78.Location = new System.Drawing.Point(15, 129);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(96, 18);
            this.label78.TabIndex = 12;
            this.label78.Text = "Tên biên bản:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label77.Location = new System.Drawing.Point(15, 221);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(57, 18);
            this.label77.TabIndex = 11;
            this.label77.Text = "Chi phí:";
            // 
            // txt_infCast_Incident
            // 
            this.txt_infCast_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_infCast_Incident.Location = new System.Drawing.Point(143, 219);
            this.txt_infCast_Incident.Name = "txt_infCast_Incident";
            this.txt_infCast_Incident.Size = new System.Drawing.Size(300, 24);
            this.txt_infCast_Incident.TabIndex = 5;
            this.txt_infCast_Incident.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_infCast_Incident_KeyPress);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label101.Location = new System.Drawing.Point(15, 83);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(77, 18);
            this.label101.TabIndex = 11;
            this.label101.Text = "Nhân viên:";
            // 
            // txt_infCategory_Incident
            // 
            this.txt_infCategory_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_infCategory_Incident.Location = new System.Drawing.Point(143, 173);
            this.txt_infCategory_Incident.Name = "txt_infCategory_Incident";
            this.txt_infCategory_Incident.Size = new System.Drawing.Size(300, 24);
            this.txt_infCategory_Incident.TabIndex = 4;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label76.Location = new System.Drawing.Point(15, 313);
            this.label76.Name = "label76";
            this.label76.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label76.Size = new System.Drawing.Size(77, 18);
            this.label76.TabIndex = 11;
            this.label76.Text = "Giải quyết:";
            // 
            // txt_infName_Incident
            // 
            this.txt_infName_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_infName_Incident.Location = new System.Drawing.Point(143, 127);
            this.txt_infName_Incident.Name = "txt_infName_Incident";
            this.txt_infName_Incident.Size = new System.Drawing.Size(300, 24);
            this.txt_infName_Incident.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày lập:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label75.Location = new System.Drawing.Point(15, 37);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(90, 18);
            this.label75.TabIndex = 11;
            this.label75.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(180, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "NHẬP SỰ CỐ";
            // 
            // ptb_RemoveAccount
            // 
            this.ptb_RemoveAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_RemoveAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptb_RemoveAccount.Image")));
            this.ptb_RemoveAccount.Location = new System.Drawing.Point(384, 524);
            this.ptb_RemoveAccount.Name = "ptb_RemoveAccount";
            this.ptb_RemoveAccount.Size = new System.Drawing.Size(50, 38);
            this.ptb_RemoveAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_RemoveAccount.TabIndex = 78;
            this.ptb_RemoveAccount.TabStop = false;
            this.ptb_RemoveAccount.Click += new System.EventHandler(this.ptb_RemoveAccount_Click);
            // 
            // ptb_AddAccount
            // 
            this.ptb_AddAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_AddAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptb_AddAccount.Image")));
            this.ptb_AddAccount.Location = new System.Drawing.Point(157, 524);
            this.ptb_AddAccount.Name = "ptb_AddAccount";
            this.ptb_AddAccount.Size = new System.Drawing.Size(50, 38);
            this.ptb_AddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_AddAccount.TabIndex = 79;
            this.ptb_AddAccount.TabStop = false;
            this.ptb_AddAccount.Click += new System.EventHandler(this.ptb_AddAccount_Click);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhapSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(576, 584);
            this.Controls.Add(this.ptb_RemoveAccount);
            this.Controls.Add(this.ptb_AddAccount);
            this.Controls.Add(this.grb_Incident);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuNhapSuCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sự cố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuNhapSuCo_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuNhapSuCo_Load);
            this.grb_Incident.ResumeLayout(false);
            this.grb_Incident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RemoveAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Incident;
        private System.Windows.Forms.ComboBox cbo_Employee_Incident;
        private System.Windows.Forms.ComboBox cbo_Name_Custumer_Incident;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox txt_Solve_Incident;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox txt_infCast_Incident;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txt_infCategory_Incident;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox txt_infName_Incident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_RemoveAccount;
        private System.Windows.Forms.PictureBox ptb_AddAccount;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DAL.QL_CaPheTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}