
namespace PT.SPSS
{
    partial class FrmReportNotaBeli
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
            this.buttonTampil = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeAwal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAkhir = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.radioButtonSupplier = new System.Windows.Forms.RadioButton();
            this.nota_beliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.nota_beli_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nota_beliTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.nota_beliTableAdapter();
            this.nota_beli_detailTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.nota_beli_detailTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nota_beliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_beli_detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(119, 113);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 3;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPembelian";
            reportDataSource1.Value = this.nota_beliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportPembelian.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(949, 580);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.ZoomPercent = 85;
            // 
            // radioButtonTanggal
            // 
            this.radioButtonTanggal.AutoSize = true;
            this.radioButtonTanggal.Location = new System.Drawing.Point(14, 60);
            this.radioButtonTanggal.Name = "radioButtonTanggal";
            this.radioButtonTanggal.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTanggal.TabIndex = 6;
            this.radioButtonTanggal.TabStop = true;
            this.radioButtonTanggal.Text = "Range Tanggal";
            this.radioButtonTanggal.UseVisualStyleBackColor = true;
            this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "S/d";
            // 
            // dateTimeAwal
            // 
            this.dateTimeAwal.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAwal.Enabled = false;
            this.dateTimeAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAwal.Location = new System.Drawing.Point(119, 60);
            this.dateTimeAwal.Name = "dateTimeAwal";
            this.dateTimeAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAwal.TabIndex = 9;
            this.dateTimeAwal.ValueChanged += new System.EventHandler(this.dateTimeAwal_ValueChanged_1);
            // 
            // dateTimeAkhir
            // 
            this.dateTimeAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAkhir.Enabled = false;
            this.dateTimeAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAkhir.Location = new System.Drawing.Point(359, 60);
            this.dateTimeAkhir.Name = "dateTimeAkhir";
            this.dateTimeAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAkhir.TabIndex = 10;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(119, 86);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplier.TabIndex = 11;
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierAwal_SelectedIndexChanged);
            // 
            // radioButtonSupplier
            // 
            this.radioButtonSupplier.AutoSize = true;
            this.radioButtonSupplier.Location = new System.Drawing.Point(14, 89);
            this.radioButtonSupplier.Name = "radioButtonSupplier";
            this.radioButtonSupplier.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSupplier.TabIndex = 12;
            this.radioButtonSupplier.TabStop = true;
            this.radioButtonSupplier.Text = "Supplier";
            this.radioButtonSupplier.UseVisualStyleBackColor = true;
            // 
            // nota_beliBindingSource
            // 
            this.nota_beliBindingSource.DataMember = "nota_beli";
            this.nota_beliBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // pt_spss_kpDataSet
            // 
            this.pt_spss_kpDataSet.DataSetName = "pt_spss_kpDataSet";
            this.pt_spss_kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nota_beli_detailBindingSource
            // 
            this.nota_beli_detailBindingSource.DataMember = "nota_beli_detail";
            this.nota_beli_detailBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // nota_beliTableAdapter
            // 
            this.nota_beliTableAdapter.ClearBeforeFill = true;
            // 
            // nota_beli_detailTableAdapter
            // 
            this.nota_beli_detailTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(947, 33);
            this.label2.TabIndex = 67;
            this.label2.Text = "REPORT PEMBELIAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmReportNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 745);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonSupplier);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.dateTimeAkhir);
            this.Controls.Add(this.dateTimeAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonTanggal);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportNotaBeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmCetak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nota_beliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_beli_detailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource nota_beliBindingSource;
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private pt_spss_kpDataSetTableAdapters.nota_beliTableAdapter nota_beliTableAdapter;
        private System.Windows.Forms.Button buttonTampil;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton radioButtonTanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeAwal;
        private System.Windows.Forms.DateTimePicker dateTimeAkhir;
        private System.Windows.Forms.BindingSource nota_beli_detailBindingSource;
        private pt_spss_kpDataSetTableAdapters.nota_beli_detailTableAdapter nota_beli_detailTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.RadioButton radioButtonSupplier;
        private System.Windows.Forms.Label label2;
    }
}