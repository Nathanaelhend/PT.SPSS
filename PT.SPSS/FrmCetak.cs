using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PT.SPSS
{
    public partial class FrmCetak : Form
    {
        public FrmCetak()
        {
            //listPembelian = pembelian;
            InitializeComponent();
        }

        private void FrmCetak_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked == true)
            {
                this.nota_beliTableAdapter.Fill(this.pt_spss_kpDataSet.nota_beli);

                this.reportViewer1.RefreshReport();
            }

            else if(radioButtonTanggal.Checked == true)
            { 
                this.nota_beliTableAdapter.filterDate(this.pt_spss_kpDataSet.nota_beli, dateTimeAwal.Value, dateTimeAkhir.Value);

                this.reportViewer1.RefreshReport();
            }
        }

        private void dateTimeAwal_ValueChanged(object sender, EventArgs e)
        {
            dateTimeAkhir.Enabled = true;
        }

        private void radioButtonTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeAwal.Enabled = true;
        }
    }
}
