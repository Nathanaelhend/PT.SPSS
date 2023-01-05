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
    public partial class FormEntryBrgJadi : Form
    {
        List<KategoriBarang> listCatBrgJadi = new List<KategoriBarang>();
        List<BarangJadi> listBrgJadi = new List<BarangJadi>();
        public bool baru;

        public FormEntryBrgJadi()
        {
            InitializeComponent();
        }


        private void FormEntryBrgJadi_Load(object sender, EventArgs e)
        {
            textBoxKodeBrgJadi.Focus();
            listCatBrgJadi = KategoriBarang.BacaData("", "");
            comboKatBrgJadi.DataSource = listCatBrgJadi;
            comboKatBrgJadi.DisplayMember = "keteranganBarang";
            comboKatBrgJadi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxKodeBrgJadi.Text = "";
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxSatuan.Text = "";
            textBoxKodeBrgJadi.Focus();
        }

        private void comboKatBrgJadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboKatBrgJadi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (textBoxKodeBrgJadi.Text != "" && textBoxNama.Text != "" && textBoxHarga.Text != "" && textBoxSatuan.Text != "")
            {
                try
                {
                    KategoriBarang kb = (KategoriBarang)comboKatBrgJadi.SelectedItem;
                    BarangJadi b = new BarangJadi(textBoxKodeBrgJadi.Text, textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxSatuan.Text, kb);
                    BarangJadi.HapusData(b);
                    MessageBox.Show("Hapus data berhasil.", "Informasi");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus supplier. Pesan Kesalahan : " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Harap Isi Data!");
            }

            textBoxKodeBrgJadi.Text = "";
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxSatuan.Text = "";
            textBoxKodeBrgJadi.Focus();
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            if (baru == true)
            {
                if (textBoxKodeBrgJadi.Text != "" && textBoxNama.Text != "" && textBoxHarga.Text != "" && textBoxSatuan.Text != "")
                {
                    try
                    {
                        KategoriBarang kb = (KategoriBarang)comboKatBrgJadi.SelectedItem;
                        BarangJadi b = new BarangJadi(textBoxKodeBrgJadi.Text, textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxSatuan.Text, kb);
                        BarangJadi.TambahData(b);

                        MessageBox.Show("Data Berhasil Disimpan");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal Menyimpan. Kesalahan : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Harap Isi Data!");
                }
                
            }

            else
            {
                if (textBoxKodeBrgJadi.Text != "" && textBoxNama.Text != "" && textBoxHarga.Text != "" && textBoxSatuan.Text != "")
                {
                    try
                    {
                        KategoriBarang kb = (KategoriBarang)comboKatBrgJadi.SelectedItem;
                        BarangJadi b = new BarangJadi(textBoxKodeBrgJadi.Text, textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxSatuan.Text, kb);
                        BarangJadi.UbahData(b);
                        MessageBox.Show("Pengubahan berhasil.", "Informasi");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
                    }
                }
                else
                {
                    MessageBox.Show("Harap Isi Data!");
                }
                
                
            }

            textBoxKodeBrgJadi.Focus();

            textBoxKodeBrgJadi.Text = "";
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxSatuan.Text = "";
        }

        private void textBoxKodeBrgJadi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeBrgJadi.Text.Length == 5)
            {
                listBrgJadi = BarangJadi.BacaData(textBoxKodeBrgJadi.Text);
                if (listBrgJadi.Count > 0)
                {
                    baru = false;
                    textBoxNama.Text = listBrgJadi[0].Nama;
                    textBoxHarga.Text = listBrgJadi[0].Harga.ToString();
                    textBoxSatuan.Text = listBrgJadi[0].Satuan.ToString();
                    comboKatBrgJadi.SelectedItem = listBrgJadi[0].KategoriBarang.ToString();
                }
                else
                {
                    baru = true;
                }
            }
        }

        private void textBoxKodeBrgJadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DaftarBrgJadi frmDaftarBrgJadi = new DaftarBrgJadi();
                frmDaftarBrgJadi.Owner = this;
                frmDaftarBrgJadi.Show();
            }
        }
    }
}
