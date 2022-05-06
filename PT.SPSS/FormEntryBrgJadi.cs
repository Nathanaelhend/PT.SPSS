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
        public bool baru;

        public FormEntryBrgJadi()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (baru == true)
            {
                try
                {
                    KategoriBarang kb = (KategoriBarang)comboKatBrgJadi.SelectedItem;
                    BarangJadi b = new BarangJadi(textBoxKodeBrgJadi.Text, textBoxNama.Text, int.Parse(textBoxStok.Text), kb);
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
                try
                {
                    KategoriBarang kb = (KategoriBarang)comboKatBrgJadi.SelectedItem;
                    BarangJadi b = new BarangJadi(textBoxKodeBrgJadi.Text, textBoxNama.Text, int.Parse(textBoxStok.Text), kb);
                    BarangJadi.UbahData(b);
                    MessageBox.Show("Pengubahan berhasil.", "Informasi");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
                }
            }

            textBoxKodeBrgJadi.Focus();

            textBoxKodeBrgJadi.Text = "";
            textBoxNama.Text = "";
            textBoxStok.Text = "";
        }

        private void FormEntryBrgJadi_Load(object sender, EventArgs e)
        {
            listCatBrgJadi = KategoriBarang.BacaData("", "");
            comboKatBrgJadi.DataSource = listCatBrgJadi;
            comboKatBrgJadi.DisplayMember = "keterangan_barang";
            comboKatBrgJadi.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxKodeBrgJadi.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxKodeBrgJadi.Text = "";
            textBoxNama.Text = "";
            textBoxStok.Text = "";
            textBoxKodeBrgJadi.Focus();
        }

        private void comboKatBrgJadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboKatBrgJadi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriBarang kb = (KategoriBarang)comboKatBrgJadi.SelectedItem;
                BarangJadi b = new BarangJadi(textBoxKodeBrgJadi.Text, textBoxNama.Text, int.Parse(textBoxStok.Text), kb);
                BarangJadi.HapusData(b);
                MessageBox.Show("Hapus data berhasil.", "Informasi");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus supplier. Pesan Kesalahan : " + ex.Message);
            }

            textBoxKodeBrgJadi.Text = "";
            textBoxNama.Text = "";
            textBoxStok.Text = "";
            textBoxKodeBrgJadi.Focus();
        }

        private void textBoxKodeBrgJadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
