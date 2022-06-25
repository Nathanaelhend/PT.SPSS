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
    public partial class FormEntryHPP : Form
    {
        List<BahanBaku> listBhnBaku = new List<BahanBaku>();
        List<BarangJadi> listBrgJadi = new List<BarangJadi>();
        HPP hpp;

        public FormEntryHPP()
        {
            InitializeComponent();
        }

        private void FormEntryHPP_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimeDeadline.Value = DateTime.Now;

            listBhnBaku = BahanBaku.BacaData("", "");

            comboBoxKodeBB.DataSource = listBhnBaku;
            comboBoxKodeBB.DisplayMember = "nama";

            comboBoxKodeBB.DropDownStyle = ComboBoxStyle.DropDownList;

            listBrgJadi = BarangJadi.BacaData("", "");

            comboBoxBrgJadi.DataSource = listBrgJadi;
            comboBoxBrgJadi.DisplayMember = "nama";

            comboBoxBrgJadi.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewHPP.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewHPP.Columns.Add("kode", "Kode Bahan");
            dataGridViewHPP.Columns.Add("nama", "Nama Bahan");
            dataGridViewHPP.Columns.Add("quantity", "Qty");
            dataGridViewHPP.Columns.Add("harga", "Harga");
            dataGridViewHPP.Columns.Add("jumlah", "Jumlah");

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
            dataGridViewHPP.AllowUserToAddRows = false;
            dataGridViewHPP.ReadOnly = true;
        }

        private void comboBoxBrgJadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBrgJadi.SelectedIndex != -1)
            {
                BarangJadi brgJadiDipilih = (BarangJadi)comboBoxBrgJadi.SelectedItem;
                textBoxNamaBrg.Text = brgJadiDipilih.Nama;
            }
            else
            {
                textBoxNamaBrg.Text = "";
            }
        }

        private void comboBoxKodeBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKodeBB.SelectedIndex != -1)
            {
                BahanBaku bhnBakuDipilih = (BahanBaku)comboBoxKodeBB.SelectedItem;
                textBoxKeterangan.Text = bhnBakuDipilih.Nama;
                textBoxHarga.Text = bhnBakuDipilih.Harga.ToString();
            }
            else
            {
                textBoxKeterangan.Text = "";
                textBoxHarga.Text = "";
            }
        }


        private int HitungTotal()
        {
            int Total = 0;
            for (int i = 0; i < dataGridViewHPP.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewHPP.Rows[i].Cells["jumlah"].Value.ToString());
                Total += subTotal;
            }
            return Total;
        }

        private void textBoxQtyBB_KeyDown(object sender, KeyEventArgs e)
        {
            BahanBaku bahanDipilih = (BahanBaku)comboBoxKodeBB.SelectedItem;

           

            if (e.KeyCode == Keys.Enter)
            {
                textBoxTotal.Text = HPP.HitungTotalBB(int.Parse(textBoxHarga.Text), int.Parse(textBoxQtyBB.Text)).ToString();

                // textBoxJumlah.Text += textBoxTotal.Text;
                

                dataGridViewHPP.Rows.Add(bahanDipilih.Kode.ToString(), bahanDipilih.Nama.ToString(), textBoxQtyBB.Text, textBoxHarga.Text, textBoxTotal.Text);
            }
            textBoxJumlah.Text = HitungTotal().ToString();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                BarangJadi brgJadiDipilih = (BarangJadi)comboBoxBrgJadi.SelectedItem;
                BahanBaku bhnBakuDipilih = (BahanBaku)comboBoxKodeBB.SelectedItem;

                hpp = new HPP(textBoxNoBukti.Text, dateTimePicker.Value, dateTimeDeadline.Value, brgJadiDipilih,
                int.Parse(textBoxQty.Text), int.Parse(textBoxJumlah.Text), int.Parse(textBoxHPP.Text));


                for (int i = 0; i < dataGridViewHPP.Rows.Count; i++)
                {

                    string kodeBahan = dataGridViewHPP.Rows[i].Cells["kode"].Value.ToString();

                    int qty = int.Parse(dataGridViewHPP.Rows[i].Cells["quantity"].Value.ToString());
                    int harga = int.Parse(dataGridViewHPP.Rows[i].Cells["harga"].Value.ToString());
                    int jumlah = int.Parse(dataGridViewHPP.Rows[i].Cells["jumlah"].Value.ToString());
                    

                    hpp.TambahHPPDetil(kodeBahan, qty, harga, jumlah);
                }

                HPP.TambahData(hpp);

                MessageBox.Show("Data HPP berhasil tersimpan.", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan HPP. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void textBoxQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxHPP.Text = HPP.HitungHPP(int.Parse(textBoxJumlah.Text), int.Parse(textBoxQty.Text)).ToString();
            }
        }
    }
}
