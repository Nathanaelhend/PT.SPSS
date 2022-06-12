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
    public partial class DaftarNotaDetail : Form
    {
        List<Pembelian> listPembelian = new List<Pembelian>();
        DataView dv;
        public DaftarNotaDetail()
        {
            InitializeComponent();
        }

        private void panelSupplier_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TampilGrid()
        {
            listPembelian = Pembelian.BacaData("", "");

            if (listPembelian.Count > 0)
            {
                dataGridViewPembelian.DataSource = listPembelian;
            }
            else
            {
                dataGridViewPembelian.DataSource = null;
            }

            dataGridViewPembelian.AllowUserToAddRows = false;
            dataGridViewPembelian.ReadOnly = true;
        }

        private void DaftarNotaDetail_Load(object sender, EventArgs e)
        {
            //FormatDataGrid();
            TampilGrid();

            
        }

        private void FormatDataGrid()
        {
            dataGridViewPembelian.Columns.Add("noNota", "Nomor Nota");
            dataGridViewPembelian.Columns.Add("NamaBahanBaku", "Nama");
            dataGridViewPembelian.Columns.Add("qty", "qty");
            dataGridViewPembelian.Columns.Add("harga", "harga");
            dataGridViewPembelian.Columns.Add("tanggal", "Tanggal");
            dataGridViewPembelian.Columns.Add("supplier", "Supplier");
            dataGridViewPembelian.Columns.Add("jumlah", "jumlah");
            dataGridViewPembelian.Columns.Add("diskon", "diskon");
            dataGridViewPembelian.Columns.Add("total", "total");

            dataGridViewPembelian.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewPembelian.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            

        }

        private void dateTimePickerDateAkhir_ValueChanged(object sender, EventArgs e)
        {
            //listPembelian = Pembelian.BacaDataTanggal(dateTimePickerDateAwal.Value.Date.ToString(), dateTimePickerDateAkhir.Value.Date.ToString());

            //if (listPembelian.Count > 0)
            //{
            //    dataGridViewPembelian.DataSource = listPembelian;
            //}
            //else
            //{
            //    dataGridViewPembelian.DataSource = null;
            //}

            //TampilGrid();
        }

        private void dateTimePickerDateAwal_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateAkhir.Enabled = true;
        }

        private void radioButtonRangeTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDateAwal.Enabled = true;
        }

        private void radioButtonNomorNota_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNomorNota.Enabled = true;
        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            DateTime tglAwal = dateTimePickerDateAwal.Value.Date;
            DateTime tglAkhir = dateTimePickerDateAkhir.Value.Date;


            dv.RowFilter = String.Format("tanggal > #{0:dd/MM/yyyy}# AND tanggal < #{1:dd/MM/yyyy}#", tglAwal, tglAkhir);
            dataGridViewPembelian.DataSource = dv;
        }
    }
}
