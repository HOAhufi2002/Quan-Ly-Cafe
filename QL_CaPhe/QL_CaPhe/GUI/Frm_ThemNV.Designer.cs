namespace QL_CaPhe.GUI
{
    partial class Frm_ThemNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThemNV));
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Position = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lbl_Birth = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_NameEmployee = new System.Windows.Forms.Label();
            this.lbl_CategoryEmployee = new System.Windows.Forms.Label();
            this.txt_tendangnhaplogin = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_NameEmployee = new System.Windows.Forms.TextBox();
            this.txt_CategoryEmployee = new System.Windows.Forms.TextBox();
            this.grp_InfEmployee = new System.Windows.Forms.GroupBox();
            this.ptb_AddAccount = new System.Windows.Forms.PictureBox();
            this.nHANVIENTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            this.grp_InfEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(128, 221);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(265, 22);
            this.txt_DOB.TabIndex = 18;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(128, 179);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(265, 22);
            this.txtsex.TabIndex = 17;
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(178, 405);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(75, 36);
            this.btn_AddEmployee.TabIndex = 11;
            this.btn_AddEmployee.Text = "Thêm";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nhập Nhân Viên";
            // 
            // cbb_Position
            // 
            this.cbb_Position.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nHANVIENBindingSource, "MaCV", true));
            this.cbb_Position.DataSource = this.nHANVIENBindingSource;
            this.cbb_Position.DisplayMember = "MaCV";
            this.cbb_Position.FormattingEnabled = true;
            this.cbb_Position.Location = new System.Drawing.Point(128, 310);
            this.cbb_Position.Name = "cbb_Position";
            this.cbb_Position.Size = new System.Drawing.Size(265, 24);
            this.cbb_Position.TabIndex = 7;
            this.cbb_Position.ValueMember = "MaCV";
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
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Position.Location = new System.Drawing.Point(44, 315);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(66, 18);
            this.lbl_Position.TabIndex = 3;
            this.lbl_Position.Text = "Chức vụ:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.Location = new System.Drawing.Point(7, 94);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(111, 18);
            this.label35.TabIndex = 3;
            this.label35.Text = "Tên Đăng Nhập";
            // 
            // lbl_Birth
            // 
            this.lbl_Birth.AutoSize = true;
            this.lbl_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Birth.Location = new System.Drawing.Point(37, 222);
            this.lbl_Birth.Name = "lbl_Birth";
            this.lbl_Birth.Size = new System.Drawing.Size(77, 18);
            this.lbl_Birth.TabIndex = 3;
            this.lbl_Birth.Text = "Ngày sinh:";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Gender.Location = new System.Drawing.Point(37, 183);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(66, 18);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Giới tính:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Phone.Location = new System.Drawing.Point(16, 270);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(98, 18);
            this.lbl_Phone.TabIndex = 3;
            this.lbl_Phone.Text = "Số điện thoại:";
            // 
            // lbl_NameEmployee
            // 
            this.lbl_NameEmployee.AutoSize = true;
            this.lbl_NameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NameEmployee.Location = new System.Drawing.Point(55, 139);
            this.lbl_NameEmployee.Name = "lbl_NameEmployee";
            this.lbl_NameEmployee.Size = new System.Drawing.Size(56, 18);
            this.lbl_NameEmployee.TabIndex = 3;
            this.lbl_NameEmployee.Text = "Họ tên:";
            // 
            // lbl_CategoryEmployee
            // 
            this.lbl_CategoryEmployee.AutoSize = true;
            this.lbl_CategoryEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CategoryEmployee.Location = new System.Drawing.Point(16, 50);
            this.lbl_CategoryEmployee.Name = "lbl_CategoryEmployee";
            this.lbl_CategoryEmployee.Size = new System.Drawing.Size(99, 18);
            this.lbl_CategoryEmployee.TabIndex = 3;
            this.lbl_CategoryEmployee.Text = "Mã nhân viên:";
            // 
            // txt_tendangnhaplogin
            // 
            this.txt_tendangnhaplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tendangnhaplogin.Location = new System.Drawing.Point(128, 87);
            this.txt_tendangnhaplogin.Multiline = true;
            this.txt_tendangnhaplogin.Name = "txt_tendangnhaplogin";
            this.txt_tendangnhaplogin.Size = new System.Drawing.Size(265, 26);
            this.txt_tendangnhaplogin.TabIndex = 8;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Phone.Location = new System.Drawing.Point(128, 263);
            this.txt_Phone.Multiline = true;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(265, 26);
            this.txt_Phone.TabIndex = 6;
            // 
            // txt_NameEmployee
            // 
            this.txt_NameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NameEmployee.Location = new System.Drawing.Point(128, 132);
            this.txt_NameEmployee.Multiline = true;
            this.txt_NameEmployee.Name = "txt_NameEmployee";
            this.txt_NameEmployee.Size = new System.Drawing.Size(265, 26);
            this.txt_NameEmployee.TabIndex = 2;
            // 
            // txt_CategoryEmployee
            // 
            this.txt_CategoryEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_CategoryEmployee.Location = new System.Drawing.Point(128, 43);
            this.txt_CategoryEmployee.Multiline = true;
            this.txt_CategoryEmployee.Name = "txt_CategoryEmployee";
            this.txt_CategoryEmployee.Size = new System.Drawing.Size(265, 26);
            this.txt_CategoryEmployee.TabIndex = 1;
            // 
            // grp_InfEmployee
            // 
            this.grp_InfEmployee.Controls.Add(this.txt_DOB);
            this.grp_InfEmployee.Controls.Add(this.txtsex);
            this.grp_InfEmployee.Controls.Add(this.btn_AddEmployee);
            this.grp_InfEmployee.Controls.Add(this.cbb_Position);
            this.grp_InfEmployee.Controls.Add(this.lbl_Position);
            this.grp_InfEmployee.Controls.Add(this.label35);
            this.grp_InfEmployee.Controls.Add(this.lbl_Birth);
            this.grp_InfEmployee.Controls.Add(this.ptb_AddAccount);
            this.grp_InfEmployee.Controls.Add(this.lbl_Gender);
            this.grp_InfEmployee.Controls.Add(this.lbl_Phone);
            this.grp_InfEmployee.Controls.Add(this.lbl_NameEmployee);
            this.grp_InfEmployee.Controls.Add(this.lbl_CategoryEmployee);
            this.grp_InfEmployee.Controls.Add(this.txt_tendangnhaplogin);
            this.grp_InfEmployee.Controls.Add(this.txt_Phone);
            this.grp_InfEmployee.Controls.Add(this.txt_NameEmployee);
            this.grp_InfEmployee.Controls.Add(this.txt_CategoryEmployee);
            this.grp_InfEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_InfEmployee.Location = new System.Drawing.Point(66, 73);
            this.grp_InfEmployee.Name = "grp_InfEmployee";
            this.grp_InfEmployee.Size = new System.Drawing.Size(399, 456);
            this.grp_InfEmployee.TabIndex = 105;
            this.grp_InfEmployee.TabStop = false;
            this.grp_InfEmployee.Text = "Thông tin nhân viên";
            // 
            // ptb_AddAccount
            // 
            this.ptb_AddAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_AddAccount.Image = global::QL_CaPhe.Properties.Resources.add;
            this.ptb_AddAccount.Location = new System.Drawing.Point(178, 361);
            this.ptb_AddAccount.Name = "ptb_AddAccount";
            this.ptb_AddAccount.Size = new System.Drawing.Size(75, 38);
            this.ptb_AddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_AddAccount.TabIndex = 10;
            this.ptb_AddAccount.TabStop = false;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(540, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_InfEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ThemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhân viên";
            this.Load += new System.EventHandler(this.Frm_ThemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            this.grp_InfEmployee.ResumeLayout(false);
            this.grp_InfEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Position;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lbl_Birth;
        private System.Windows.Forms.PictureBox ptb_AddAccount;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_NameEmployee;
        private System.Windows.Forms.Label lbl_CategoryEmployee;
        private System.Windows.Forms.TextBox txt_tendangnhaplogin;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_NameEmployee;
        private System.Windows.Forms.GroupBox grp_InfEmployee;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DAL.QL_CaPheTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.TextBox txt_CategoryEmployee;
    }
}