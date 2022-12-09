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

        private void FormatDataGrid2()
        {
            dataGridViewHPP.Columns.Clear();

            dataGridViewHPP.Columns.Add("noBukti", "No Bukti");
            dataGridViewHPP.Columns.Add("tanggal", "Tanggal");
            dataGridViewHPP.Columns.Add("kodeBrg", "Kode Barang");
            dataGridViewHPP.Columns.Add("namaBrg", "Nama Barang");
            dataGridViewHPP.Columns.Add("quantity", "Qty");

            dataGridViewHPP.Columns["noBukti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHPP.Columns["tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHPP.Columns["kodeBrg"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHPP.Columns["namaBrg"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHPP.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dataGridViewHPP.AllowUserToAddRows = false;
            dataGridViewHPP.ReadOnly = true;

        }

        private void TampilDataGrid2()
        {

            if (hpp.Count > 0)
            {
                foreach (HPP h in hpp)
                {
                    dataGridViewHPP.Rows.Add(h.NoBukti, h.Tanggal, h.BrgJadi.KodeBarang, h.BrgJadi.Nama, h.Quantity);
                }
            }
            else
            {
                dataGridViewHPP.DataSource = null;
            }
        }

        private void textBoxNoHPP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                panelHPP.Visible = true;
                FormatDataGrid2();
                hpp = HPP.BacaData("noBukti", textBoxNoHPP.Text);
                TampilDataGrid2();
            }

            //if(e.KeyCode == Keys.Enter)
            //{
            //    hpp = HPP.BacaData("noBukti", textBoxNoHPP.Text);
            //    dateTimePickerTglHPP.Text = hpp[0].Tanggal.ToString();
            //    textBoxKodeBrgJadi.Text = hpp[0].BrgJadi.KodeBarang.ToString();
            //    textBoxNamaBrg.Text = hpp[0].BrgJadi.Nama.ToString();
            //    textBoxQty.Text = hpp[0].Quantity.ToString();
            //    textBoxJmlhProduksi.Focus();
            //}
        }

        private void FormPenerimaan_Load(object sender, EventArgs e)
        {
            dataGridViewHPP.AllowUserToAddRows = false;
            dataGridViewHPP.ReadOnly = true;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            hpp = HPP.BacaData("noBukti", textBoxNoHPP.Text);

            PenerimaanProduksi pp = new PenerimaanProduksi(textBoxNoBukti.Text, dateTimePickerPenerimaan.Value, textBoxNoHPP.Text, dateTimePickerTglHPP.Value,
                                    textBoxNoHPP.Text, textBoxJmlhProduksi.Text);
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


        private void dataGridViewHPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewHPP.Rows[e.RowIndex];
                textBoxNoHPP.Text = row.Cells["noBukti"].Value.ToString();
                dateTimePickerTglHPP.Text = row.Cells["tanggal"].Value.ToString();
                textBoxKodeBrgJadi.Text = row.Cells["kodeBrg"].Value.ToString();
                textBoxNamaBrg.Text = row.Cells["namaBrg"].Value.ToString(); ;
                textBoxQty.Text = row.Cells["quantity"].Value.ToString();
                textBoxJmlhProduksi.Focus();

            }
            panelHPP.Visible = false;
        }
    }
}
