using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPSS_LIB;

namespace PT.SPSS
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Height = 50 + panelLogin.Height;
            txtServer.Text = "localhost";
            txtDatabase.Text = "pt_spss";
        }

        private void linkLabelSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = 50 + panelLogin.Height + panelSetting.Height;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != "" && txtDatabase.Text != "")
            {
                this.Height = 50 + panelLogin.Height;
            }   
            else
            {
                MessageBox.Show("Nama Server dan nama database tidak boleh kosong", "Kesalahan");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text != "")
                {
                    Koneksi koneksi = new Koneksi(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);

                    MessageBox.Show("Login Berhasil.", "Informasi");

                    this.Owner.Enabled = true;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
