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
        public string kodeBahanBaku = "";
        public FormPembelian()
        {
            InitializeComponent();
        }

        public void FormPembelian_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            textBoxNoNota.Focus();

            listSupplier = Supplier.BacaData("", "");

            //comboBoxSupplier.DataSource = listSupplier;
            //comboBoxSupplier.DisplayMember = "nama";

            //comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

            listBhnBaku = BahanBaku.BacaData2("");

            FormatDataGrid();
        }

        private void FormatDataGrid2()
        {
            dataGridViewBhnBaku.Columns.Clear();

            dataGridViewBhnBaku.Columns.Add("kode", "Kode");
            dataGridViewBhnBaku.Columns.Add("nama", "Nama");

            dataGridViewBhnBaku.Columns["Kode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBhnBaku.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBhnBaku.Columns["Kode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBhnBaku.Columns["Nama"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewBhnBaku.AllowUserToAddRows = false;
            dataGridViewBhnBaku.ReadOnly = true;

        }

        private void TampilDataGrid2()
        {


            if (listBhnBaku.Count > 0)
            {
                foreach (BahanBaku b in listBhnBaku)
                {
                    dataGridViewBhnBaku.Rows.Add(b.Kode, b.Nama);
                }
            }
            else
            {
                dataGridViewBhnBaku.DataSource = null;
            }
        }

        private void FormatDataGrid3()
        {
            dataGridViewSupplier.Columns.Clear();

            dataGridViewSupplier.Columns.Add("kodeSupplier", "Kode");
            dataGridViewSupplier.Columns.Add("nama", "Nama");
            dataGridViewSupplier.Columns.Add("alamat", "Alamat");
            dataGridViewSupplier.Columns.Add("kota", "Kota");

            dataGridViewSupplier.AllowUserToAddRows = false;
            dataGridViewSupplier.ReadOnly = true;

        }

        private void TampilDataGrid3()
        {


            if (listSupplier.Count > 0)
            {
                foreach (Supplier s in listSupplier)
                {
                    dataGridViewSupplier.Rows.Add(s.KodeSupplier, s.Nama, s.Alamat, s.Kota);
                }
            }
            else
            {
                dataGridViewSupplier.DataSource = null;
            }
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
            if (e.KeyCode == Keys.Enter)
            {
                textBoxDiscRp.Text = Pembelian.HitungDisc(int.Parse(textBoxJumlah.Text), int.Parse(textBoxDiscPrs.Text)).ToString();
                textBoxTotal.Text = Pembelian.HitungTotal(int.Parse(textBoxJumlah.Text), int.Parse(textBoxDiscRp.Text)).ToString();

                //dataGridViewPembelian.Rows.Add(textBoxKode.Text, textBoxNamaBahan.Text, textBoxQty.Text, textBoxHarga.Text, textBoxDiscPrs.Text, textBoxDiscRp.Text, textBoxTotal.Text);
                //textBoxQty.Text = "";
                //textBoxHarga.Text = "";
                //textBoxJumlah.Text = "";
                //textBoxDiscPrs.Text = "";
                //textBoxDiscRp.Text = "";
                //textBoxTotal.Text = "";
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
            if (textBoxNoNota.Text != "" && textBoxSupplier.Text != "" & textBoxDiscPrsAll.Text != "" && textBoxDiscRpAll.Text != "" && textBoxDpp.Text != "" && textBoxNetto.Text != "")
            {
                try
                {

                    pembelian = new Pembelian(textBoxNoNota.Text, dateTimePicker.Value, textBoxSupplier.Text, int.Parse(textBoxJmlhAll.Text),
                    double.Parse(textBoxDiscPrsAll.Text), int.Parse(textBoxDiscRpAll.Text), int.Parse(textBoxDpp.Text), double.Parse(textBoxPPnPrs.Text), int.Parse(textBoxPPnRp.Text), int.Parse(textBoxNetto.Text));


                    for (int i = 0; i < dataGridViewPembelian.Rows.Count; i++)
                    {

                        string kodeBahan = dataGridViewPembelian.Rows[i].Cells["kode"].Value.ToString();

                        int qty = int.Parse(dataGridViewPembelian.Rows[i].Cells["quantity"].Value.ToString());
                        int harga = int.Parse(dataGridViewPembelian.Rows[i].Cells["harga"].Value.ToString());
                        int jumlah = int.Parse(dataGridViewPembelian.Rows[i].Cells["jumlah"].Value.ToString());
                        double discPrs = double.Parse(dataGridViewPembelian.Rows[i].Cells["diskon_persen"].Value.ToString());
                        int discRph = int.Parse(dataGridViewPembelian.Rows[i].Cells["diskon_rph"].Value.ToString());
                        int total = int.Parse(dataGridViewPembelian.Rows[i].Cells["total_harga"].Value.ToString());

                        int dpp = (total * int.Parse(textBoxDiscPrsAll.Text)) / 100;

                        dpp = total - dpp;

                        int hargaNett = (dpp + (dpp * int.Parse(textBoxPPnPrs.Text) / 100)) / qty;

                        pembelian.TambahPembelianDetil(kodeBahan, qty, harga, jumlah, hargaNett, discPrs, discRph, total);
                    }

                    Pembelian.TambahData(pembelian);


                    MessageBox.Show("Data nota Beli berhasil tersimpan.", "Informasi");

                    textBoxNoNota.Text = "";
                    textBoxNamaBahan.Text = "";
                    dateTimePicker.Value = DateTime.Now;
                    textBoxQty.Text = "";
                    textBoxHarga.Text = "";
                    textBoxJumlah.Text = "";
                    textBoxDiscPrs.Text = "";
                    textBoxDiscRp.Text = "";
                    textBoxTotal.Text = "";
                    textBoxSupplier.Text = "";
                    textBoxNamaSupp.Text = "";
                    textBoxAlamat.Text = "";
                    textBoxJmlhAll.Text = "";
                    textBoxDiscPrsAll.Text = "";
                    textBoxDiscRpAll.Text = "";
                    textBoxDpp.Text = "";
                    textBoxPPnPrs.Text = "";
                    textBoxPPnRp.Text = "";
                    textBoxNetto.Text = "";
                    textBoxNoNota.Focus();
                    dataGridViewPembelian.Columns.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan nota. Pesan kesalahan : " + ex.Message, "Kesalahan");
                }
            }
            else
            {
                MessageBox.Show("Harap Isi Data!");
            }
        }
            

        private void DisplayOnDataGrid()
        {
            if (listBhnBaku.Count > 0)
            {
                //kosongi datagridviewBarang
                dataGridViewBhnBaku.Rows.Clear();
                foreach (BahanBaku b in listBhnBaku)
                {
                    //menambahkan data barang satu persatu ke datagridview
                    dataGridViewBhnBaku.Rows.Add(b.Kode, b.Nama);
                }

            }
            else
            {
                dataGridViewBhnBaku.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPembelian.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPembelian.Columns.Add("kode", "Kode Bahan");
            dataGridViewPembelian.Columns.Add("nama", "Nama Bahan");
            dataGridViewPembelian.Columns.Add("quantity", "Qty");
            dataGridViewPembelian.Columns.Add("harga", "Harga");
            dataGridViewPembelian.Columns.Add("jumlah", "Jumlah");
            dataGridViewPembelian.Columns.Add("diskon_persen", "Diskon %");
            dataGridViewPembelian.Columns.Add("diskon_rph", "Diskon");
            dataGridViewPembelian.Columns.Add("total_harga", "Total Harga");

            //agar datagrid tidak bisa diganti-ganti oleh user
            dataGridViewPembelian.AllowUserToAddRows = false;
            dataGridViewPembelian.ReadOnly = true;
        }

        

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonBatal_Click(object sender, EventArgs e)
        {
            
            textBoxNoNota.Text = "";
            textBoxNamaBahan.Text = "";
            dateTimePicker.Value = DateTime.Now;
            textBoxQty.Text = "";
            textBoxHarga.Text = "";
            textBoxJumlah.Text = "";
            textBoxDiscPrs.Text = "";
            textBoxDiscRp.Text = "";
            textBoxTotal.Text = "";
            textBoxJmlhAll.Text = "";
            textBoxDiscPrsAll.Text = "";
            textBoxDiscRpAll.Text = "";
            textBoxDpp.Text = "";
            textBoxPPnPrs.Text = "";
            textBoxPPnRp.Text = "";
            textBoxNetto.Text = "";
            textBoxNoNota.Focus();
            dataGridViewPembelian.Columns.Clear();
            FormatDataGrid();
        }

        private void comboBoxBahanBaku_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxQty.Text = "";
            //textBoxHarga.Text = "";
            //textBoxJumlah.Text = "";
            //textBoxDiscPrs.Text = "";
            //textBoxDiscRp.Text = "";
            //textBoxTotal.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //BahanBaku bahanDipilih = (BahanBaku)comboBoxBahanBaku.SelectedItem;

            dataGridViewPembelian.Rows.Add(textBoxKode.Text, textBoxNamaBahan.Text, textBoxQty.Text, textBoxHarga.Text, textBoxJumlah.Text, textBoxDiscPrs.Text, textBoxDiscRp.Text, textBoxTotal.Text);

            textBoxJmlhAll.Text = HitungTotal().ToString();
            textBoxKode.Text = "";
            textBoxNamaBahan.Text = "";
            textBoxQty.Text = "";
            textBoxHarga.Text = "";
            textBoxJumlah.Text = "";
            textBoxDiscPrs.Text = "";
            textBoxDiscRp.Text = "";
            textBoxTotal.Text = "";
            textBoxKode.Focus();

        }

        private void buttonBatalBhnBaku_Click(object sender, EventArgs e)
        {
            textBoxNamaBahan.Text = "";
            textBoxQty.Text = "";
            textBoxHarga.Text = "";
            textBoxJumlah.Text = "";
            textBoxDiscPrs.Text = "";
            textBoxDiscRp.Text = "";
            textBoxSupplier.Text = "";
            textBoxNamaSupp.Text = "";
            textBoxAlamat.Text = "";
            textBoxTotal.Text = "";
            textBoxQty.Focus();
        }



        private void dataGridViewBhnBaku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewBhnBaku.Rows[e.RowIndex];

                textBoxKode.Text = row.Cells["kode"].Value.ToString();
                textBoxNamaBahan.Text = row.Cells["nama"].Value.ToString();
            }
            panelBahan.Visible = false;
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            listBhnBaku = BahanBaku.BacaData2(textBoxNama.Text);
            DisplayOnDataGrid();
        }

        private void textBoxNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panelBahan.Visible = false;
            }
        }

        private void textBoxKode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                panelBahan.Visible = true;
                FormatDataGrid2();
                listBhnBaku = BahanBaku.BacaData2("");
                TampilDataGrid2();
                textBoxNama.Focus();
            }
        }

        private void textBoxSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                panelSupp.Visible = true;
                FormatDataGrid3();
                listSupplier = Supplier.BacaData("", "");
                TampilDataGrid3();
                textBoxSuppGrid.Focus();
            }
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewSupplier.Rows[e.RowIndex];

                textBoxSupplier.Text = row.Cells["kodeSupplier"].Value.ToString();
                textBoxNamaSupp.Text = row.Cells["nama"].Value.ToString();
                textBoxAlamat.Text = row.Cells["alamat"].Value.ToString();
                textBoxKota.Text = row.Cells["kota"].Value.ToString();
            }
            panelSupp.Visible = false;
        }

        private void textBoxSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBhnBaku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
