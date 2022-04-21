
namespace PT.SPSS
{
    partial class FormEntrySupplier
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKodeSupplier = new System.Windows.Forms.TextBox();
            this.textBoxNamaSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInputSupplier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "ENTRY SUPPLIER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnInputSupplier);
            this.panel1.Controls.Add(this.textBoxKota);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxAlamat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxNamaSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxKodeSupplier);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 217);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Supplier  ";
            // 
            // textBoxKodeSupplier
            // 
            this.textBoxKodeSupplier.Location = new System.Drawing.Point(136, 12);
            this.textBoxKodeSupplier.Multiline = true;
            this.textBoxKodeSupplier.Name = "textBoxKodeSupplier";
            this.textBoxKodeSupplier.Size = new System.Drawing.Size(213, 25);
            this.textBoxKodeSupplier.TabIndex = 1;
            // 
            // textBoxNamaSupplier
            // 
            this.textBoxNamaSupplier.Location = new System.Drawing.Point(136, 43);
            this.textBoxNamaSupplier.Multiline = true;
            this.textBoxNamaSupplier.Name = "textBoxNamaSupplier";
            this.textBoxNamaSupplier.Size = new System.Drawing.Size(213, 25);
            this.textBoxNamaSupplier.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nama Supplier ";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(136, 74);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(213, 48);
            this.textBoxAlamat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Alamat ";
            // 
            // textBoxKota
            // 
            this.textBoxKota.Location = new System.Drawing.Point(136, 128);
            this.textBoxKota.Multiline = true;
            this.textBoxKota.Name = "textBoxKota";
            this.textBoxKota.Size = new System.Drawing.Size(213, 25);
            this.textBoxKota.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kota            ";
            // 
            // btnInputSupplier
            // 
            this.btnInputSupplier.BackColor = System.Drawing.Color.Salmon;
            this.btnInputSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputSupplier.Location = new System.Drawing.Point(274, 172);
            this.btnInputSupplier.Name = "btnInputSupplier";
            this.btnInputSupplier.Size = new System.Drawing.Size(75, 31);
            this.btnInputSupplier.TabIndex = 8;
            this.btnInputSupplier.Text = "INPUT";
            this.btnInputSupplier.UseVisualStyleBackColor = false;
            // 
            // FormEntrySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 274);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "FormEntrySupplier";
            this.Text = "Entry Supplier";
            this.Load += new System.EventHandler(this.FormEntrySupplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInputSupplier;
        private System.Windows.Forms.TextBox textBoxKota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNamaSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKodeSupplier;
        private System.Windows.Forms.Label label5;
    }
}