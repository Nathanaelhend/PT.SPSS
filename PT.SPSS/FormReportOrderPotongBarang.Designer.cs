
namespace PT.SPSS
{
    partial class FormReportOrderPotongBarang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.textBoxNoOrder = new System.Windows.Forms.TextBox();
            this.detail_hppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.total_hppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahan_bakuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barang_jadiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporthppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_hppTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.total_hppTableAdapter();
            this.reporthppTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.reporthppTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detail_hppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_hppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_bakuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_jadiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporthppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(944, 33);
            this.label2.TabIndex = 69;
            this.label2.Text = "REPORT ORDER POTONG/HPP PER BARANG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "Detail_Hpp";
            reportDataSource6.Value = this.detail_hppBindingSource;
            reportDataSource7.Name = "Total_Hpp";
            reportDataSource7.Value = this.total_hppBindingSource;
            reportDataSource8.Name = "Bahan_Baku";
            reportDataSource8.Value = this.bahan_bakuBindingSource;
            reportDataSource9.Name = "Barang_Jadi";
            reportDataSource9.Value = this.barang_jadiBindingSource;
            reportDataSource10.Name = "report";
            reportDataSource10.Value = this.reporthppBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportHPPOrderPerBarang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 501);
            this.reportViewer1.TabIndex = 70;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // buttonTampil
            // 
            this.buttonTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTampil.Location = new System.Drawing.Point(234, 123);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 71;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // textBoxNoOrder
            // 
            this.textBoxNoOrder.Location = new System.Drawing.Point(234, 86);
            this.textBoxNoOrder.Name = "textBoxNoOrder";
            this.textBoxNoOrder.Size = new System.Drawing.Size(103, 20);
            this.textBoxNoOrder.TabIndex = 72;
            // 
            // detail_hppBindingSource
            // 
            this.detail_hppBindingSource.DataMember = "detail_hpp";
            this.detail_hppBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // pt_spss_kpDataSet
            // 
            this.pt_spss_kpDataSet.DataSetName = "pt_spss_kpDataSet";
            this.pt_spss_kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total_hppBindingSource
            // 
            this.total_hppBindingSource.DataMember = "total_hpp";
            this.total_hppBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // bahan_bakuBindingSource
            // 
            this.bahan_bakuBindingSource.DataMember = "bahan_baku";
            this.bahan_bakuBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // barang_jadiBindingSource
            // 
            this.barang_jadiBindingSource.DataMember = "barang_jadi";
            this.barang_jadiBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // reporthppBindingSource
            // 
            this.reporthppBindingSource.DataMember = "reporthpp";
            this.reporthppBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // total_hppTableAdapter
            // 
            this.total_hppTableAdapter.ClearBeforeFill = true;
            // 
            // reporthppTableAdapter
            // 
            this.reporthppTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "No Bukti Order :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormReportOrderPotongBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNoOrder);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Name = "FormReportOrderPotongBarang";
            this.Load += new System.EventHandler(this.FormReportOrderPotongBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detail_hppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_hppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_bakuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_jadiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporthppBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detail_hppBindingSource;
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private System.Windows.Forms.Button buttonTampil;
        private System.Windows.Forms.TextBox textBoxNoOrder;
        private System.Windows.Forms.BindingSource total_hppBindingSource;
        private System.Windows.Forms.BindingSource bahan_bakuBindingSource;
        private System.Windows.Forms.BindingSource barang_jadiBindingSource;
        private pt_spss_kpDataSetTableAdapters.total_hppTableAdapter total_hppTableAdapter;
        private System.Windows.Forms.BindingSource reporthppBindingSource;
        private pt_spss_kpDataSetTableAdapters.reporthppTableAdapter reporthppTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}