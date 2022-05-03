
namespace PT.SPSS
{
    partial class FormDaftarSupplier
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
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.textBoxKriteria = new System.Windows.Forms.TextBox();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.panelSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSupplier.Controls.Add(this.textBoxKriteria);
            this.panelSupplier.Controls.Add(this.comboBoxKriteria);
            this.panelSupplier.Controls.Add(this.label2);
            this.panelSupplier.Location = new System.Drawing.Point(12, 55);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(611, 50);
            this.panelSupplier.TabIndex = 43;
            // 
            // textBoxKriteria
            // 
            this.textBoxKriteria.Location = new System.Drawing.Point(360, 15);
            this.textBoxKriteria.Name = "textBoxKriteria";
            this.textBoxKriteria.Size = new System.Drawing.Size(212, 20);
            this.textBoxKriteria.TabIndex = 2;
            // 
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Kode Supplier",
            "Nama Supplier",
            "Alamat",
            "Telepon"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(178, 15);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(154, 21);
            this.comboBoxKriteria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Bedasarkan : ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 33);
            this.label1.TabIndex = 42;
            this.label1.Text = "Daftar Supplier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Crimson;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(494, 397);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(129, 41);
            this.buttonKeluar.TabIndex = 48;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.Size = new System.Drawing.Size(611, 268);
            this.dataGridViewSupplier.TabIndex = 44;
            // 
            // FormDaftarSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Name = "FormDaftarSupplier";
            this.Text = "FormDaftarSupplier";
            this.Load += new System.EventHandler(this.FormDaftarSupplier_Load);
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.TextBox textBoxKriteria;
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
    }
}