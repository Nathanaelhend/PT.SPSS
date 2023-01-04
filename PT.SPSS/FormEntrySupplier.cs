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
    public partial class FormEntrySupplier : Form
    {
        List<Supplier> listSupplier = new List<Supplier>();

        public bool baru;

        public FormEntrySupplier()
        {
            InitializeComponent();
        }


        private void FormEntrySupplier_Load(object sender, EventArgs e)
        {
            textBoxKodeSupplier.Focus();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (textBoxKodeSupplier.Text != "" && textBoxNamaSupplier.Text != "" && textBoxAlamat.Text != "" && textBoxKota.Text != "")
            {
                try
                {
                    Supplier s = new Supplier(textBoxKodeSupplier.Text, textBoxNamaSupplier.Text, textBoxAlamat.Text, textBoxKota.Text);
                    Supplier.HapusData(s);
                    MessageBox.Show("Hapus data supplier berhasil.", "Informasi");
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

            textBoxKodeSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamat.Text = "";
            textBoxKota.Text = "";
            textBoxKodeSupplier.Focus();
        }


        private void buttonBatal_Click_1(object sender, EventArgs e)
        {
            textBoxKodeSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamat.Text = "";
            textBoxKota.Text = "";
            textBoxKodeSupplier.Focus();
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            if (baru == true)
            {
                if (textBoxKodeSupplier.Text != "" && textBoxNamaSupplier.Text != "" && textBoxAlamat.Text != "" && textBoxKota.Text != "")
                {
                    try
                    {
                        Supplier s = new Supplier(textBoxKodeSupplier.Text, textBoxNamaSupplier.Text, textBoxAlamat.Text, textBoxKota.Text);
                        Supplier.TambahData(s);

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
                if (textBoxKodeSupplier.Text != "" && textBoxNamaSupplier.Text != "" && textBoxAlamat.Text != "" && textBoxKota.Text != "")
                {
                    try
                    {
                        Supplier s = new Supplier(textBoxKodeSupplier.Text, textBoxNamaSupplier.Text, textBoxAlamat.Text, textBoxKota.Text);
                        Supplier.UbahData(s);
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

            textBoxKodeSupplier.Focus();

            textBoxKodeSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamat.Text = "";
            textBoxKota.Text = "";
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBoxKodeSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                    listSupplier = Supplier.BacaData("kodeSupplier",textBoxKodeSupplier.Text);
                    if (listSupplier.Count > 0)
                    {
                        baru = false;
                        textBoxNamaSupplier.Text = listSupplier[0].Nama;
                        textBoxAlamat.Text = listSupplier[0].Alamat;
                        textBoxKota.Text = listSupplier[0].Kota;
                        textBoxNamaSupplier.Focus();
                    }
                    else
                    {
                        baru = true;
                        textBoxNamaSupplier.Focus();
                    }
            }

            
        }
    }
}
