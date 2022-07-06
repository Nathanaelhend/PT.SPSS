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
    public partial class DaftarBrgJadi : Form
    {
        List<BarangJadi> listBahanJadi = new List<BarangJadi>();
        public DaftarBrgJadi()
        {
            InitializeComponent();
        }

        private void DaftarBahanJadi_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listBahanJadi = BarangJadi.BacaData("", "");

            DisplayOnDataGrid();
            //if (listBahanJadi.Count > 0)
            //{
            //    dataGridViewBarangJadi.DataSource = listBahanJadi;
            //}
            //else
            //{
            //    dataGridViewBarangJadi.DataSource = null;
            //}

            //dataGridViewBarangJadi.AllowUserToAddRows = false;
            //dataGridViewBarangJadi.ReadOnly = true;
        }

        private void DisplayOnDataGrid()
        {
            if (listBahanJadi.Count > 0)
            {
                //tampilkan di datagridview
                //dataGridViewBarang.DataSource = listBarang; --> tidak bisa digunakan

                //kosongi datagridviewBarang
                dataGridViewBarangJadi.Rows.Clear();
                foreach (BarangJadi b in listBahanJadi)
                {
                    //menambahkan data barang satu persatu ke datagridview
                    dataGridViewBarangJadi.Rows.Add(b.KodeBarang, b.Nama, b.Harga, b.Satuan, b.KategoriBarang.Kode, b.KategoriBarang.KeteranganBarang);
                }

            }
            else
            {
                dataGridViewBarangJadi.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewBarangJadi.Columns.Add("KodeBahanBaku", "Kode Bahan Baku");
            dataGridViewBarangJadi.Columns.Add("NamaBahanBaku", "Nama");
            dataGridViewBarangJadi.Columns.Add("Harga", "Harga");
            dataGridViewBarangJadi.Columns.Add("Satuan", "Satuan");
            dataGridViewBarangJadi.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewBarangJadi.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewBarangJadi.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBarangJadi.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewBarangJadi.Columns["KodeBahanBaku"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangJadi.Columns["NamaBahanBaku"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangJadi.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangJadi.Columns["Satuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangJadi.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarangJadi.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxKriteria.Text == "Kode")
            {
                //kriteria = "b.kodeBarang";
                listBahanJadi = BarangJadi.BacaData("kodeBarang", textBoxKriteria.Text);
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                listBahanJadi = BarangJadi.BacaData("nama", textBoxKriteria.Text);
            }
            else if (comboBoxKriteria.Text == "Satuan")
            {
                //kriteria = "b.satuan";
                listBahanJadi = BarangJadi.BacaData("satuan", textBoxKriteria.Text);
            }

            DisplayOnDataGrid();
        }


    }
}
