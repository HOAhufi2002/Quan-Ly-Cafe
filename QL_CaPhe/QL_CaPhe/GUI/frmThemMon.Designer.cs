namespace QL_CaPhe.GUI
{
    partial class frmThemMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemMon));
            this.rdo_Het_DrinkFood = new System.Windows.Forms.RadioButton();
            this.rdo_Con_DrinkFood = new System.Windows.Forms.RadioButton();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.lOAIMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_CaPhe = new QL_CaPhe.DAL.QL_CaPhe();
            this.txt_Cash_DrinkFood = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txt_Name_DrinkFood = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.txt_Category_DrinkFood = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.ptb_RemoveAccount = new System.Windows.Forms.PictureBox();
            this.ptb_AddAccount = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lOAIMONTableAdapter = new QL_CaPhe.DAL.QL_CaPheTableAdapters.LOAIMONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RemoveAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_Het_DrinkFood
            // 
            this.rdo_Het_DrinkFood.AutoSize = true;
            this.rdo_Het_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_Het_DrinkFood.Location = new System.Drawing.Point(327, 228);
            this.rdo_Het_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Het_DrinkFood.Name = "rdo_Het_DrinkFood";
            this.rdo_Het_DrinkFood.Size = new System.Drawing.Size(110, 24);
            this.rdo_Het_DrinkFood.TabIndex = 6;
            this.rdo_Het_DrinkFood.TabStop = true;
            this.rdo_Het_DrinkFood.Text = "Ngừng bán";
            this.rdo_Het_DrinkFood.UseVisualStyleBackColor = true;
            // 
            // rdo_Con_DrinkFood
            // 
            this.rdo_Con_DrinkFood.AutoSize = true;
            this.rdo_Con_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_Con_DrinkFood.Location = new System.Drawing.Point(175, 228);
            this.rdo_Con_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Con_DrinkFood.Name = "rdo_Con_DrinkFood";
            this.rdo_Con_DrinkFood.Size = new System.Drawing.Size(60, 24);
            this.rdo_Con_DrinkFood.TabIndex = 5;
            this.rdo_Con_DrinkFood.TabStop = true;
            this.rdo_Con_DrinkFood.Text = "Còn";
            this.rdo_Con_DrinkFood.UseVisualStyleBackColor = true;
            // 
            // cbo_Category
            // 
            this.cbo_Category.DataSource = this.lOAIMONBindingSource;
            this.cbo_Category.DisplayMember = "TenLoai";
            this.cbo_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(119, 77);
            this.cbo_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(403, 28);
            this.cbo_Category.TabIndex = 2;
            this.cbo_Category.ValueMember = "Maloai";
            // 
            // lOAIMONBindingSource
            // 
            this.lOAIMONBindingSource.DataMember = "LOAIMON";
            this.lOAIMONBindingSource.DataSource = this.qL_CaPhe;
            // 
            // qL_CaPhe
            // 
            this.qL_CaPhe.DataSetName = "QL_CaPhe";
            this.qL_CaPhe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Cash_DrinkFood
            // 
            this.txt_Cash_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Cash_DrinkFood.Location = new System.Drawing.Point(119, 181);
            this.txt_Cash_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cash_DrinkFood.Name = "txt_Cash_DrinkFood";
            this.txt_Cash_DrinkFood.Size = new System.Drawing.Size(403, 27);
            this.txt_Cash_DrinkFood.TabIndex = 4;
            this.txt_Cash_DrinkFood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cash_DrinkFood_KeyPress);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label59.Location = new System.Drawing.Point(14, 181);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 18);
            this.label59.TabIndex = 17;
            this.label59.Text = "Giá:";
            // 
            // txt_Name_DrinkFood
            // 
            this.txt_Name_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name_DrinkFood.Location = new System.Drawing.Point(119, 131);
            this.txt_Name_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name_DrinkFood.Name = "txt_Name_DrinkFood";
            this.txt_Name_DrinkFood.Size = new System.Drawing.Size(403, 27);
            this.txt_Name_DrinkFood.TabIndex = 3;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label54.Location = new System.Drawing.Point(14, 131);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(71, 18);
            this.label54.TabIndex = 18;
            this.label54.Text = "Tên món:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label66.Location = new System.Drawing.Point(14, 231);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(77, 18);
            this.label66.TabIndex = 19;
            this.label66.Text = "Trạng thái:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label64.Location = new System.Drawing.Point(14, 81);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(40, 18);
            this.label64.TabIndex = 20;
            this.label64.Text = "Loại:";
            // 
            // txt_Category_DrinkFood
            // 
            this.txt_Category_DrinkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Category_DrinkFood.Location = new System.Drawing.Point(119, 31);
            this.txt_Category_DrinkFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Category_DrinkFood.Name = "txt_Category_DrinkFood";
            this.txt_Category_DrinkFood.Size = new System.Drawing.Size(403, 27);
            this.txt_Category_DrinkFood.TabIndex = 1;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label63.Location = new System.Drawing.Point(14, 31);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(67, 18);
            this.label63.TabIndex = 21;
            this.label63.Text = "Mã món:";
            // 
            // ptb_RemoveAccount
            // 
            this.ptb_RemoveAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_RemoveAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptb_RemoveAccount.Image")));
            this.ptb_RemoveAccount.Location = new System.Drawing.Point(314, 350);
            this.ptb_RemoveAccount.Name = "ptb_RemoveAccount";
            this.ptb_RemoveAccount.Size = new System.Drawing.Size(50, 38);
            this.ptb_RemoveAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_RemoveAccount.TabIndex = 25;
            this.ptb_RemoveAccount.TabStop = false;
            this.ptb_RemoveAccount.Click += new System.EventHandler(this.ptb_RemoveAccount_Click);
            // 
            // ptb_AddAccount
            // 
            this.ptb_AddAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptb_AddAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptb_AddAccount.Image")));
            this.ptb_AddAccount.Location = new System.Drawing.Point(187, 350);
            this.ptb_AddAccount.Name = "ptb_AddAccount";
            this.ptb_AddAccount.Size = new System.Drawing.Size(50, 38);
            this.ptb_AddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_AddAccount.TabIndex = 27;
            this.ptb_AddAccount.TabStop = false;
            this.ptb_AddAccount.Click += new System.EventHandler(this.ptb_AddAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(169, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "NHẬP MÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Het_DrinkFood);
            this.groupBox1.Controls.Add(this.txt_Category_DrinkFood);
            this.groupBox1.Controls.Add(this.rdo_Con_DrinkFood);
            this.groupBox1.Controls.Add(this.label63);
            this.groupBox1.Controls.Add(this.cbo_Category);
            this.groupBox1.Controls.Add(this.label64);
            this.groupBox1.Controls.Add(this.txt_Cash_DrinkFood);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.txt_Name_DrinkFood);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 264);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // lOAIMONTableAdapter
            // 
            this.lOAIMONTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(563, 410);
            this.Controls.Add(this.ptb_RemoveAccount);
            this.Controls.Add(this.ptb_AddAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemMon_FormClosing);
            this.Load += new System.EventHandler(this.frmThemMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_CaPhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RemoveAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AddAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_RemoveAccount;
        private System.Windows.Forms.PictureBox ptb_AddAccount;
        private System.Windows.Forms.RadioButton rdo_Het_DrinkFood;
        private System.Windows.Forms.RadioButton rdo_Con_DrinkFood;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.TextBox txt_Cash_DrinkFood;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txt_Name_DrinkFood;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txt_Category_DrinkFood;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DAL.QL_CaPhe qL_CaPhe;
        private System.Windows.Forms.BindingSource lOAIMONBindingSource;
        private DAL.QL_CaPheTableAdapters.LOAIMONTableAdapter lOAIMONTableAdapter;
    }
}