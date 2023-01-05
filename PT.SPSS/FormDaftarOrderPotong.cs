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
    public partial class FormDaftarOrderPotong : Form
    {
        public FormDaftarOrderPotong()
        {
            InitializeComponent();
        }

        private void FormDaftarOrderPotong_Load(object sender, EventArgs e)
        {

        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if (dateTimeAwal.Enabled == true && dateTimeAkhir.Enabled == true)
            {
                this.reporthppTableAdapter.FilterDate(this.pt_spss_kpDataSet.reporthpp, dateTimeAwal.Value.Date, dateTimeAkhir.Value.Date);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Silahkan Plih Tanggal Awal dan Akhir");
            }
        }

        private void dateTimeAwal_ValueChanged(object sender, EventArgs e)
        {
            dateTimeAkhir.Enabled = true;
        }
    }
}
