
namespace PT.SPSS
{
    partial class FormPenerimaan
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNoHPP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.textBoxNoBukti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dateTimePickerPenerimaan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTglHPP = new System.Windows.Forms.DateTimePicker();
            this.textBoxKodeBrgJadi = new System.Windows.Forms.TextBox();
            this.textBoxJmlhProduksi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNamaBrg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "Tanggal Order :";
            // 
            // textBoxNoHPP
            // 
            this.textBoxNoHPP.Location = new System.Drawing.Point(148, 127);
            this.textBoxNoHPP.Name = "textBoxNoHPP";
            this.textBoxNoHPP.Size = new System.Drawing.Size(214, 20);
            this.textBoxNoHPP.TabIndex = 108;
            this.textBoxNoHPP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNoHPP_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "No HPP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "Kode Barang :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Crimson;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(281, 328);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(81, 31);
            this.buttonKeluar.TabIndex = 104;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // textBoxNoBukti
            // 
            this.textBoxNoBukti.Location = new System.Drawing.Point(148, 60);
            this.textBoxNoBukti.Multiline = true;
            this.textBoxNoBukti.Name = "textBoxNoBukti";
            this.textBoxNoBukti.Size = new System.Drawing.Size(214, 26);
            this.textBoxNoBukti.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Tgl Penerimaan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "No Bukti :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 96;
            this.label1.Text = "Entry Penerimaan Produksi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Crimson;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(197, 328);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(81, 31);
            this.buttonSimpan.TabIndex = 97;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // dateTimePickerPenerimaan
            // 
            this.dateTimePickerPenerimaan.Location = new System.Drawing.Point(148, 97);
            this.dateTimePickerPenerimaan.Name = "dateTimePickerPenerimaan";
            this.dateTimePickerPenerimaan.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerPenerimaan.TabIndex = 111;
            // 
            // dateTimePickerTglHPP
            // 
            this.dateTimePickerTglHPP.Enabled = false;
            this.dateTimePickerTglHPP.Location = new System.Drawing.Point(148, 162);
            this.dateTimePickerTglHPP.Name = "dateTimePickerTglHPP";
            this.dateTimePickerTglHPP.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerTglHPP.TabIndex = 112;
            // 
            // textBoxKodeBrgJadi
            // 
            this.textBoxKodeBrgJadi.Enabled = false;
            this.textBoxKodeBrgJadi.Location = new System.Drawing.Point(148, 192);
            this.textBoxKodeBrgJadi.Multiline = true;
            this.textBoxKodeBrgJadi.Name = "textBoxKodeBrgJadi";
            this.textBoxKodeBrgJadi.Size = new System.Drawing.Size(214, 26);
            this.textBoxKodeBrgJadi.TabIndex = 113;
            // 
            // textBoxJmlhProduksi
            // 
            this.textBoxJmlhProduksi.Location = new System.Drawing.Point(148, 287);
            this.textBoxJmlhProduksi.Multiline = true;
            this.textBoxJmlhProduksi.Name = "textBoxJmlhProduksi";
            this.textBoxJmlhProduksi.Size = new System.Drawing.Size(214, 26);
            this.textBoxJmlhProduksi.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Jumlah Produksi :";
            // 
            // textBoxQty
            // 
            this.textBoxQty.Enabled = false;
            this.textBoxQty.Location = new System.Drawing.Point(148, 255);
            this.textBoxQty.Multiline = true;
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(214, 26);
            this.textBoxQty.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 116;
            this.label8.Text = "Qty Produksi :";
            // 
            // textBoxNamaBrg
            // 
            this.textBoxNamaBrg.Enabled = false;
            this.textBoxNamaBrg.Location = new System.Drawing.Point(148, 224);
            this.textBoxNamaBrg.Multiline = true;
            this.textBoxNamaBrg.Name = "textBoxNamaBrg";
            this.textBoxNamaBrg.Size = new System.Drawing.Size(214, 26);
            this.textBoxNamaBrg.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 118;
            this.label9.Text = "Nama Barang :";
            // 
            // FormPenerimaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 373);
            this.Controls.Add(this.textBoxNamaBrg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxJmlhProduksi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKodeBrgJadi);
            this.Controls.Add(this.dateTimePickerTglHPP);
            this.Controls.Add(this.dateTimePickerPenerimaan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNoHPP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.textBoxNoBukti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSimpan);
            this.Name = "FormPenerimaan";
            this.Load += new System.EventHandler(this.FormPenerimaan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNoHPP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxNoBukti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DateTimePicker dateTimePickerPenerimaan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglHPP;
        private System.Windows.Forms.TextBox textBoxKodeBrgJadi;
        private System.Windows.Forms.TextBox textBoxJmlhProduksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNamaBrg;
        private System.Windows.Forms.Label label9;
    }
}