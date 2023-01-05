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
    public partial class FormReportHPP : Form
    {
        public FormReportHPP()
        {
            InitializeComponent();
        }

        private void FormReportHPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pt_spss_kpDataSet.total_hpp' table. You can move, or remove it, as needed.
            //this.total_hppTableAdapter.Fill(this.pt_spss_kpDataSet.total_hpp);

        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if (radioButtonTanggal.Checked == true)
            {
                this.total_hppTableAdapter.FilterDate(this.pt_spss_kpDataSet.total_hpp, dateTimeAwal.Value, dateTimeAkhir.Value.Date);

                MessageBox.Show(dateTimeAwal.Value.Date.ToString());
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.total_hppTableAdapter.Fill(this.pt_spss_kpDataSet.total_hpp);
                this.reportViewer1.RefreshReport();
            }
        }


        private void radioButtonTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeAwal.Enabled = true;
           
        }

        private void dateTimeAwal_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimeAkhir.Enabled = true;
        }
    }
}
