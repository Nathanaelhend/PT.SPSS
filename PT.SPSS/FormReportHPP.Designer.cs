
namespace PT.SPSS
{
    partial class FormReportHPP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.total_hppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimeAkhir = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAwal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.total_hppTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.total_hppTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.total_hppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // total_hppBindingSource
            // 
            this.total_hppBindingSource.DataMember = "total_hpp";
            this.total_hppBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // pt_spss_kpDataSet
            // 
            this.pt_spss_kpDataSet.DataSetName = "pt_spss_kpDataSet";
            this.pt_spss_kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label2.Text = "REPORT ORDER POTONG/HPP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.total_hppBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportHPPOrderPotong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 163);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 494);
            this.reportViewer1.TabIndex = 70;
            // 
            // dateTimeAkhir
            // 
            this.dateTimeAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAkhir.Enabled = false;
            this.dateTimeAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAkhir.Location = new System.Drawing.Point(384, 82);
            this.dateTimeAkhir.Name = "dateTimeAkhir";
            this.dateTimeAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAkhir.TabIndex = 75;
            this.dateTimeAkhir.Value = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            // 
            // dateTimeAwal
            // 
            this.dateTimeAwal.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAwal.Enabled = false;
            this.dateTimeAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAwal.Location = new System.Drawing.Point(144, 82);
            this.dateTimeAwal.Name = "dateTimeAwal";
            this.dateTimeAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAwal.TabIndex = 74;
            this.dateTimeAwal.Value = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            this.dateTimeAwal.ValueChanged += new System.EventHandler(this.dateTimeAwal_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "S/d";
            // 
            // radioButtonTanggal
            // 
            this.radioButtonTanggal.AutoSize = true;
            this.radioButtonTanggal.Location = new System.Drawing.Point(39, 82);
            this.radioButtonTanggal.Name = "radioButtonTanggal";
            this.radioButtonTanggal.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTanggal.TabIndex = 72;
            this.radioButtonTanggal.TabStop = true;
            this.radioButtonTanggal.Text = "Range Tanggal";
            this.radioButtonTanggal.UseVisualStyleBackColor = true;
            this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(144, 125);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 71;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // total_hppTableAdapter
            // 
            this.total_hppTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportHPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 669);
            this.Controls.Add(this.dateTimeAkhir);
            this.Controls.Add(this.dateTimeAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonTanggal);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Name = "FormReportHPP";
            this.Load += new System.EventHandler(this.FormReportHPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.total_hppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimeAkhir;
        private System.Windows.Forms.DateTimePicker dateTimeAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTanggal;
        private System.Windows.Forms.Button buttonTampil;
        private System.Windows.Forms.BindingSource total_hppBindingSource;
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private pt_spss_kpDataSetTableAdapters.total_hppTableAdapter total_hppTableAdapter;
    }
}