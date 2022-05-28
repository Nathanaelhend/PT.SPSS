using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;

namespace SPSS_LIB
{
    public class Pembelian
    {
        private string noNota;
        private DateTime tanggal;
        private Supplier supplier;
        private int jumlah;
        private double discPersen;
        private int discRph;
        private int dpp;
        private double ppnPersen;
        private int ppnRph;
        private int netto;
        private List<PembelianDetail> listBeliDetail;

        #region Constructors
        public Pembelian(string noNota, DateTime tanggal, Supplier supplier, int jumlah, double discPersen, int discRph, int dpp, double ppnPersen, int ppnRph, int netto)
        {
            this.NoNota = noNota;
            this.Tanggal = tanggal;
            this.Supplier = supplier;
            this.Jumlah = jumlah;
            this.DiscPersen = discPersen;
            this.DiscRph = discRph;
            this.Dpp = dpp;
            this.PpnPersen = ppnPersen;
            this.PpnRph = ppnRph;
            this.Netto = netto;
            this.ListBeliDetail = new List<PembelianDetail>();
        }
        #endregion

        #region Properties
        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public double DiscPersen { get => discPersen; set => discPersen = value; }
        public int DiscRph { get => discRph; set => discRph = value; }
        public int Dpp { get => dpp; set => dpp = value; }
        public double PpnPersen { get => ppnPersen; set => ppnPersen = value; }
        public int PpnRph { get => ppnRph; set => ppnRph = value; }
        public int Netto { get => netto; set => netto = value; }
        public List<PembelianDetail> ListBeliDetail { get => listBeliDetail; set => listBeliDetail = value; }
        #endregion

        #region Methods
        public void TambahPembelianDetil(BahanBaku bhnBaku, int quantity, int harga, int jumlah, double discPersen, int discRph, int netto)
        {
            PembelianDetail notaBeliDetil = new PembelianDetail(bhnBaku, quantity, harga, jumlah, discPersen, discRph, netto);

            this.ListBeliDetail.Add(notaBeliDetil);
        }

        public static void TambahData(Pembelian pembelian)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    string sql1 = "insert into nota_beli(no_nota, tanggal, supplier_id, jumlah, diskon_persen, diskon_rph, dpp, ppn_persen, ppn_rupiah, total_beli) VALUES('" + pembelian.NoNota + "','" +
                                    pembelian.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + pembelian.Supplier.KodeSupplier + "','" + pembelian.Jumlah + "','" +
                                    pembelian.DiscPersen + "','" + pembelian.DiscRph + "','"  + pembelian.Dpp + "','" + pembelian.PpnPersen + "','" + pembelian.PpnRph + "','" + pembelian.Netto + "')";

                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (PembelianDetail pembelianDetail in pembelian.ListBeliDetail)
                    {
                        string sql2 = "insert into nota_beli_detail(nomor_nota_beli, id_barang_baku, quantity, harga, tanggal, supplier_id, jumlah, diskon_persen, diskon_rph, total_harga) VALUES('" + pembelian.NoNota + "','" +
                                       pembelianDetail.BhnBaku.Kode + "','" + pembelianDetail.Quantity + "','" + pembelianDetail.Harga + "','" + pembelian.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + pembelian.Supplier.KodeSupplier + "','" + pembelianDetail.Jumlah + "','" + pembelianDetail.DiscPersen + "','" +
                                       pembelianDetail.DiscRph + "','" + pembelianDetail.TotalHarga + "')";

                        Koneksi.JalankanPerintahDML(sql2);
                    }
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    throw (new Exception("Penyimpanan transaksi pembelian gagal. Pesan Kesalahan : " + ex.Message));
                }
            }
        }

        public static double HitungDisc(int jumlah, int persen)
        {
            double disc = 0;
            disc = jumlah  * (persen / 100); 
            return disc;
        }

        public static int HitungJumlah(int qty, int harga)
        {
            int jumlah = 0;
            jumlah = (qty * harga);
            return jumlah;
        }

        public static int HitungTotal(int jumlah, int diskon)
        {
            int hasil = 0;
            hasil = jumlah - diskon;
            return hasil;
        }

        public static int HitungPPn(int jumlahAll, int ppn)
        {
            int hasil = 0;
            hasil = (jumlahAll * ppn) / 100;
            return hasil;
        }

        public static int HitungNetto(int dpp, int ppn)
        {
            int hasil = 0;
            hasil = dpp + ppn;
            return hasil;
        }

        #endregion

    }
}
