﻿using System;
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
    public partial class FormEntryBahanBaku : Form
    {
        List<KategoriBahanBaku> listKatBhnBaku = new List<KategoriBahanBaku>();
        List<BahanBaku> listBhnBaku = new List<BahanBaku>();
        public bool baru;

        public FormEntryBahanBaku()
        {
            InitializeComponent();
        }

        private void textBoxKodeCatBB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEntryBahanBaku_Load(object sender, EventArgs e)
        {
            listKatBhnBaku = KategoriBahanBaku.BacaData("", "");
            comboKatBhnBaku.DataSource = listKatBhnBaku;
            comboKatBhnBaku.DisplayMember = "keteranganKategori";
            comboKatBhnBaku.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (baru == true)
            {
                if (textBoxKodeBhnBaku.Text != "" && textBoxNama.Text != "" && textBoxHarga.Text != "" && textBoxSatuan.Text != "")
                {
                    try
                    {
                        KategoriBahanBaku kbb = (KategoriBahanBaku)comboKatBhnBaku.SelectedItem;
                        BahanBaku b = new BahanBaku(textBoxKodeBhnBaku.Text, textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxSatuan.Text, kbb);
                        BahanBaku.TambahData(b);

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
                if (textBoxKodeBhnBaku.Text != "" && textBoxNama.Text != "" && textBoxHarga.Text != "" && textBoxSatuan.Text != "")
                {
                    try
                    {
                        KategoriBahanBaku kbb = (KategoriBahanBaku)comboKatBhnBaku.SelectedItem;
                        BahanBaku b = new BahanBaku(textBoxKodeBhnBaku.Text, textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxSatuan.Text, kbb);
                        BahanBaku.UbahData(b);
                        MessageBox.Show("Pengubahan berhasil.", "Informasi");
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
                    }
                }
                else
                {
                    MessageBox.Show("Harap Isi data!");
                }
                
                
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxKodeBhnBaku.Text = "";
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxSatuan.Text = "";
            textBoxKodeBhnBaku.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriBahanBaku kbb = (KategoriBahanBaku)comboKatBhnBaku.SelectedItem;
                BahanBaku b = new BahanBaku(textBoxKodeBhnBaku.Text, textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxSatuan.Text, kbb);
                BahanBaku.HapusData(b);
                MessageBox.Show("Hapus data berhasil.", "Informasi");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus. Pesan Kesalahan : " + ex.Message);
            }

            textBoxKodeBhnBaku.Text = "";
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxSatuan.Text = "";
            textBoxKodeBhnBaku.Focus();
        }

       

        private void comboKatBhnBaku_SelectedIndexChanged(object sender, EventArgs e)
        {
            KategoriBahanBaku kategoriDipilih = (KategoriBahanBaku)comboKatBhnBaku.SelectedItem;
        }

        private void textBoxKodeBhnBaku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBhnBaku = BahanBaku.BacaData(textBoxKodeBhnBaku.Text);
                if (listBhnBaku.Count > 0)
                {
                    baru = false;
                    textBoxNama.Text = listBhnBaku[0].Nama;
                    textBoxHarga.Text = listBhnBaku[0].Harga.ToString();
                    textBoxSatuan.Text = listBhnBaku[0].Satuan.ToString();
                    comboKatBhnBaku.SelectedItem = listBhnBaku[0].KategoriBhnBaku.ToString();
                }
                else
                {
                    baru = true;
                    textBoxNama.Focus();
                }
            }
        }
    }
}