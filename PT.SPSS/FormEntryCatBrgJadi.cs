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
    public partial class FormEntryCatBrgJadi : Form
    {
        List<KategoriBarang> listKB = new List<KategoriBarang>();

        public bool baru;

        public FormEntryCatBrgJadi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (baru == true)
            {
                try
                {
                    KategoriBarang kb = new KategoriBarang(textBoxKode.Text, textBoxKeterangan.Text);
                    KategoriBarang.TambahData(kb);

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
                    KategoriBarang kb = new KategoriBarang(textBoxKode.Text, textBoxKeterangan.Text);
                    KategoriBarang.UbahData(kb);
                    MessageBox.Show("Pengubahan berhasil.", "Informasi");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
                }
            }

            textBoxKode.Focus();

            textBoxKode.Text = "";
            textBoxKeterangan.Text = "";
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length == 5)
            {
                listKB = KategoriBarang.BacaData("kode", textBoxKode.Text);
                if (listKB.Count > 0)
                {
                    baru = false;
                    textBoxKeterangan.Text = listKB[0].KeteranganBarang;
                    textBoxKeterangan.Focus();
                }
                else
                {
                    baru = true;
                }
            }

            else
            {
                textBoxKeterangan.Text = "";
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxKode.Text = "";
            textBoxKeterangan.Text = "";

            textBoxKode.Focus();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriBarang kb = new KategoriBarang(textBoxKode.Text, textBoxKeterangan.Text);
                KategoriBarang.HapusData(kb);
                MessageBox.Show("Hapus data berhasil.", "Informasi");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus. Pesan Kesalahan : " + ex.Message);
            }

            textBoxKode.Text = "";
            textBoxKeterangan.Text = "";
            textBoxKode.Focus();
        }

        private void FormEntryCatBrgJadi_Load(object sender, EventArgs e)
        {
            textBoxKode.Focus();
        }
    }
}
