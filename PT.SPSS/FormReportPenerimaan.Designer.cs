
namespace PT.SPSS
{
    partial class FormReportPenerimaan
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
            this.penerimaan_produksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
            this.dateTimeAkhir = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAwal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioButtonBarang = new System.Windows.Forms.RadioButton();
            this.penerimaan_produksiTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.penerimaan_produksiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.penerimaan_produksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // penerimaan_produksiBindingSource
            // 
            this.penerimaan_produksiBindingSource.DataMember = "penerimaan_produksi";
            this.penerimaan_produksiBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // pt_spss_kpDataSet
            // 
            this.pt_spss_kpDataSet.DataSetName = "pt_spss_kpDataSet";
            this.pt_spss_kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.Enabled = false;
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(141, 86);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBarang.TabIndex = 32;
            // 
            // dateTimeAkhir
            // 
            this.dateTimeAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAkhir.Enabled = false;
            this.dateTimeAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAkhir.Location = new System.Drawing.Point(381, 60);
            this.dateTimeAkhir.Name = "dateTimeAkhir";
            this.dateTimeAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAkhir.TabIndex = 31;
            // 
            // dateTimeAwal
            // 
            this.dateTimeAwal.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAwal.Enabled = false;
            this.dateTimeAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAwal.Location = new System.Drawing.Point(141, 60);
            this.dateTimeAwal.Name = "dateTimeAwal";
            this.dateTimeAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAwal.TabIndex = 30;
            this.dateTimeAwal.ValueChanged += new System.EventHandler(this.dateTimeAwal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "S/d";
            // 
            // radioButtonTanggal
            // 
            this.radioButtonTanggal.AutoSize = true;
            this.radioButtonTanggal.Location = new System.Drawing.Point(36, 60);
            this.radioButtonTanggal.Name = "radioButtonTanggal";
            this.radioButtonTanggal.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTanggal.TabIndex = 28;
            this.radioButtonTanggal.TabStop = true;
            this.radioButtonTanggal.Text = "Range Tanggal";
            this.radioButtonTanggal.UseVisualStyleBackColor = true;
            this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(141, 127);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 27;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSPenerimaan";
            reportDataSource1.Value = this.penerimaan_produksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportPenerimaan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 175);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 501);
            this.reportViewer1.TabIndex = 26;
            // 
            // radioButtonBarang
            // 
            this.radioButtonBarang.AutoSize = true;
            this.radioButtonBarang.Location = new System.Drawing.Point(36, 90);
            this.radioButtonBarang.Name = "radioButtonBarang";
            this.radioButtonBarang.Size = new System.Drawing.Size(96, 17);
            this.radioButtonBarang.TabIndex = 34;
            this.radioButtonBarang.TabStop = true;
            this.radioButtonBarang.Text = "Nama Barang :";
            this.radioButtonBarang.UseVisualStyleBackColor = true;
            this.radioButtonBarang.CheckedChanged += new System.EventHandler(this.radioButtonSupplier_CheckedChanged);
            // 
            // penerimaan_produksiTableAdapter
            // 
            this.penerimaan_produksiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(944, 33);
            this.label2.TabIndex = 68;
            this.label2.Text = "REPORT PENERIMAAN PRODUKSI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReportPenerimaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBarang);
            this.Controls.Add(this.dateTimeAkhir);
            this.Controls.Add(this.dateTimeAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonTanggal);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.radioButtonBarang);
            this.Name = "FormReportPenerimaan";
            this.Load += new System.EventHandler(this.FormReportPenerimaan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.penerimaan_produksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private System.Windows.Forms.ComboBox comboBoxBarang;
        private System.Windows.Forms.DateTimePicker dateTimeAkhir;
        private System.Windows.Forms.DateTimePicker dateTimeAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTanggal;
        private System.Windows.Forms.Button buttonTampil;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton radioButtonBarang;
        private System.Windows.Forms.BindingSource penerimaan_produksiBindingSource;
        private pt_spss_kpDataSetTableAdapters.penerimaan_produksiTableAdapter penerimaan_produksiTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}