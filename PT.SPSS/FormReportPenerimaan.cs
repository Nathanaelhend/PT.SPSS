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
    public partial class FormReportPenerimaan : Form
    {
        List<BarangJadi> listBrgJadi = new List<BarangJadi>();
        public FormReportPenerimaan()
        {
            InitializeComponent();
        }

        private void FormReportPenerimaan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pt_spss_kpDataSet.penerimaan_produksi' table. You can move, or remove it, as needed.
            //this.penerimaan_produksiTableAdapter.Fill(this.pt_spss_kpDataSet.penerimaan_produksi);
            listBrgJadi = BarangJadi.BacaData("", "");


            comboBoxBarang.DataSource = listBrgJadi;
            comboBoxBarang.DisplayMember = "nama";
            comboBoxBarang.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if(radioButtonTanggal.Checked == true)
            {
                this.penerimaan_produksiTableAdapter.filterDate(this.pt_spss_kpDataSet.penerimaan_produksi, dateTimeAwal.Value, dateTimeAkhir.Value);
                this.reportViewer1.RefreshReport();
            }

            else if(radioButtonBarang.Checked == true)
            {
                BarangJadi brgJadi = (BarangJadi)comboBoxBarang.SelectedItem;

                this.penerimaan_produksiTableAdapter.filterBarang(this.pt_spss_kpDataSet.penerimaan_produksi, brgJadi.Nama);
                this.reportViewer1.RefreshReport();
            }
        }

        private void radioButtonTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeAwal.Enabled = true;
        }

        private void dateTimeAwal_ValueChanged(object sender, EventArgs e)
        {
            dateTimeAkhir.Enabled = true;
        }

        private void radioButtonSupplier_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBarang.Enabled = true;
        }
    }
}
