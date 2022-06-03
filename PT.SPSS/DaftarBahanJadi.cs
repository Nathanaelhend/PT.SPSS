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
    public partial class DaftarBahanJadi : Form
    {
        List<BahanJadi> listBahanJadi = new List<BahanJadi>();
        public DaftarBahanJadi()
        {
            InitializeComponent();
        }

        private void DaftarBahanJadi_Load(object sender, EventArgs e)
        {
            listBahanJadi = BahanJadi.BacaData("", "");

            if (listBahanJadi.Count > 0)
            {
                dataGridViewBahanJadi.DataSource = listBahanJadi;
            }
            else
            {
                dataGridViewBahanJadi.DataSource = null;
            }

            dataGridViewBahanJadi.AllowUserToAddRows = false;
            dataGridViewBahanJadi.ReadOnly = true;
        }

        private void DisplayOnDataGrid()
        {
            if (listBahanJadi.Count > 0)
            {
                //tampilkan di datagridview
                //dataGridViewBarang.DataSource = listBarang; --> tidak bisa digunakan

                //kosongi datagridviewBarang
                dataGridViewBarangJadi.Rows.Clear();
                foreach (BahanJadi b in listBahanJadi)
                {
                    //menambahkan data barang satu persatu ke datagridview
                    dataGridViewBarangJadi.Rows.Add(b.KodeBarang, b.Barcode, b.Nama, b.HargaJual, b.Stok, b.Kategori.KodeKategori, b.Kategori.Nama);
                }

            }
            else
            {
                dataGridViewBarangBaku.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewBarangBaku.Columns.Add("KodeBahanBaku", "Kode Bahan Baku");
            dataGridViewBarangBaku.Columns.Add("NamaBahanBaku", "Nama");
            dataGridViewBarangBaku.Columns.Add("Harga", "Harga");
            dataGridViewBarangBaku.Columns.Add("Satuan", "Satuan");
            dataGridViewBarangBaku.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewBarangBaku.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewBarangBaku.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBarangBaku.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewBarangBaku.Columns["KodeBahanBaku"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangBaku.Columns["NamaBahanBaku"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangBaku.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangBaku.Columns["Satuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangBaku.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangBaku.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
    }
}
