
namespace PT.SPSS
{
    partial class PenerimaanProduksi
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxNoOrder = new System.Windows.Forms.TextBox();
            this.textBoxNoBuktiTerima = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerPenerimaan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTglOrder = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxKodeBrgJadi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxHasilProduksi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Crimson;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(320, 281);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(81, 31);
            this.buttonKeluar.TabIndex = 101;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Crimson;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(231, 281);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(81, 31);
            this.buttonHapus.TabIndex = 100;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Crimson;
            this.buttonBatal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.White;
            this.buttonBatal.Location = new System.Drawing.Point(144, 281);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(81, 31);
            this.buttonBatal.TabIndex = 99;
            this.buttonBatal.Text = "BATAL";
            this.buttonBatal.UseVisualStyleBackColor = false;
            // 
            // textBoxNoOrder
            // 
            this.textBoxNoOrder.Location = new System.Drawing.Point(160, 119);
            this.textBoxNoOrder.Multiline = true;
            this.textBoxNoOrder.Name = "textBoxNoOrder";
            this.textBoxNoOrder.Size = new System.Drawing.Size(241, 26);
            this.textBoxNoOrder.TabIndex = 98;
            this.textBoxNoOrder.TextChanged += new System.EventHandler(this.textBoxNoOrder_TextChanged);
            // 
            // textBoxNoBuktiTerima
            // 
            this.textBoxNoBuktiTerima.Location = new System.Drawing.Point(160, 61);
            this.textBoxNoBuktiTerima.Multiline = true;
            this.textBoxNoBuktiTerima.Name = "textBoxNoBuktiTerima";
            this.textBoxNoBuktiTerima.Size = new System.Drawing.Size(240, 26);
            this.textBoxNoBuktiTerima.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 96;
            this.label8.Text = "No Order Potong :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 95;
            this.label9.Text = "No Bukti :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(389, 33);
            this.label10.TabIndex = 93;
            this.label10.Text = "Entry Kategori";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Crimson;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(57, 281);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(81, 31);
            this.buttonSimpan.TabIndex = 94;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "Tgl Penerimaan :";
            // 
            // dateTimePickerPenerimaan
            // 
            this.dateTimePickerPenerimaan.Location = new System.Drawing.Point(160, 93);
            this.dateTimePickerPenerimaan.Name = "dateTimePickerPenerimaan";
            this.dateTimePickerPenerimaan.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerPenerimaan.TabIndex = 103;
            // 
            // dateTimePickerTglOrder
            // 
            this.dateTimePickerTglOrder.Enabled = false;
            this.dateTimePickerTglOrder.Location = new System.Drawing.Point(160, 151);
            this.dateTimePickerTglOrder.Name = "dateTimePickerTglOrder";
            this.dateTimePickerTglOrder.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerTglOrder.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 104;
            this.label12.Text = "Tgl Order :";
            // 
            // textBoxKodeBrgJadi
            // 
            this.textBoxKodeBrgJadi.Enabled = false;
            this.textBoxKodeBrgJadi.Location = new System.Drawing.Point(159, 177);
            this.textBoxKodeBrgJadi.Multiline = true;
            this.textBoxKodeBrgJadi.Name = "textBoxKodeBrgJadi";
            this.textBoxKodeBrgJadi.Size = new System.Drawing.Size(241, 26);
            this.textBoxKodeBrgJadi.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 16);
            this.label13.TabIndex = 106;
            this.label13.Text = "Kode Barang Jadi :";
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Enabled = false;
            this.textBoxNamaBarang.Location = new System.Drawing.Point(159, 209);
            this.textBoxNamaBarang.Multiline = true;
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(241, 26);
            this.textBoxNamaBarang.TabIndex = 109;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 16);
            this.label14.TabIndex = 108;
            this.label14.Text = "Nama Barang Jadi :";
            // 
            // textBoxHasilProduksi
            // 
            this.textBoxHasilProduksi.Location = new System.Drawing.Point(159, 241);
            this.textBoxHasilProduksi.Multiline = true;
            this.textBoxHasilProduksi.Name = "textBoxHasilProduksi";
            this.textBoxHasilProduksi.Size = new System.Drawing.Size(241, 26);
            this.textBoxHasilProduksi.TabIndex = 111;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 16);
            this.label15.TabIndex = 110;
            this.label15.Text = "Hasil Produksi :";
            // 
            // PenerimaanProduksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 322);
            this.Controls.Add(this.textBoxHasilProduksi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxNamaBarang);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxKodeBrgJadi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerTglOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerPenerimaan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.textBoxNoOrder);
            this.Controls.Add(this.textBoxNoBuktiTerima);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSimpan);
            this.Name = "PenerimaanProduksi";
            this.Text = "PenerimaanProduksi";
            this.Load += new System.EventHandler(this.PenerimaanProduksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxNoOrder;
        private System.Windows.Forms.TextBox textBoxNoBuktiTerima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerPenerimaan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxKodeBrgJadi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxHasilProduksi;
        private System.Windows.Forms.Label label15;
    }
}