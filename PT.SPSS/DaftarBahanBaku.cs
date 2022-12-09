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

            listBahanBaku = BahanBaku.BacaData("");

            DisplayOnDataGrid();
            //if (listBahanBaku.Count > 0)
            //{
            //    dataGridViewBarangBaku.DataSource = listBahanBaku;
            //}
            //else
            //{
            //    dataGridViewBarangBaku.DataSource = null;
            //}

            //dataGridViewBarangBaku.AllowUserToAddRows = false;
            //dataGridViewBarangBaku.ReadOnly = true;
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
                    dataGridViewBarangBaku.Rows.Add(b.Kode, b.Nama);    
                }

            }
            else
            {
                dataGridViewBarangBaku.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewBarangBaku.Columns.Add("KodeBahanJadi", "Kode Bahan Jadi");
            dataGridViewBarangBaku.Columns.Add("nama", "Nama");

            //dataGridViewBarangBaku.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dataGridViewBarangBaku.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            //dataGridViewBarangBaku.Columns["KodeBahanJadi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewBarangBaku.Columns["NamaBahanBaku"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewBarangBaku.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewBarangBaku.Columns["Satuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewBarangBaku.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewBarangBaku.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {

            listBahanBaku = BahanBaku.BacaData(textBoxKriteria.Text);

            //listBahanBaku = BahanBaku.BacaData(kriteria, textBoxKriteria.Text);

            DisplayOnDataGrid();
        }

        private void dataGridViewBarangBaku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewBarangBaku.Rows[e.RowIndex];
                // dapatkan form pembelian
                FormPembelian frmBeli = (FormPembelian)this.Owner;
                frmBeli.kodeBahanBaku = row.Cells["KodeBarangJadi"].Value.ToString();
                frmBeli.textBoxNamaBahan.Text = row.Cells["nama"].Value.ToString();
                this.Close();
            }
        }

        
    }
}
