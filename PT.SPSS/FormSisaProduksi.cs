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
    public partial class FormSisaProduksi : Form
    {
        public FormSisaProduksi()
        {
            InitializeComponent();
        }

        private void FormSisaProduksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pt_spss_kpDataSet.sisa_produksi' table. You can move, or remove it, as needed.
            //this.sisa_produksiTableAdapter.Fill(this.pt_spss_kpDataSet.sisa_produksi);
            this.sisa_produksiTableAdapter.Fill(this.pt_spss_kpDataSet.sisa_produksi);
            this.reportViewer1.RefreshReport();

        }
    }
}
