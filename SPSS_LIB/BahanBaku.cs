using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class BahanBaku
    {
        private string kode;
        private string nama;
        private int harga;
        private string satuan;
        private KategoriBahanBaku kategoriBhnBaku;

        #region Constructors
        public BahanBaku(string kode, string nama, int harga, string satuan, KategoriBahanBaku kategoriBhnBaku)
        {
            this.Kode = kode;
            this.Nama = nama;
            this.Harga = harga;
            this.Satuan = satuan;
            this.KategoriBhnBaku = kategoriBhnBaku;
        }
        #endregion

        #region Properties
        public string Kode { get => kode; set => kode = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Harga { get => harga; set => harga = value; }
        public string Satuan { get => satuan; set => satuan = value; }
        public KategoriBahanBaku KategoriBhnBaku { get => kategoriBhnBaku; set => kategoriBhnBaku = value; }
        #endregion

        #region Methods
        public static void TambahData(BahanBaku b)
        {
            string sql = "insert into bahan_baku(kode, nama, harga, satuan, kodeKatBahanBaku) values ('" +
                b.Kode + "','" + b.Nama.Replace("'", "\\'") + "','" +
                b.Harga + "','" + b.Satuan + "','" + b.KategoriBhnBaku.KodeBahan + "')";
            Koneksi.JalankanPerintahDML(sql);   
        }

        public static void UbahData(BahanBaku b)
        {
            string sql = "update bahan_baku set nama='" + b.Nama.Replace("'", "\\'") + "',harga='" + b.Harga + "',satuan='" + b.Satuan +
                "',kodeKatBahanBaku='" + b.KategoriBhnBaku.KodeBahan + "' where kode='" + b.Kode + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(BahanBaku b)
        {
            string sql = "delete from bahan_baku where kode='" + b.Kode + "'";
            Koneksi.JalankanPerintahDML(sql);
        }


        public static List<BahanBaku> BacaData(string nilaiKriteria)
        {
            string sql = "";
            //if (kriteria == "")
            //{
            //    sql = "select B.kode, B.nama, B.harga, B.satuan, B.kodeKatBahanBaku, KBB.Nama" +
            //        " from bahan_baku B inner join kategori_bahan_baku KBB on B.kodeKatBahanBaku = KBB.kodeBahan";
            //    //sql = "SELECT harga FROM nota_beli_detail ORDER BY nota_beli_detail.tanggal DESC LIMIT 1";
            //}
            //else
            //{
                sql = "select B.kode, B.nama, B.harga, B.satuan, B.kodeKatBahanBaku, KBB.Nama" +
                    " from bahan_baku B inner join kategori_bahan_baku KBB on B.kodeKatBahanBaku = KBB.kodeBahan" +
                    " where " + "B.nama" + " LIKE '%" + nilaiKriteria + "%'";

                //sql = "SELECT nota_beli_detail.nomor_nota_beli, nota_beli_detail.tanggal, nota_beli_detail.id_barang_baku, " +
                //      "nota_beli_detail.harga FROM nota_beli_detail" + " WHERE  " + kriteria + " LIKE '%" + nilaiKriteria + "%'" +
                //      "ORDER BY nota_beli_detail.tanggal DESC LIMIT 1";
            //}

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);


            List<BahanBaku> listBhnBaku = new List<BahanBaku>();
            while (hasil.Read() == true)
            {
                KategoriBahanBaku kbb = new KategoriBahanBaku(hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString());

                BahanBaku b = new BahanBaku(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), hasil.GetValue(3).ToString(), kbb);
                listBhnBaku.Add(b);
            }
            return listBhnBaku;
        }

        public static List<BahanBaku> BacaLastPrice(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                //sql = "SELECT nbd.id_barang_baku, b.nama, nbd.harga, b.satuan, b.kodeKatBahanBaku, kbb.Nama FROM nota_beli_detail nbd " + 
                //      " INNER JOIN bahan_baku b ON nbd.id_barang_baku = b.kode inner join kategori_bahan_baku kbb on b.kodeKatBahanBaku = kbb.kodeBahan WHERE id_barang_baku = nbd.id_barang_baku ORDER BY nbd.tanggal DESC LIMIT 1";
                sql = "SELECT nbd.id_barang_baku, b.nama, nbd.harga, b.satuan, b.kodeKatBahanBaku, kbb.Nama " +
                    " FROM bahan_baku b INNER JOIN nota_beli_detail nbd ON b.kode = nbd.id_barang_baku INNER JOIN kategori_bahan_baku kbb ON b.kodeKatBahanBaku = kbb.kodeBahan, " +
                    " (SELECT id_barang_baku,MAX(tanggal)AS tanggal,harga FROM nota_beli_detail GROUP BY id_barang_baku) max_sales where nbd.id_barang_baku=max_sales.id_barang_baku and nbd.tanggal=max_sales.tanggal";

            }
            else
            {
                //sql = "select * from supplier where " + kriteria + " like '%" + nilaiKriteria + "%'";
                sql = "SELECT nbd.id_barang_baku, b.nama, nbd.harga, b.satuan, b.kodeKatBahanBaku, kbb.Nama FROM nota_beli_detail nbd " +
                      " INNER JOIN bahan_baku b ON nbd.id_barang_baku = b.kode inner join kategori_bahan_baku kbb on b.kodeKatBahanBaku = kbb.kodeBahan " +
                      " WHERE id_barang_baku = nbd.id_barang_baku ORDER BY nbd.tanggal DESC LIMIT 1";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<BahanBaku> listBhnBaku = new List<BahanBaku>();

            while (hasil.Read() == true)
            {
                KategoriBahanBaku kbb = new KategoriBahanBaku(hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString());

                BahanBaku b = new BahanBaku(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), hasil.GetValue(3).ToString(), kbb);
                listBhnBaku.Add(b);
            }
            return listBhnBaku;
        }
        #endregion
    }
}
