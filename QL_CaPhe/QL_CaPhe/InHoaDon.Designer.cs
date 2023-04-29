namespace QL_CaPhe
{
    partial class InHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InHoaDon));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_CaPheDataSet = new QL_CaPhe.QL_CaPheDataSet();
            this.ChiTietHDTableAdapter = new QL_CaPhe.QL_CaPheDataSetTableAdapters.ChiTietHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_CaPheDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CaPhe.GUI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(847, 663);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChiTietHDBindingSource
            // 
            this.ChiTietHDBindingSource.DataMember = "ChiTietHD";
            this.ChiTietHDBindingSource.DataSource = this.QL_CaPheDataSet;
            // 
            // QL_CaPheDataSet
            // 
            this.QL_CaPheDataSet.DataSetName = "QL_CaPheDataSet";
            this.QL_CaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHDTableAdapter
            // 
            this.ChiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 663);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InHoaDon";
            this.Text = "In Hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_CaPheDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHDBindingSource;
        private QL_CaPheDataSet QL_CaPheDataSet;
        private QL_CaPheDataSetTableAdapters.ChiTietHDTableAdapter ChiTietHDTableAdapter;
    }
}