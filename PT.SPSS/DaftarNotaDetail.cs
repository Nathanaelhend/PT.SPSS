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
    public partial class DaftarNotaDetail : Form
    {
        List<Pembelian> listPembelian = new List<Pembelian>();
        DataView dv = new DataView();
        public DaftarNotaDetail()
        {
            InitializeComponent();
        }

        private void panelSupplier_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TampilGrid()
        {
            dataGridViewPembelian.Rows.Clear();

            dataGridViewPembelian.AllowUserToAddRows = false;

            if (listPembelian.Count > 0)
            {
                
                foreach (Pembelian n in listPembelian)
                {
                    foreach (PembelianDetail nbd in n.ListBeliDetail)
                    {
                        //dataGridViewPembelian.DataSource = listPembelian;
                        dataGridViewPembelian.Rows.Add(n.NoNota, n.Tanggal.ToString("yyyy-MM-dd"), n.Supplier.KodeSupplier, nbd.Jumlah, nbd.DiscRph, n.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewPembelian.DataSource = null;
            }
            
        }

        private void DaftarNotaDetail_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listPembelian = Pembelian.BacaData("", "");

            TampilGrid();
            //if (listPembelian.Count > 0)
            //{
            //    dataGridViewPembelian.DataSource = listPembelian;
            //}
            //else
            //{
            //    dataGridViewPembelian.DataSource = null;
            //}
            //dataGridViewPembelian.AllowUserToAddRows = false;
            //dataGridViewPembelian.ReadOnly = true;

        }

        private void FormatDataGrid()
        {
            dataGridViewPembelian.Columns.Add("NoNota", "Nomor Nota");
            dataGridViewPembelian.Columns.Add("Tanggal", "Tanggal");
            dataGridViewPembelian.Columns.Add("Supplier", "Supplier");
            dataGridViewPembelian.Columns.Add("Jumlah", "jumlah");
            dataGridViewPembelian.Columns.Add("Diskon", "diskon");
            dataGridViewPembelian.Columns.Add("Total", "total");

            //dataGridViewPembelian.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dataGridViewPembelian.Columns["Harga"].DefaultCellStyle.Format = "#,###";



        }

        private void dateTimePickerDateAkhir_ValueChanged(object sender, EventArgs e)
        {

            //if (listPembelian.Count > 0)
            //{
            //    dataGridViewPembelian.DataSource = listPembelian;
            //}
            //else
            //{
            //    dataGridViewPembelian.DataSource = null;
            //}

            //listPembelian = Pembelian.BacaDataTanggal(dateTimePickerDateAwal.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"), dateTimePickerDateAkhir.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));

            //TampilGrid();
        }

        private void dateTimePickerDateAwal_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateAkhir.Enabled = true;
        }

        private void radioButtonRangeTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDateAwal.Enabled = true;
        }

        private void radioButtonNomorNota_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNomorNota.Enabled = true;
        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            //dataGridViewPembelian.Rows.Clear();

            DateTime tglAwal = dateTimePickerDateAwal.Value.Date;
            DateTime tglAkhir = dateTimePickerDateAkhir.Value.Date;

            listPembelian = Pembelian.BacaDataTanggal(tglAwal.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"), tglAkhir.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            //bisane pake data source aja
            if (listPembelian.Count > 0)
            {
                dataGridViewPembelian.DataSource = listPembelian;
            }
            else
            {
                dataGridViewPembelian.DataSource = null;
            }

            //dataGridViewPembelian.AllowUserToAddRows = false;

            //if (listPembelian.Count > 0)
            //{
            //    foreach (Pembelian n in listPembelian)
            //    {
            //        foreach (PembelianDetail nbd in n.ListBeliDetail)
            //        {
                        
                        
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridViewPembelian.DataSource = null;
            //}


            //TampilGrid();
            //dv.RowFilter = String.Format("tanggal >= #{0:yyyy-MM-dd}# AND tanggal <= #{1:yyyy-MM-dd}#", tglAwal, tglAkhir);
            //dataGridViewPembelian.DataSource = dv;
        }

        private void adsafa()
        {
            

            //if (listPembelian.Count > 0)
            //{
            //    dataGridViewPembelian.DataSource = listPembelian;
            //}
            //else
            //{
            //    dataGridViewPembelian.DataSource = null;
            //}

            
            //dataGridViewPembelian.ReadOnly = true;

            //dataGridViewPembelian.Rows.Clear();

            if (listPembelian.Count > 0) //jika listNotaJUal terisi data
            {
                //tampilkan semua isi listNotaJual di datagridview
                foreach (Pembelian n in listPembelian)
                {
                    foreach (PembelianDetail nbd in n.ListBeliDetail)
                    {
                        //DataTable dt = new DataTable();
                        //DataRow dataRow = dataTable.NewRow();
                        //dataRow["noNota"] = n.NoNota;
                        //dataRow["tanggal"] = n.Tanggal.ToShortDateString();
                        //dataRow["supplier"] = n.Supplier.KodeSupplier;
                        //dataRow["jumlah"] = nbd.Jumlah;
                        //dataRow["diskon"] = nbd.DiscRph;
                        //dataRow["total"] = n.Jumlah;

                        //dataTable.Rows.Add(dataRow);

                        //dataTable.AcceptChanges();

                        //dt = dataGridViewPembelian.DataSource as DataTable;

                        //DataRow dr = dt.NewRow();

                        //dr[0] = n.NoNota;
                        //dr[1] = n.Tanggal.ToShortDateString();
                        //dr[2] = n.Supplier.KodeSupplier;
                        //dr[3] = nbd.Jumlah;
                        //dr[4] = nbd.DiscRph;
                        //dr[5] = n.Jumlah;

                        //dt.Rows.Add(dr);

                        dataGridViewPembelian.Rows.Add(n.NoNota, n.Tanggal.ToString("yyyy-MM-dd"), n.Supplier.KodeSupplier, nbd.Jumlah, nbd.DiscRph, n.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewPembelian.DataSource = null;
            }
        }
    }
}
