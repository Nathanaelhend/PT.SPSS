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
    public partial class FormReportDetilNota : Form
    {
        List<Supplier> listSupplier = new List<Supplier>();
        List<BahanBaku> listBhnBaku = new List<BahanBaku>();
        public FormReportDetilNota()
        {
            InitializeComponent();
        }

        private void FormReportDetilNota_Load(object sender, EventArgs e)
        {
            listSupplier = Supplier.BacaData("", "");


            comboBoxSupplier.DataSource = listSupplier;
            comboBoxSupplier.DisplayMember = "nama";
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

            listBhnBaku = BahanBaku.BacaData("");


            comboBoxBhnBaku.DataSource = listBhnBaku;
            comboBoxBhnBaku.DisplayMember = "nama";
            comboBoxBhnBaku.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if (radioButtonTanggal.Checked == true)
            {
                this.nota_beli_detailTableAdapter.FilterDate(this.pt_spss_kpDataSet.nota_beli_detail, dateTimeAwal.Value, dateTimeAkhir.Value);

                this.reportViewer1.RefreshReport();
            }

            else if (radioButtonSupplier.Checked == true)
            {
                Supplier supplier = (Supplier)comboBoxSupplier.SelectedItem;

                this.nota_beli_detailTableAdapter.FilterSupplier(this.pt_spss_kpDataSet.nota_beli_detail, supplier.Nama);
                this.reportViewer1.RefreshReport();
            }

            else if (radioButtonBhnBaku.Checked == true)
            {
                BahanBaku bhnBaku = (BahanBaku)comboBoxBhnBaku.SelectedItem;

                this.nota_beli_detailTableAdapter.FilterBahan(this.pt_spss_kpDataSet.nota_beli_detail, bhnBaku.Nama);
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
    }
}
