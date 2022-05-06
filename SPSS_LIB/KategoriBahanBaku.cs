using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class KategoriBahanBaku
    {
        private string kodeBahan;
        private string keterangan_kategori;

        #region Constructors
        public KategoriBahanBaku(string kodeBahan, string keterangan_kategori)
        {
            this.KodeBahan = kodeBahan;
            this.Keterangan_kategori = keterangan_kategori;
        }
        #endregion

        #region Properties
        public string KodeBahan { get => kodeBahan; set => kodeBahan = value; }
        public string Keterangan_kategori { get => keterangan_kategori; set => keterangan_kategori = value; }
        #endregion

        #region Methods
        public static void TambahData(KategoriBahanBaku kbb)
        {
            string sql = "insert into kategori_bahan_baku(kode, keterangan_bahan_baku) values ('" + kbb.KodeBahan + "','" +
               kbb.Keterangan_kategori.Replace("'", "\\'") + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(KategoriBahanBaku kbb)
        {
            string sql = "update kategori_bahan_baku set keterangan_bahan_baku='" + kbb.Keterangan_kategori.Replace("'", "\\ '") + "'where kodeBahan='" + kbb.KodeBahan + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(KategoriBahanBaku kbb)
        {
            string sql = "delete from kategori_bahan_baku where kodeBahan='" + kbb.KodeBahan + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<KategoriBahanBaku> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from kategori_bahan_baku";
            }

            else
            {
                sql = "select * from kategori_bahan_baku where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<KategoriBahanBaku> listKBB = new List<KategoriBahanBaku>();

            while (hasil.Read() == true)
            {
                KategoriBahanBaku KBB = new KategoriBahanBaku(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listKBB.Add(KBB);
            }

            return listKBB;
        }
        #endregion

    }
}
