
namespace PT.SPSS
{
    partial class FormDaftarOrderPotong
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.detail_hppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.total_hppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahan_bakuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barang_jadiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporthppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeAkhir = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAwal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.total_hppTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.total_hppTableAdapter();
            this.reporthppTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.reporthppTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detail_hppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_hppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_bakuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barang_jadiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporthppBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "Detail_Hpp";
            reportDataSource1.Value = this.detail_hppBindingSource;
            reportDataSource2.Name = "Total_Hpp";
            reportDataSource2.Value = this.total_hppBindingSource;
            reportDataSource3.Name = "Bahan_Baku";
            reportDataSource3.Value = this.bahan_bakuBindingSource;
            reportDataSource4.Name = "Barang_Jadi";
            reportDataSource4.Value = this.barang_jadiBindingSource;
            reportDataSource5.Name = "report";
            reportDataSource5.Value = this.reporthppBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportHPPOrderPerBarang2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 166);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 501);
            this.reportViewer1.TabIndex = 71;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(944, 33);
            this.label2.TabIndex = 72;
            this.label2.Text = "REPORT DAFTAR ORDER POTONG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeAkhir
            // 
            this.dateTimeAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAkhir.Enabled = false;
            this.dateTimeAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAkhir.Location = new System.Drawing.Point(414, 91);
            this.dateTimeAkhir.Name = "dateTimeAkhir";
            this.dateTimeAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAkhir.TabIndex = 75;
            // 
            // dateTimeAwal
            // 
            this.dateTimeAwal.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAwal.Location = new System.Drawing.Point(174, 91);
            this.dateTimeAwal.Name = "dateTimeAwal";
            this.dateTimeAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAwal.TabIndex = 74;
            this.dateTimeAwal.ValueChanged += new System.EventHandler(this.dateTimeAwal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "S/d";
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(357, 127);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 76;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // total_hppTableAdapter
            // 
            this.total_hppTableAdapter.ClearBeforeFill = true;
            // 
            // reporthppTableAdapter
            // 
            this.reporthppTableAdapter.ClearBeforeFill = true;
            // 
            // FormDaftarOrderPotong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.dateTimeAkhir);
            this.Controls.Add(this.dateTimeAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormDaftarOrderPotong";
            this.Load += new System.EventHandler(this.FormDaftarOrderPotong_Load);
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

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeAkhir;
        private System.Windows.Forms.DateTimePicker dateTimeAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource detail_hppBindingSource;
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private System.Windows.Forms.BindingSource total_hppBindingSource;
        private System.Windows.Forms.BindingSource bahan_bakuBindingSource;
        private System.Windows.Forms.BindingSource barang_jadiBindingSource;
        private System.Windows.Forms.BindingSource reporthppBindingSource;
        private System.Windows.Forms.Button buttonTampil;
        private pt_spss_kpDataSetTableAdapters.total_hppTableAdapter total_hppTableAdapter;
        private pt_spss_kpDataSetTableAdapters.reporthppTableAdapter reporthppTableAdapter;
    }
}