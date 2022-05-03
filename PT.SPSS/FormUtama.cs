using SPSS_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT.SPSS
{
    public partial class FormUtama : System.Windows.Forms.Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;

            this.Enabled = false;

            FormLogin frmLogin = new FormLogin();
            frmLogin.Owner = this;
            frmLogin.Show();

            try
            {
                Koneksi koneksi = new Koneksi("localhost", "pt_spss", "root", "");
                MessageBox.Show("Koneksi berhasil");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message);
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormEntrySupplier"];

            if(frm == null)
            {
                FormEntrySupplier formSupplier = new FormEntrySupplier();
                formSupplier.MdiParent = this;
                formSupplier.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }
    }
}
