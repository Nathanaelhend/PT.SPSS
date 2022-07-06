
namespace PT.SPSS
{
    partial class FormSisaProduksi
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pt_spss_kpDataSet = new PT.SPSS.pt_spss_kpDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.sisa_produksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisa_produksiTableAdapter = new PT.SPSS.pt_spss_kpDataSetTableAdapters.sisa_produksiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisa_produksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_SisaProduksi";
            reportDataSource1.Value = this.sisa_produksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PT.SPSS.ReportSisaProduksi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 501);
            this.reportViewer1.TabIndex = 69;
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
            this.label2.TabIndex = 77;
            this.label2.Text = "REPORT SISA PRODUKSI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sisa_produksiBindingSource
            // 
            this.sisa_produksiBindingSource.DataMember = "sisa_produksi";
            this.sisa_produksiBindingSource.DataSource = this.pt_spss_kpDataSet;
            // 
            // sisa_produksiTableAdapter
            // 
            this.sisa_produksiTableAdapter.ClearBeforeFill = true;
            // 
            // FormSisaProduksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 598);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Name = "FormSisaProduksi";
            this.Load += new System.EventHandler(this.FormSisaProduksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt_spss_kpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisa_produksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pt_spss_kpDataSet pt_spss_kpDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sisa_produksiBindingSource;
        private pt_spss_kpDataSetTableAdapters.sisa_produksiTableAdapter sisa_produksiTableAdapter;
    }
}