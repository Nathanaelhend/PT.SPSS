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
    public partial class FormPenerimaan : Form
    {
        List<HPP> hpp = new List<HPP>();

        public bool baru;

        public FormPenerimaan()
        {
            InitializeComponent();
        }

       

        

        private void textBoxNoHPP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxNoHPP.Text == "")
                {
                    MessageBox.Show("Kode harus diisi!");
                }

                else if (textBoxNoHPP.Text != "")
                {
                    string nama = "";
                    hpp = HPP.BacaData("noBukti", textBoxNoHPP.Text, ref nama);
                    if (hpp.Count > 0)
                    {
                        
                        dateTimePickerTglHPP.Text = hpp[0].Tanggal.ToString();
                        textBoxKodeBrgJadi.Text = hpp[0].BrgJadi;
                        textBoxNamaBrg.Text = nama;
                        textBoxQty.Text = hpp[0].Quantity.ToString();
                        textBoxJmlhProduksi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("");
                        textBoxNoHPP.Focus();
                    }
                }

                else if (textBoxNoHPP.Text == "")
                {
                    dateTimePickerTglHPP.Value = DateTime.Now;
                    textBoxKodeBrgJadi.Text = "";
                    textBoxNamaBrg.Text = "";
                    textBoxJmlhProduksi.Text = "";
                }
            }
        }

        private void FormPenerimaan_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

            if (textBoxNoBukti.Text != "" && textBoxNoHPP.Text != "" && textBoxKodeBrgJadi.Text != "" && textBoxNamaBrg.Text != "" && textBoxQty.Text != "" && textBoxJmlhProduksi.Text != "")
            {
                string nama = "";
                hpp = HPP.BacaData("noBukti", textBoxNoHPP.Text, ref nama);

                PenerimaanProduksi pp = new PenerimaanProduksi(textBoxNoBukti.Text, dateTimePickerPenerimaan.Value, textBoxNoHPP.Text, dateTimePickerTglHPP.Value,
                                        textBoxNoHPP.Text, textBoxJmlhProduksi.Text);
                PenerimaanProduksi.TambahData(pp);

                MessageBox.Show("Data Berhasil Disimpan");
            }
            else
            {
                MessageBox.Show("Harap Isi Data!");
            }

            textBoxNoBukti.Text = "";
            dateTimePickerPenerimaan.Value = DateTime.Now;
            textBoxNoHPP.Text = "";
            textBoxKodeBrgJadi.Text = "";
            textBoxNamaBrg.Text = "";
            textBoxQty.Text = "";
            textBoxJmlhProduksi.Text = "";
            dateTimePickerTglHPP.Value = DateTime.Now;
            textBoxNoBukti.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxNoBukti.Text = "";
            dateTimePickerPenerimaan.Value = DateTime.Now;
            textBoxNoHPP.Text = "";
            textBoxKodeBrgJadi.Text = "";
            textBoxNamaBrg.Text = "";
            textBoxQty.Text = "";
            textBoxJmlhProduksi.Text = "";
            dateTimePickerTglHPP.Value = DateTime.Now;
            textBoxNoBukti.Focus();
        }
    }
}
