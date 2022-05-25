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
    public partial class FormPembelian : Form
    {
        List<Supplier> listSupplier = new List<Supplier>();
        List<BahanBaku> listBhnBaku = new List<BahanBaku>();
        Pembelian pembelian;
        //string date = "";

        public FormPembelian()
        {
            InitializeComponent();
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;

            listSupplier = Supplier.BacaData("", "");

            comboBoxSupplier.DataSource = listSupplier;
            comboBoxSupplier.DisplayMember = "nama";

            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

            listBhnBaku = BahanBaku.BacaData("", "");

            comboBoxBahanBaku.DataSource = listBhnBaku;
            comboBoxBahanBaku.DisplayMember = "nama";

            comboBoxBahanBaku.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();
        }


        private void textBoxHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxJumlah.Text = Pembelian.HitungJumlah(int.Parse(textBoxQty.Text), int.Parse(textBoxHarga.Text)).ToString();

                textBoxDiscPrs.Focus();
            }
        }

        private int HitungTotal()
        {
            int Total = 0;
            for (int i = 0; i < dataGridViewPembelian.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewPembelian.Rows[i].Cells["total_harga"].Value.ToString());
                Total += subTotal;
            }
            return Total;
        }

        private void textBoxDiscPrs_KeyDown(object sender, KeyEventArgs e)
        {
            BahanBaku bahanDipilih = (BahanBaku)comboBoxBahanBaku.SelectedItem;

            if (e.KeyCode == Keys.Enter)
            {
                textBoxDiscRp.Text = Pembelian.HitungDisc(int.Parse(textBoxJumlah.Text), int.Parse(textBoxDiscPrs.Text)).ToString();
                textBoxTotal.Text = Pembelian.HitungTotal(int.Parse(textBoxJumlah.Text), int.Parse(textBoxDiscRp.Text)).ToString();

                dataGridViewPembelian.Rows.Add(bahanDipilih.Nama.ToString(),textBoxQty.Text, textBoxHarga.Text, textBoxJumlah.Text, textBoxDiscPrs.Text, textBoxDiscRp.Text, textBoxTotal.Text);

                textBoxJmlhAll.Text = HitungTotal().ToString();

                textBoxQty.Focus();
                textBoxQty.Text = "";
                textBoxHarga.Text = "";
                textBoxJumlah.Text = "";
                textBoxDiscPrs.Text = "";
                textBoxDiscRp.Text = "";
                textBoxTotal.Text = "";
            }
        }

        private void textBoxDiscPrsAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxDiscRpAll.Text = Pembelian.HitungDisc(int.Parse(textBoxJmlhAll.Text), int.Parse(textBoxDiscPrsAll.Text)).ToString();
                textBoxDpp.Text = Pembelian.HitungTotal(int.Parse(textBoxJmlhAll.Text), int.Parse(textBoxDiscRpAll.Text)).ToString();

            }
        }

        private void textBoxPPnPrs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPPnRp.Text = Pembelian.HitungPPn(int.Parse(textBoxDpp.Text), int.Parse(textBoxPPnPrs.Text)).ToString();

                textBoxNetto.Text = Pembelian.HitungNetto(int.Parse(textBoxDpp.Text), int.Parse(textBoxPPnRp.Text)).ToString();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplierDipilih = (Supplier)comboBoxSupplier.SelectedItem;

                pembelian = new Pembelian(textBoxNoNota.Text, dateTimePicker.Value, supplierDipilih, int.Parse(textBoxJumlah.Text), double.Parse(textBoxDiscPrs.Text), int.Parse(textBoxDiscRp.Text), int.Parse(textBoxDpp.Text), double.Parse(textBoxPPnPrs.Text), int.Parse(textBoxPPnRp.Text), int.Parse(textBoxNetto.Text));

                List<BahanBaku> listBahanBaku = new List<BahanBaku>();

                for (int i = 0; i < dataGridViewPembelian.Rows.Count; i++)
                {
                    string namaBahan = dataGridViewPembelian.Rows[i].Cells["nama"].Value.ToString();
                    listBahanBaku = BahanBaku.BacaData("B.kode", namaBahan);

                    int qty = int.Parse(dataGridViewPembelian.Rows[i].Cells["quantity"].Value.ToString());
                    int harga = int.Parse(dataGridViewPembelian.Rows[i].Cells["harga"].Value.ToString());
                    int jumlah = int.Parse(dataGridViewPembelian.Rows[i].Cells["jumlah"].Value.ToString());
                    double discPrs = double.Parse(dataGridViewPembelian.Rows[i].Cells["diskon_persen"].Value.ToString());
                    int discRph = int.Parse(dataGridViewPembelian.Rows[i].Cells["diskon_rph"].Value.ToString());
                    int total = int.Parse(dataGridViewPembelian.Rows[i].Cells["total_harga"].Value.ToString());

                    pembelian.TambahPembelianDetil(listBahanBaku[0], qty, harga, jumlah,discPrs,discRph,total);
                }

                Pembelian.TambahData(pembelian);

                MessageBox.Show("Data nota Beli berhasil tersimpan.", "Informasi");

                //panggil event handler buttonCetak_Click
                //buttonCetak_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nota. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPembelian.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPembelian.Columns.Add("nama", "Nama Bahan");
            dataGridViewPembelian.Columns.Add("quantity", "Qty");
            dataGridViewPembelian.Columns.Add("harga", "Harga");
            dataGridViewPembelian.Columns.Add("jumlah", "Jumlah");
            dataGridViewPembelian.Columns.Add("diskon_persen", "Diskon %");
            dataGridViewPembelian.Columns.Add("diskon_rph", "Diskon");
            dataGridViewPembelian.Columns.Add("total_harga", "Total Harga");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            //dataGridViewPembelian.Columns["KodeTipe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewPembelian.Columns["NamaTipe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewPembelian.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewPembelian.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewPembelian.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            ////agar harga jual, jumlah, subTotal rata kanan
            //dataGridViewPembelian.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewPembelian.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewPembelian.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            ////agar harga jual dan subtotal ditampilkan dengan format pemisah ribuan (1000 delimeter)
            //dataGridViewPembelian.Columns["HargaJual"].DefaultCellStyle.Format = "#,###";
            //dataGridViewPembelian.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";

            //agar datagrid tidak bisa diganti-ganti oleh user
            dataGridViewPembelian.AllowUserToAddRows = false;
            dataGridViewPembelian.ReadOnly = true;
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            if (comboBoxSupplier.SelectedIndex != -1)
            {
                Supplier supplierDipilih = (Supplier)comboBoxSupplier.SelectedItem;
                textBoxAlamat.Text = supplierDipilih.Alamat;
                textBoxKota.Text = supplierDipilih.Kota;
            }
            else
            {
                textBoxAlamat.Text = "";
            }
        }
    }
}
