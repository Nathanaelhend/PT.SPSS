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
        List<BahanBaku> listBhnBakuHrg = new List<BahanBaku>();


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

            listBhnBaku = BahanBaku.BacaData("");

            listBhnBakuHrg = BahanBaku.BacaLastPrice("", "");

            listBrgJadi = BarangJadi.BacaData("");

            //comboBoxBrgJadi.DataSource = listBrgJadi;
            //comboBoxBrgJadi.DisplayMember = "nama";

            //comboBoxBrgJadi.DropDownStyle = ComboBoxStyle.DropDownList;

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
            dataGridViewHPP.Columns.Add("hargaNett", "Harga");
            dataGridViewHPP.Columns.Add("jumlah", "Jumlah");

            dataGridViewHPP.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewHPP.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewHPP.Columns["Jumlah"].DefaultCellStyle.Format = "#,##0.00";

            //agar datagrid tidak bisa diganti-ganti oleh user
            dataGridViewHPP.AllowUserToAddRows = false;
            dataGridViewHPP.ReadOnly = true;
        }

        private void FormatDataGrid2()
        {
            //kosongi semua kolom di datagridview
            dataGridViewBrgJadi.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewBrgJadi.Columns.Add("kodeBarang", "Kode");
            dataGridViewBrgJadi.Columns.Add("nama", "Nama Barang");


            //agar datagrid tidak bisa diganti-ganti oleh user
            dataGridViewBrgJadi.AllowUserToAddRows = false;
            dataGridViewBrgJadi.ReadOnly = true;
        }

        private void FormatDataGrid3()
        {
            //kosongi semua kolom di datagridview
            dataGridViewBB.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewBB.Columns.Add("kode", "Kode");
            dataGridViewBB.Columns.Add("nama", "Nama Barang");
            dataGridViewBB.Columns.Add("hargaNett", "Harga");


            //agar datagrid tidak bisa diganti-ganti oleh user
            dataGridViewBB.AllowUserToAddRows = false;
            dataGridViewBB.ReadOnly = true;
        }

        private void TampilDataGrid2()
        {


            if (listBrgJadi.Count > 0)
            {
                foreach (BarangJadi bj in listBrgJadi)
                {
                    dataGridViewBrgJadi.Rows.Add(bj.KodeBarang, bj.Nama);
                }
            }
            else
            {
                dataGridViewBrgJadi.DataSource = null;
            }
        }

        private void TampilDataGrid3()
        {

            
            if (listBhnBakuHrg.Count > 0)
            {
                foreach (BahanBaku b in listBhnBakuHrg)
                {
                    dataGridViewBB.Rows.Add(b.Kode, b.Nama, b.Harga);
                }
            }
            else
            {
                dataGridViewBB.DataSource = null;
            }
        }


        private void DisplayOnDataGrid()
        {
            if (listBrgJadi.Count > 0)
            {
                //kosongi datagridviewBarang
                dataGridViewBrgJadi.Rows.Clear();
                foreach (BarangJadi bj in listBrgJadi)
                {
                    //menambahkan data barang satu persatu ke datagridview
                    dataGridViewBrgJadi.Rows.Add(bj.KodeBarang, bj.Nama);
                }

            }
            else
            {
                dataGridViewBrgJadi.DataSource = null;
            }
        }

        private void DisplayOnDataGrid2()
        {
            if (listBhnBakuHrg.Count > 0)
            {
                //kosongi datagridviewBarang
                dataGridViewBB.Rows.Clear();
                foreach (BahanBaku b in listBhnBakuHrg)
                {
                    //menambahkan data barang satu persatu ke datagridview
                    dataGridViewBB.Rows.Add(b.Kode, b.Nama, b.Harga);
                }

            }
            else
            {
                dataGridViewBB.DataSource = null;
            }
        }


        private double HitungTotal()
        {
            double Total = 0;
            for (int i = 0; i < dataGridViewHPP.Rows.Count; i++)
            {
                double subTotal = double.Parse(dataGridViewHPP.Rows[i].Cells["jumlah"].Value.ToString());
                Total += subTotal;
            }
            return Total;
        }

        private void textBoxQtyBB_KeyDown(object sender, KeyEventArgs e)
        {
            //BahanBaku bahanDipilih = (BahanBaku)comboBoxKodeBB.SelectedItem;
            

            if (e.KeyCode == Keys.Enter)
            {
                textBoxTotal.Text = HPP.HitungTotalBB(double.Parse(textBoxHarga.Text), double.Parse(textBoxQtyBB.Text)).ToString();

                //textBoxJumlah.Text += textBoxTotal.Text;
                

                dataGridViewHPP.Rows.Add(textBoxKodeBB.Text, textBoxKeterangan.Text, textBoxQtyBB.Text, textBoxHarga.Text, textBoxTotal.Text);
                textBoxJumlah.Text = HitungTotal().ToString();
                textBoxKodeBB.Text = "";
                textBoxKeterangan.Text = "";
                textBoxQtyBB.Text = "";
                textBoxHarga.Text = "";
                textBoxTotal.Text = "";
            }
            
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNoBukti.Text != "" && textBoxQty.Text != "" && textBoxKodeBrgJadi.Text != "" && textBoxJumlah.Text != "" && textBoxHPP.Text != "")
            {
                try
                {
                    //BarangJadi brgJadiDipilih = (BarangJadi)comboBoxBrgJadi.SelectedItem;
                    //BahanBaku bhnBakuDipilih = (BahanBaku)comboBoxKodeBB.SelectedItem;

                    hpp = new HPP(textBoxNoBukti.Text, dateTimePicker.Value, dateTimeDeadline.Value, textBoxKodeBrgJadi.Text,
                    double.Parse(textBoxQty.Text), double.Parse(textBoxJumlah.Text), double.Parse(textBoxHPP.Text));


                    for (int i = 0; i < dataGridViewHPP.Rows.Count; i++)
                    {

                        string kodeBahan = dataGridViewHPP.Rows[i].Cells["kode"].Value.ToString();
                        //string namaBahan = dataGridViewHPP.Rows[i].Cells["nama"].Value.ToString();
                        double qty = double.Parse(dataGridViewHPP.Rows[i].Cells["quantity"].Value.ToString());
                        double harga = double.Parse(dataGridViewHPP.Rows[i].Cells["hargaNett"].Value.ToString());
                        double jumlah = double.Parse(dataGridViewHPP.Rows[i].Cells["jumlah"].Value.ToString());


                        hpp.TambahHPPDetil(kodeBahan, qty, harga, jumlah);
                    }

                    HPP.TambahData(hpp);

                    MessageBox.Show("Data HPP berhasil tersimpan.", "Informasi");
                    textBoxNoBukti.Text = "";
                    dateTimePicker.Value = DateTime.Now;
                    dateTimeDeadline.Value = DateTime.Now;
                    textBoxQty.Text = "";
                    textBoxJumlah.Text = "";
                    textBoxHPP.Text = "";
                    textBoxHarga.Text = "";
                    textBoxQty.Text = "";
                    textBoxTotal.Text = "";
                    textBoxNoBukti.Focus();
                    dataGridViewHPP.Columns.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan HPP. Pesan kesalahan : " + ex.Message, "Kesalahan");
                }
            }
            else
            {
                MessageBox.Show("Harap isi data!");
            }
        }

        private void textBoxQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxHPP.Text = HPP.HitungHPP(double.Parse(textBoxJumlah.Text), double.Parse(textBoxQty.Text)).ToString();
            }
        }

        private void textBoxNamaBrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKodeBrgJadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                panelBrgJadi.Visible = true;
                FormatDataGrid2();
                listBrgJadi = BarangJadi.BacaData("");
                TampilDataGrid2();
                textBoxNama.Focus();
            }
        }

        private void dataGridViewBrgJadi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewBrgJadi.Rows[e.RowIndex];

                textBoxKodeBrgJadi.Text = row.Cells["kodeBarang"].Value.ToString();
                textBoxNamaBrg.Text = row.Cells["nama"].Value.ToString();
            }
            panelBrgJadi.Visible = false;
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            listBrgJadi = BarangJadi.BacaData(textBoxNama.Text);
            DisplayOnDataGrid();
        }

        private void textBoxKodeBB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                panelBB.Visible = true;
                FormatDataGrid3();
                listBhnBaku = BahanBaku.BacaData("");
                TampilDataGrid3();
                textBoxNamaBB.Focus();
            }
        }

        private void dataGridViewBB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewBB.Rows[e.RowIndex];

                textBoxKodeBB.Text = row.Cells["kode"].Value.ToString();
                textBoxKeterangan.Text = row.Cells["nama"].Value.ToString();
                textBoxHarga.Text = row.Cells["hargaNett"].Value.ToString();
            }
            panelBB.Visible = false;
        }

        private void textBoxNamaBB_TextChanged(object sender, EventArgs e)
        {
            listBhnBakuHrg = BahanBaku.BacaData(textBoxNama.Text);
            DisplayOnDataGrid2();
        }
    }
}
