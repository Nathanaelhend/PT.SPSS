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
    public partial class FormKatBahan : Form
    {
        List<KategoriBahanBaku> listKBB = new List<KategoriBahanBaku>();
        public bool baru;

        public FormKatBahan()
        {
            InitializeComponent();
        }

        private void textBoxKodeCatBB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeCatBB.Text.Length == 5)
            {
                listKBB = KategoriBahanBaku.BacaData("kodeBahan", textBoxKodeCatBB.Text);
                if (listKBB.Count > 0)
                {
                    baru = false;
                    textBoxKeterangan.Text = listKBB[0].Keterangan_kategori;
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

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (baru == true)
            {
                try
                {
                    KategoriBahanBaku kbb = new KategoriBahanBaku(textBoxKodeCatBB.Text, textBoxKeterangan.Text);
                    KategoriBahanBaku.TambahData(kbb);

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
                    KategoriBahanBaku kbb = new KategoriBahanBaku(textBoxKodeCatBB.Text, textBoxKeterangan.Text);
                    KategoriBahanBaku.UbahData(kbb);
                    MessageBox.Show("Pengubahan berhasil.", "Informasi");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
                }
            }

            textBoxKodeCatBB.Focus();

            textBoxKodeCatBB.Text = "";
            textBoxKeterangan.Text = "";
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxKodeCatBB.Text = "";
            textBoxKeterangan.Text = "";
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriBahanBaku kbb = new KategoriBahanBaku(textBoxKodeCatBB.Text, textBoxKeterangan.Text);
                KategoriBahanBaku.HapusData(kbb);
                MessageBox.Show("Hapus data berhasil.", "Informasi");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus. Pesan Kesalahan : " + ex.Message);
            }

            textBoxKodeCatBB.Text = "";
            textBoxKeterangan.Text = "";
            textBoxKodeCatBB.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKatBahan_Load(object sender, EventArgs e)
        {
            textBoxKodeCatBB.Focus();
        }
    }
}
