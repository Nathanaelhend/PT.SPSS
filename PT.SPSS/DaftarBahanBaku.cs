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
    public partial class DaftarBahanBaku : Form
    {
        List<BahanBaku> listBahanBaku = new List<BahanBaku>();
        public DaftarBahanBaku()
        {
            InitializeComponent();
        }

        private void DaftarBahanBaku_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listBahanBaku = BahanBaku.BacaData("", "");

            if (listBahanBaku.Count > 0)
            {
                dataGridViewBahanBaku.DataSource = listBahanBaku;
            }
            else
            {
                dataGridViewBahanBaku.DataSource = null;
            }

            dataGridViewBahanBaku.AllowUserToAddRows = false;
            dataGridViewBahanBaku.ReadOnly = true;
        }

        private void DisplayOnDataGrid()
        {
            if (listBahanBaku.Count > 0)
            {
                //tampilkan di datagridview
                //dataGridViewBarang.DataSource = listBarang; --> tidak bisa digunakan

                //kosongi datagridviewBarang
                dataGridViewBarangBaku.Rows.Clear();
                foreach (BahanBaku b in listBahanBaku)
                {
                    //menambahkan data barang satu persatu ke datagridview
                    dataGridViewBarangBaku.Rows.Add(b.KodeBarang, b.Barcode, b.Nama, b.HargaJual, b.Stok, b.Kategori.KodeKategori, b.Kategori.Nama);
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

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if(comboBoxKriteria.Text == "Kode")
            {
                kriteria = "b.Kode";
            }
            else if(comboBoxKriteria.Text == "Nama")
            {
                kriteria = "b.nama";
            }
            else if(comboBoxKriteria.Text == "Satuan")
            {
                kriteria = "b.satuan";
            }
            else if (comboBoxKriteria.Text == "Kategori")
            {
                kriteria = "kbb.nama";
            }

            listBahanBaku = listBahanBaku.BacaData(kriteria, textBoxKriteria.Text);

            DisplayOnDataGrid();
        }
    }
}
