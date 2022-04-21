
namespace PT.SPSS
{
    partial class FormLogin
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
            this.panelSetting = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabelSetting = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSetting.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.label3);
            this.panelSetting.Controls.Add(this.txtServer);
            this.panelSetting.Controls.Add(this.btnSimpan);
            this.panelSetting.Controls.Add(this.txtDatabase);
            this.panelSetting.Controls.Add(this.label4);
            this.panelSetting.Location = new System.Drawing.Point(12, 167);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(307, 108);
            this.panelSetting.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server :";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(110, 13);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(170, 20);
            this.txtServer.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(110, 65);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(110, 39);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '*';
            this.txtDatabase.Size = new System.Drawing.Size(170, 20);
            this.txtDatabase.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Database :";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.linkLabelSetting);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnKeluar);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(307, 149);
            this.panelLogin.TabIndex = 9;
            // 
            // linkLabelSetting
            // 
            this.linkLabelSetting.AutoSize = true;
            this.linkLabelSetting.Location = new System.Drawing.Point(17, 115);
            this.linkLabelSetting.Name = "linkLabelSetting";
            this.linkLabelSetting.Size = new System.Drawing.Size(96, 13);
            this.linkLabelSetting.TabIndex = 6;
            this.linkLabelSetting.TabStop = true;
            this.linkLabelSetting.Text = "Pengaturan Server";
            this.linkLabelSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSetting_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(205, 70);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "KELUAR";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(110, 70);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 291);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkLabelSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
    }
}

