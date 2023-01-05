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
using SPSS_LIB;

namespace PT.SPSS
{
    public partial class FrmReportNotaBeli : Form
    {
        List<Supplier> listSupplier = new List<Supplier>();
        public FrmReportNotaBeli()
        {
            //listPembelian = pembelian;
            InitializeComponent();
        }

        private void FrmCetak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pt_spss_kpDataSet.nota_beli' table. You can move, or remove it, as needed.
            //this.nota_beliTableAdapter.Fill(this.pt_spss_kpDataSet.nota_beli);
            // TODO: This line of code loads data into the 'pt_spss_kpDataSet.nota_beli' table. You can move, or remove it, as needed.
            //this.nota_beliTableAdapter.Fill(this.pt_spss_kpDataSet.nota_beli);
            // TODO: This line of code loads data into the 'pt_spss_kpDataSet.nota_beli_detail' table. You can move, or remove it, as needed.
            //this.nota_beli_detailTableAdapter.Fill(this.pt_spss_kpDataSet.nota_beli_detail);

            listSupplier = Supplier.BacaData("", "");


            comboBoxSupplier.DataSource = listSupplier;
            comboBoxSupplier.DisplayMember = "nama";
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
         
            if(radioButtonTanggal.Checked == true) 
            { 
                this.nota_beliTableAdapter.filterDate(this.pt_spss_kpDataSet.nota_beli, dateTimeAwal.Value, dateTimeAkhir.Value);

                this.reportViewer1.RefreshReport();
            }
            
            else if(radioButtonSupplier.Checked == true)
            {
                Supplier supplier = (Supplier)comboBoxSupplier.SelectedItem;

                this.nota_beliTableAdapter.filterSupplier(this.pt_spss_kpDataSet.nota_beli, supplier.Nama);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.nota_beliTableAdapter.Fill(this.pt_spss_kpDataSet.nota_beli);
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

        private void comboBoxSupplierAwal_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimeAwal_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimeAkhir.Enabled = true;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {

        }
    }
}
