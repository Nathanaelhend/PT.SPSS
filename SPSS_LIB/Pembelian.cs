using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;

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
        public void TambahPembelianDetil(string kode, int quantity, int harga, int jumlah, double discPersen, int discRph, int netto)
        {
            PembelianDetail notaBeliDetil = new PembelianDetail(kode, quantity, harga, jumlah, discPersen, discRph, netto);

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
                                    pembelian.DiscPersen + "','" + pembelian.DiscRph + "','" + pembelian.Dpp + "','" + pembelian.PpnPersen + "','" + pembelian.PpnRph + "','" + pembelian.Netto + "')";

                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (PembelianDetail pembelianDetail in pembelian.ListBeliDetail)
                    {
                        string sql2 = "insert into nota_beli_detail(nomor_nota_beli, id_barang_baku, quantity, harga, tanggal, supplier_id, jumlah, diskon_persen, diskon_rph, total_harga) VALUES('" + pembelian.NoNota + "','" +
                                       pembelianDetail.Kode + "','" + pembelianDetail.Quantity + "','" + pembelianDetail.Harga + "','" + pembelian.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") +
                                       "','" + pembelian.Supplier.KodeSupplier + "','" + pembelianDetail.Jumlah + "','" + pembelianDetail.DiscPersen + "','" +
                                       pembelianDetail.DiscRph + "','" + pembelianDetail.TotalHarga + "')";

                        Koneksi.JalankanPerintahDML(sql2);
                    }
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    throw (new Exception("Penyimpanan Data Pembelian gagal. Pesan Kesalahan : " + ex.Message));
                }
            }
        }

        //public static List<Pembelian> BacaHargaTerbaru(string pKriteria, string pNilaiKriteria)
        //{
        //    string sql = "";
        //    if(pKriteria == "")
        //    {
        //        sql = "SELECT nota_beli_detail.nomor_nota_beli, nota_beli_detail.tanggal, nota_beli_detail.id_barang_baku, nota_beli_detail.harga" +
        //              "FROM nota_beli_detail WHERE nota_beli_detail.id_barang_baku = " + pKriteria + "LIKE'%" + pNilaiKriteria + "ORDER BY nota_beli_detail.tanggal DESC LIMIT 1";
        //        MySqlDataReader hasilData1 = Koneksi.JalankanPerintahQuery(sql);
        //    }

        //}

        public static List<Pembelian> BacaData(string pKriteria, string pNilaiKriteria)
        {
            string sql = "";
            if (pKriteria == "")
            {
                //sql = "SELECT nb.no_nota as Nomor_Nota, nb.tanggal as Tanggal_Nota, s.nama as Nama_Supplier, bb.nama as Nama_Bahan_Baku, nbd.quantity," +
                //      "nbd.harga FROM nota_beli nb INNER JOIN nota_beli_detail nbd ON nb.no_nota = nbd.nomor_nota_beli INNER JOIN supplier s ON s.kodeSupplier=nb.supplier_id " +
                //      "INNER JOIN bahan_baku bb ON bb.kode = nbd.id_barang_baku";
                sql = "select nb.no_nota, nb.tanggal, nb.supplier_id, S.nama, nb.jumlah, nb.diskon_persen, diskon_rph, nb.dpp, nb.ppn_persen, nb.ppn_rupiah," +
                      "nb.total_beli from nota_beli nb INNER JOIN supplier S on nb.supplier_id = S.kodeSupplier";
            }

            else
            {
                //sql = "SELECT nb.no_nota as Nomor_Nota, nb.tanggal as Tanggal_Nota, s.nama as Nama_Supplier, bb.nama as Nama_Bahan_Baku, nbd.quantity, nbd.harga" +
                //      "FROM nota_beli nb INNER JOIN nota_beli_detail nbd ON nb.no_nota = nbd.nomor_nota_beli INNER JOIN supplier s ON s.kodeSupplier = nb.supplier_id" +
                //      "INNER JOIN bahan_baku bb ON bb.kode = nbd.id_barang_baku WHERE nb.tanggal BETWEEN " + pKriteria + "AND" + pNilaiKriteria;
                sql = "select nb.no_nota, nb.tanggal, nb.supplier_id, S.nama, nb.jumlah, nb.diskon_persen, diskon_rph, nb.dpp, nb.ppn_persen, nb.ppn_rupiah," +
                      "nb.total_beli from nota_beli nb INNER JOIN supplier S on nb.supplier_id = S.kodeSupplier" + "WHERE" + pKriteria + "LIKE'%" + pNilaiKriteria + "%'";
            }

            MySqlDataReader hasilData1 = Koneksi.JalankanPerintahQuery(sql);

            List<Pembelian> listHasilData = new List<Pembelian>();

            while (hasilData1.Read() == true)
            { 
                string noNota = hasilData1.GetValue(0).ToString();

                DateTime tanggal = DateTime.Parse(hasilData1.GetValue(1).ToString());

                List<Supplier> listSupplier = Supplier.BacaData("kodeSupplier", hasilData1.GetValue(2).ToString());

                List<Supplier> listSupplierNama = Supplier.BacaData("nama", hasilData1.GetValue(3).ToString());

                int jumlah = int.Parse(hasilData1.GetValue(4).ToString());

                double discPersen = double.Parse(hasilData1.GetValue(5).ToString()); 
                int discRph = int.Parse(hasilData1.GetValue(6).ToString());
                int dpp = int.Parse(hasilData1.GetValue(7).ToString());
                double ppnPersen = double.Parse(hasilData1.GetValue(8).ToString());
                int ppnRph = int.Parse(hasilData1.GetValue(9).ToString());
                int netto = int.Parse(hasilData1.GetValue(10).ToString());

                Pembelian nota = new Pembelian(noNota, tanggal, listSupplier[0], jumlah, discPersen, discRph, dpp, ppnPersen, ppnRph, netto);


                string sql2 = "select nbd.id_barang_baku, nbd.quantity, nbd.harga, nbd.jumlah, nbd.diskon_persen, nbd.diskon_rph, nbd.total_harga" +
                    " FROM nota_beli N INNER JOIN nota_beli_detail NBD ON N.no_nota = NBD.nomor_nota_beli " +
                     
                    " WHERE N.no_nota = '" + noNota + "'";


                MySqlDataReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);

                while (hasilData2.Read() == true)
                {
                    //Barang yang terbeli 
                    //List<BahanBaku> listBhnBaku = BahanBaku.BacaData("B.kode", hasilData2.GetValue(0).ToString());

                    string kode = hasilData2.GetValue(0).ToString();
                    int qty = int.Parse(hasilData2.GetValue(1).ToString());
                    int harga = int.Parse(hasilData2.GetValue(2).ToString());
                    int jum = int.Parse(hasilData2.GetValue(3).ToString());
                    double discPrs = double.Parse(hasilData2.GetValue(4).ToString());
                    int discRp = int.Parse(hasilData2.GetValue(5).ToString());
                    int total = int.Parse(hasilData2.GetValue(6).ToString());

                    PembelianDetail detilBeli = new PembelianDetail(kode, qty, harga, jum, discPrs, discRp, total);


                    nota.TambahPembelianDetil(kode, qty, harga, jum, discPrs, discRp, total);
                }

                listHasilData.Add(nota);

            }
            return listHasilData;
        }

        public static List<Pembelian> BacaDataTanggal(string tanggalAwal, string tanggalAkhir)
        {
            string sql = "";
           
                //sql = "SELECT nb.no_nota as Nomor_Nota, nb.tanggal as Tanggal_Nota, s.nama as Nama_Supplier, bb.nama as Nama_Bahan_Baku, nbd.quantity, nbd.harga" +
                //      " FROM nota_beli nb INNER JOIN nota_beli_detail nbd ON nb.no_nota = nbd.nomor_nota_beli INNER JOIN supplier s ON s.kodeSupplier = nb.supplier_id" +
                //      " INNER JOIN bahan_baku bb ON bb.kode = nbd.id_barang_baku WHERE nb.tanggal BETWEEN "+ tanggalAwal + "# AND #" + tanggalAkhir;

                sql = "select nb.no_nota, nb.tanggal, nb.supplier_id, S.nama, nb.jumlah, nb.diskon_persen, diskon_rph, nb.dpp, nb.ppn_persen, nb.ppn_rupiah," +
                      " nb.total_beli from nota_beli nb INNER JOIN supplier S on nb.supplier_id = S.kodeSupplier" + " WHERE nb.tanggal BETWEEN '" + tanggalAwal + "' AND '" + tanggalAkhir + "'";

            MySqlDataReader hasilData1 = Koneksi.JalankanPerintahQuery(sql);

            List<Pembelian> listHasilData = new List<Pembelian>();

            System.Diagnostics.Debug.WriteLine(hasilData1);

            while (hasilData1.Read() == true)
            {
                string noNota = hasilData1.GetValue(0).ToString();

                DateTime tanggal = DateTime.Parse(hasilData1.GetValue(1).ToString());

                List<Supplier> listSupplier = Supplier.BacaData("kodeSupplier", hasilData1.GetValue(2).ToString());

                int jumlah = int.Parse(hasilData1.GetValue(4).ToString());

                double discPersen = double.Parse(hasilData1.GetValue(5).ToString());
                int discRph = int.Parse(hasilData1.GetValue(6).ToString());
                int dpp = int.Parse(hasilData1.GetValue(7).ToString());
                double ppnPersen = double.Parse(hasilData1.GetValue(8).ToString());
                int ppnRph = int.Parse(hasilData1.GetValue(9).ToString());
                int netto = int.Parse(hasilData1.GetValue(10).ToString());

                Pembelian nota = new Pembelian(noNota, tanggal, listSupplier[0], jumlah, discPersen, discRph, dpp, ppnPersen, ppnRph, netto);


                //string sql2 = "select nbd.id_barang_baku, nbd.quantity, nbd.harga, nbd.tanggal, nbd.supplier_id, nbd.jumlah" +
                //    " FROM nota_beli N INNER JOIN nota_beli_detail NBD ON N.NoNota = NBD.NoNota " +
                //    " INNER JOIN Tipe T ON NBD.KodeTipe = T.KodeTipe " +
                //    " WHERE N.NoNota = '" + noNota + "'";


                //MySqlDataReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);

                //while (hasilData2.Read() == true)
                //{
                //    //Barang yang terbeli 
                //    List<BahanBaku> listBhnBaku = BahanBaku.BacaData("B.kode", hasilData2.GetValue(0).ToString());

                //    int hargaJual = int.Parse(hasilData2.GetValue(2).ToString());

                //    int jumlah = int.Parse(hasilData2.GetValue(3).ToString());


                //    PembelianDetail detilBeli = new PembelianDetail(listBhnBaku[0], hargaJual, jumlah);


                //    nota.TambahPembelianDetil(listBhnBaku[0], hargaJual, jumlah);
                //}

               listHasilData.Add(nota);

            }
            return listHasilData;
        }

        public static void CetakNota(string pKriteria, string pNilaiKriteria, string pNamaFile, Font pFont)
        {
            List<Pembelian> listNotaBeli = new List<Pembelian>();

            //baca data nota tertentu yg akan dicetak
            listNotaBeli = Pembelian.BacaData(pKriteria, pNilaiKriteria);

            //simpan dulu isi nota yang akan ditampilkan ke objek file (StreamWriter)
            StreamWriter file = new StreamWriter(pNamaFile);

            foreach (Pembelian nota in listNotaBeli)
            {
                //tampilkan info perusahaan
                file.WriteLine("");
                file.WriteLine("REKAP PEMBELIAN");
                file.WriteLine("=".PadRight(50, '='));

                //tampilkan header nota
                file.WriteLine("No.Nota : " + nota.NoNota);
                file.WriteLine("Tanggal : " + nota.Tanggal);
                file.WriteLine("");
                file.WriteLine("=".PadRight(50, '='));

                //tampilkan barang yang terjual
                int grandTotal = 0; //untuk menampilkan grand total nota
                foreach (PembelianDetail nbd in nota.ListBeliDetail)
                {
                    //string nama = nbd.Tipe.Nama;
                    //jika nama terlalu panjang maka hanya tampilkan 30 karakter pertama saja
                    //if (nama.Length > 30)
                    //{
                    //    nama = nama.Substring(0, 30);
                    //}
                    int jumlah = nbd.Jumlah;
                    int harga = nbd.Harga;
                    int subTotal = jumlah * harga;
                    file.Write(jumlah.ToString().PadRight(3, ' '));
                    file.Write(harga.ToString("#,###").PadRight(7, ' ')); //agar harga ditampilkan dengan pemisah ribuan
                    file.Write(subTotal.ToString("#,###").PadRight(20, ' ')); //agar subTotal ditampilkan dengan pemisah ribuan
                    file.WriteLine("");
                    grandTotal += subTotal;
                }
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("TOTAL : " + grandTotal.ToString("#,###"));
                file.WriteLine("=".PadRight(50, '='));

                file.WriteLine("");
            }
            file.Close();
            //cetak ke printer
            //Cetak c = new Cetak(pNamaFile, pFont, 20, 10, 10, 10);
           // c.CetakKePrinter("text");
        }




        public static double HitungDisc(int jumlah, int persen)
        {
            double disc = 0;
            disc = (jumlah * persen) / 100; 
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
