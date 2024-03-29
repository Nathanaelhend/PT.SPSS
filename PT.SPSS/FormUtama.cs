﻿using SPSS_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT.SPSS
{
    public partial class FormUtama : System.Windows.Forms.Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;

            this.Enabled = false;

            FormLogin frmLogin = new FormLogin();
            frmLogin.Owner = this;
            frmLogin.Show();

            try
            {
                Koneksi koneksi = new Koneksi("localhost", "pt_spss", "root", "");
                //MessageBox.Show("Koneksi berhasil");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message);
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormEntrySupplier"];

            if(frm == null)
            {
                FormEntrySupplier formSupplier = new FormEntrySupplier();
                formSupplier.MdiParent = this;
                formSupplier.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }
        
        private void kodeBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormEntryCatBrgJadi"];

            if (frm == null)
            {
                FormEntryCatBrgJadi formEntryCatBrg = new FormEntryCatBrgJadi();
                formEntryCatBrg.MdiParent = this;
                formEntryCatBrg.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormEntrySupplier"];

            if (frm == null)
            {
                FormEntryBrgJadi formEntryBrgJadi = new FormEntryBrgJadi();
                formEntryBrgJadi.MdiParent = this;
                formEntryBrgJadi.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kategoriBahanBakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormKatBahan"];

            if (frm == null)
            {
                FormKatBahan formEntryKatBahan = new FormKatBahan();
                formEntryKatBahan.MdiParent = this;
                formEntryKatBahan.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void barangBakuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms["FormEntryBahanBaku"];

            if (frm == null)
            {
                FormEntryBahanBaku formEntrybhnBaku = new FormEntryBahanBaku();
                formEntrybhnBaku.MdiParent = this;
                formEntrybhnBaku.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPembelian"];

            if (frm == null)
            {
                FormPembelian formPembelian = new FormPembelian();
                formPembelian.MdiParent = this;
                formPembelian.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormEntryHPP"];

            if (frm == null)
            {
                FormEntryHPP formHPP = new FormEntryHPP();
                formHPP.MdiParent = this;
                formHPP.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bahanBakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarBahanBaku frmDaftarBhnBaku = new DaftarBahanBaku();
            frmDaftarBhnBaku.Owner = this;
            frmDaftarBhnBaku.Show();
        }

        private void barangJadiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarBrgJadi frmDaftaBrgJadi = new DaftarBrgJadi();
            frmDaftaBrgJadi.Owner = this;
            frmDaftaBrgJadi.Show();
        }

        private void reportPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportNotaBeli frmCetak = new FrmReportNotaBeli();
            frmCetak.Owner = this;
            frmCetak.Show();
        }

        private void reportDetailPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportDetilNota frmDetailReport = new FormReportDetilNota();
            frmDetailReport.Owner = this;
            frmDetailReport.Show();
        }

        private void penerimaanProduksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenerimaan frmPenerimaan = new FormPenerimaan();
            frmPenerimaan.Owner = this;
            frmPenerimaan.Show();
        }

        private void reportPenerimanProduksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportPenerimaan formRptPenerimaan = new FormReportPenerimaan();
            formRptPenerimaan.Owner = this;
            formRptPenerimaan.Show();
        }

        private void sisaProduksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSisaProduksi frmSisaProduksi = new FormSisaProduksi();
            frmSisaProduksi.Owner = this;
            frmSisaProduksi.Show();
        }

        private void orderPotongHPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportHPP frmHpp = new FormReportHPP();
            frmHpp.Owner = this;
            frmHpp.Show();
        }

        private void orderPotongPerBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportOrderPotongBarang frmOrder = new FormReportOrderPotongBarang();
            frmOrder.Owner = this;
            frmOrder.Show();
        }

        private void daftarOrderPotongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarOrderPotong frmDaftarOrderPtg = new FormDaftarOrderPotong();
            frmDaftarOrderPtg.Owner = this;
            frmDaftarOrderPtg.Show();
        }
    }
}
