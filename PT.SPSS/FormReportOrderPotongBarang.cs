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
    public partial class FormReportOrderPotongBarang : Form
    {
        public FormReportOrderPotongBarang()
        {
            InitializeComponent();
        }

        private void FormReportOrderPotongBarang_Load(object sender, EventArgs e)
        {

        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if (textBoxNoOrder.Text != "")
            {
                this.reporthppTableAdapter.FilterReport(this.pt_spss_kpDataSet.reporthpp, textBoxNoOrder.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Harap isi Nomor Bukti!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
