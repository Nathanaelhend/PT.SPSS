
namespace PT.SPSS
{
    partial class FormReportDetilNota
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nota_beli_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.dateTimeAkhir = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAwal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxBhnBaku = new System.Windows.Forms.ComboBox();
            this.nota_beliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nota_beliTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.nota_beliTableAdapter();
            this.nota_beli_detailTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.nota_beli_detailTableAdapter();
            this.radioButtonSupplier = new System.Windows.Forms.RadioButton();
            this.radioButtonBhnBaku = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nota_beli_detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_beliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nota_beli_detailBindingSource
            // 
            this.nota_beli_detailBindingSource.DataMember = "nota_beli_detail";
            this.nota_beli_detailBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // pt_spss_kpDataSet
            // 
            this.pt_spss_kpDataSet.DataSetName = "pt_spss_kpDataSet";
            this.pt_spss_kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Enabled = false;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(141, 86);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSupplier.TabIndex = 20;
            // 
            // dateTimeAkhir
            // 
            this.dateTimeAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAkhir.Enabled = false;
            this.dateTimeAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAkhir.Location = new System.Drawing.Point(381, 60);
            this.dateTimeAkhir.Name = "dateTimeAkhir";
            this.dateTimeAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAkhir.TabIndex = 19;
            this.dateTimeAkhir.Value = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            // 
            // dateTimeAwal
            // 
            this.dateTimeAwal.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAwal.Enabled = false;
            this.dateTimeAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAwal.Location = new System.Drawing.Point(141, 60);
            this.dateTimeAwal.Name = "dateTimeAwal";
            this.dateTimeAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAwal.TabIndex = 18;
            this.dateTimeAwal.Value = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            this.dateTimeAwal.ValueChanged += new System.EventHandler(this.dateTimeAwal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "S/d";
            // 
            // radioButtonTanggal
            // 
            this.radioButtonTanggal.AutoSize = true;
            this.radioButtonTanggal.Location = new System.Drawing.Point(36, 60);
            this.radioButtonTanggal.Name = "radioButtonTanggal";
            this.radioButtonTanggal.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTanggal.TabIndex = 16;
            this.radioButtonTanggal.TabStop = true;
            this.radioButtonTanggal.Text = "Range Tanggal";
            this.radioButtonTanggal.UseVisualStyleBackColor = true;
            this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(141, 150);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 15;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSetDetail";
            reportDataSource3.Value = this.nota_beli_detailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportPembelianDetail.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 191);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 501);
            this.reportViewer1.TabIndex = 14;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // comboBoxBhnBaku
            // 
            this.comboBoxBhnBaku.Enabled = false;
            this.comboBoxBhnBaku.FormattingEnabled = true;
            this.comboBoxBhnBaku.Location = new System.Drawing.Point(141, 113);
            this.comboBoxBhnBaku.Name = "comboBoxBhnBaku";
            this.comboBoxBhnBaku.Size = new System.Drawing.Size(200, 21);
            this.comboBoxBhnBaku.TabIndex = 22;
            // 
            // nota_beliBindingSource
            // 
            this.nota_beliBindingSource.DataMember = "nota_beli";
            this.nota_beliBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // nota_beliTableAdapter
            // 
            this.nota_beliTableAdapter.ClearBeforeFill = true;
            // 
            // nota_beli_detailTableAdapter
            // 
            this.nota_beli_detailTableAdapter.ClearBeforeFill = true;
            // 
            // radioButtonSupplier
            // 
            this.radioButtonSupplier.AutoSize = true;
            this.radioButtonSupplier.Location = new System.Drawing.Point(36, 90);
            this.radioButtonSupplier.Name = "radioButtonSupplier";
            this.radioButtonSupplier.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSupplier.TabIndex = 24;
            this.radioButtonSupplier.TabStop = true;
            this.radioButtonSupplier.Text = "Supplier";
            this.radioButtonSupplier.UseVisualStyleBackColor = true;
            this.radioButtonSupplier.CheckedChanged += new System.EventHandler(this.radioButtonSupplier_CheckedChanged);
            // 
            // radioButtonBhnBaku
            // 
            this.radioButtonBhnBaku.AutoSize = true;
            this.radioButtonBhnBaku.Location = new System.Drawing.Point(36, 116);
            this.radioButtonBhnBaku.Name = "radioButtonBhnBaku";
            this.radioButtonBhnBaku.Size = new System.Drawing.Size(84, 17);
            this.radioButtonBhnBaku.TabIndex = 25;
            this.radioButtonBhnBaku.TabStop = true;
            this.radioButtonBhnBaku.Text = "Bahan Baku";
            this.radioButtonBhnBaku.UseVisualStyleBackColor = true;
            this.radioButtonBhnBaku.CheckedChanged += new System.EventHandler(this.radioButtonBhnBaku_CheckedChanged);
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
            this.label2.Text = "REPORT PEMBELIAN DETAIL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReportDetilNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 709);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonBhnBaku);
            this.Controls.Add(this.radioButtonSupplier);
            this.Controls.Add(this.comboBoxBhnBaku);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.dateTimeAkhir);
            this.Controls.Add(this.dateTimeAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonTanggal);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportDetilNota";
            this.Text = "FormReportDetilNota";
            this.Load += new System.EventHandler(this.FormReportDetilNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nota_beli_detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_beliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nota_beliBindingSource;
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private System.Windows.Forms.BindingSource nota_beli_detailBindingSource;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.DateTimePicker dateTimeAkhir;
        private System.Windows.Forms.DateTimePicker dateTimeAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTanggal;
        private System.Windows.Forms.Button buttonTampil;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pt_spss_kpDataSetTableAdapters.nota_beliTableAdapter nota_beliTableAdapter;
        private pt_spss_kpDataSetTableAdapters.nota_beli_detailTableAdapter nota_beli_detailTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxBhnBaku;
        private System.Windows.Forms.RadioButton radioButtonSupplier;
        private System.Windows.Forms.RadioButton radioButtonBhnBaku;
        private System.Windows.Forms.Label label2;
    }
}