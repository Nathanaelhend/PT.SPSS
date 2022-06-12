
namespace PT.SPSS
{
    partial class DaftarNotaDetail
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
            this.dataGridViewPembelian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNomorNota = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeTanggal = new System.Windows.Forms.RadioButton();
            this.textBoxNomorNota = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateAwal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateAkhir = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTampil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembelian)).BeginInit();
            this.panelSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPembelian
            // 
            this.dataGridViewPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembelian.Location = new System.Drawing.Point(10, 196);
            this.dataGridViewPembelian.Name = "dataGridViewPembelian";
            this.dataGridViewPembelian.RowHeadersWidth = 51;
            this.dataGridViewPembelian.Size = new System.Drawing.Size(766, 346);
            this.dataGridViewPembelian.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cari Bedasarkan : ";
            // 
            // radioButtonNomorNota
            // 
            this.radioButtonNomorNota.AutoSize = true;
            this.radioButtonNomorNota.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNomorNota.Location = new System.Drawing.Point(32, 41);
            this.radioButtonNomorNota.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNomorNota.Name = "radioButtonNomorNota";
            this.radioButtonNomorNota.Size = new System.Drawing.Size(116, 22);
            this.radioButtonNomorNota.TabIndex = 6;
            this.radioButtonNomorNota.TabStop = true;
            this.radioButtonNomorNota.Text = "Nomor Nota";
            this.radioButtonNomorNota.UseVisualStyleBackColor = true;
            this.radioButtonNomorNota.CheckedChanged += new System.EventHandler(this.radioButtonNomorNota_CheckedChanged);
            // 
            // radioButtonRangeTanggal
            // 
            this.radioButtonRangeTanggal.AutoSize = true;
            this.radioButtonRangeTanggal.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRangeTanggal.Location = new System.Drawing.Point(32, 72);
            this.radioButtonRangeTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRangeTanggal.Name = "radioButtonRangeTanggal";
            this.radioButtonRangeTanggal.Size = new System.Drawing.Size(136, 22);
            this.radioButtonRangeTanggal.TabIndex = 7;
            this.radioButtonRangeTanggal.TabStop = true;
            this.radioButtonRangeTanggal.Text = "Range Tanggal";
            this.radioButtonRangeTanggal.UseVisualStyleBackColor = true;
            this.radioButtonRangeTanggal.CheckedChanged += new System.EventHandler(this.radioButtonRangeTanggal_CheckedChanged);
            // 
            // textBoxNomorNota
            // 
            this.textBoxNomorNota.Enabled = false;
            this.textBoxNomorNota.Location = new System.Drawing.Point(166, 40);
            this.textBoxNomorNota.Name = "textBoxNomorNota";
            this.textBoxNomorNota.Size = new System.Drawing.Size(122, 25);
            this.textBoxNomorNota.TabIndex = 8;
            // 
            // dateTimePickerDateAwal
            // 
            this.dateTimePickerDateAwal.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDateAwal.Enabled = false;
            this.dateTimePickerDateAwal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateAwal.Location = new System.Drawing.Point(166, 74);
            this.dateTimePickerDateAwal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateAwal.Name = "dateTimePickerDateAwal";
            this.dateTimePickerDateAwal.Size = new System.Drawing.Size(122, 22);
            this.dateTimePickerDateAwal.TabIndex = 9;
            this.dateTimePickerDateAwal.ValueChanged += new System.EventHandler(this.dateTimePickerDateAwal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "hingga";
            // 
            // dateTimePickerDateAkhir
            // 
            this.dateTimePickerDateAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDateAkhir.Enabled = false;
            this.dateTimePickerDateAkhir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateAkhir.Location = new System.Drawing.Point(360, 74);
            this.dateTimePickerDateAkhir.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateAkhir.Name = "dateTimePickerDateAkhir";
            this.dateTimePickerDateAkhir.Size = new System.Drawing.Size(122, 22);
            this.dateTimePickerDateAkhir.TabIndex = 11;
            this.dateTimePickerDateAkhir.ValueChanged += new System.EventHandler(this.dateTimePickerDateAkhir_ValueChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(32, 107);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 22);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(766, 33);
            this.label3.TabIndex = 43;
            this.label3.Text = "Daftar Nota Beli";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSupplier.Controls.Add(this.buttonTampil);
            this.panelSupplier.Controls.Add(this.textBox1);
            this.panelSupplier.Controls.Add(this.label1);
            this.panelSupplier.Controls.Add(this.radioButtonNomorNota);
            this.panelSupplier.Controls.Add(this.radioButton3);
            this.panelSupplier.Controls.Add(this.radioButtonRangeTanggal);
            this.panelSupplier.Controls.Add(this.dateTimePickerDateAkhir);
            this.panelSupplier.Controls.Add(this.textBoxNomorNota);
            this.panelSupplier.Controls.Add(this.label2);
            this.panelSupplier.Controls.Add(this.dateTimePickerDateAwal);
            this.panelSupplier.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSupplier.Location = new System.Drawing.Point(10, 44);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(766, 145);
            this.panelSupplier.TabIndex = 44;
            this.panelSupplier.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSupplier_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 25);
            this.textBox1.TabIndex = 13;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Crimson;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(646, 548);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(129, 41);
            this.buttonKeluar.TabIndex = 49;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(541, 74);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 14;
            this.buttonTampil.Text = "TAMPIL";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // DaftarNotaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 600);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPembelian);
            this.Name = "DaftarNotaDetail";
            this.Text = "Daftar Nota";
            this.Load += new System.EventHandler(this.DaftarNotaDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembelian)).EndInit();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNomorNota;
        private System.Windows.Forms.RadioButton radioButtonRangeTanggal;
        private System.Windows.Forms.TextBox textBoxNomorNota;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAkhir;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTampil;
    }
}