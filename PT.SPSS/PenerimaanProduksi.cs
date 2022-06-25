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
    public partial class PenerimaanProduksi : Form
    {
        List<BarangJadi> listBrgJadi = new List<BarangJadi>();
        List<HPP> listHPP = new List<HPP>();
        public PenerimaanProduksi()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }

        private void PenerimaanProduksi_Load(object sender, EventArgs e)
        {
            dateTimePickerPenerimaan.Value = DateTime.Now;
        }

        private void textBoxNoOrder_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNoOrder.Text.Length < 5)
            {
                MessageBox.Show("Kode harus 5 karakter");
            }

            else if (textBoxNoOrder.Text.Length == 5)
            {
                listHPP = HPP.BacaData("kode", textBoxNoOrder.Text);
                if (listHPP.Count > 0)
                {
                    dateTimePickerTglOrder.Value = listHPP[0].Tanggal;
                    textBoxKodeBrgJadi.Text = listHPP[0].BrgJadi.KodeBarang;
                    textBoxNamaBarang.Text = listHPP[0].BrgJadi.Nama;
                }
                else
                {
                    MessageBox.Show("Data Tidak ketemu");
                }
            }

            else
            {
                //textBoxNamaSupplier.Text = "";
                //textBoxAlamat.Text = "";
                //textBoxKota.Text = "";
            }
        }
    }
}
