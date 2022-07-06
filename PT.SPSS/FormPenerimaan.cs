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


        public FormPenerimaan()
        {
            InitializeComponent();
        }

        private void textBoxNoHPP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                hpp = HPP.BacaData("noBukti", textBoxNoHPP.Text);
                dateTimePickerTglHPP.Text = hpp[0].Tanggal.ToString();
                textBoxKodeBrgJadi.Text = hpp[0].BrgJadi.KodeBarang.ToString();
                textBoxNamaBrg.Text = hpp[0].BrgJadi.Nama.ToString();
                textBoxQty.Text = hpp[0].Quantity.ToString();
                textBoxJmlhProduksi.Focus();
            }
        }

        private void FormPenerimaan_Load(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            PenerimaanProduksi pp = new PenerimaanProduksi(textBoxNoBukti.Text, dateTimePickerPenerimaan.Value, textBoxNoHPP.Text, dateTimePickerTglHPP.Value,
                                    textBoxKodeBrgJadi.Text, textBoxJmlhProduksi.Text);
            PenerimaanProduksi.TambahData(pp);

            MessageBox.Show("Data Berhasil Disimpan");

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
