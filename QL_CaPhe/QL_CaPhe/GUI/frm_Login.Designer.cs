namespace QL_CaPhe.GUI
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_Tendangnhap = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.ptb_DangNhap = new System.Windows.Forms.PictureBox();
            this.banTableAdapter1 = new QL_CaPhe.DAL.QL_CaPheTableAdapters.BANTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox42);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 239);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox42.Image = global::QL_CaPhe.Properties.Resources.z3830054331805_aa0582cba2d4824768746a049c3a6e3f;
            this.pictureBox42.Location = new System.Drawing.Point(144, 38);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(196, 168);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox42.TabIndex = 81;
            this.pictureBox42.TabStop = false;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(169, 345);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(258, 28);
            this.txt_MatKhau.TabIndex = 83;
            this.txt_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MatKhau_KeyDown);
            // 
            // txt_Tendangnhap
            // 
            this.txt_Tendangnhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Tendangnhap.Location = new System.Drawing.Point(169, 282);
            this.txt_Tendangnhap.Name = "txt_Tendangnhap";
            this.txt_Tendangnhap.Size = new System.Drawing.Size(258, 28);
            this.txt_Tendangnhap.TabIndex = 82;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(18, 352);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(78, 21);
            this.lbl_MatKhau.TabIndex = 84;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(18, 289);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(121, 21);
            this.lbl_TenDangNhap.TabIndex = 85;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // ptb_DangNhap
            // 
            this.ptb_DangNhap.Image = global::QL_CaPhe.Properties.Resources.DangNhap;
            this.ptb_DangNhap.Location = new System.Drawing.Point(144, 414);
            this.ptb_DangNhap.Name = "ptb_DangNhap";
            this.ptb_DangNhap.Size = new System.Drawing.Size(210, 61);
            this.ptb_DangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_DangNhap.TabIndex = 86;
            this.ptb_DangNhap.TabStop = false;
            this.ptb_DangNhap.Click += new System.EventHandler(this.ptb_DangNhap_Click);
            // 
            // banTableAdapter1
            // 
            this.banTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_Tendangnhap);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.ptb_DangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Login_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_Tendangnhap;
        private System.Windows.Forms.PictureBox ptb_DangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private DAL.QL_CaPheTableAdapters.BANTableAdapter banTableAdapter1;
    }
}