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
        private string keteranganKategori;

        #region Constructors
        public KategoriBahanBaku(string kodeBahan, string keteranganKategori)
        {
            this.KodeBahan = kodeBahan;
            this.KeteranganKategori = keteranganKategori;
        }
        #endregion

        #region Properties
        public string KodeBahan { get => kodeBahan; set => kodeBahan = value; }
        public string KeteranganKategori { get => keteranganKategori; set => keteranganKategori = value; }
        #endregion

        #region Methods
        public static void TambahData(KategoriBahanBaku kbb)
        {
            string sql = "insert into kategori_bahan_baku(kodeBahan, Nama) values ('" + kbb.KodeBahan + "','" +
               kbb.KeteranganKategori.Replace("'", "\\'") + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(KategoriBahanBaku kbb)
        {
            string sql = "update kategori_bahan_baku set Nama='" + kbb.KeteranganKategori.Replace("'", "\\ '") + "'where kodeBahan='" + kbb.KodeBahan + "'";
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
