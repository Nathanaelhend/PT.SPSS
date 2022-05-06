using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace SPSS_LIB
{
    public class KategoriBarang
    {
        private string kode;
        private string keteranganBarang;

        #region Constructors
        public KategoriBarang(string kode, string keteranganBarang)
        {
            this.Kode = kode;
            this.KeteranganBarang = keteranganBarang;
        }
        #endregion

        #region Properties
        public string Kode { get => kode; set => kode = value; }
        public string KeteranganBarang { get => keteranganBarang; set => keteranganBarang = value; }
        #endregion

        #region Methods
        public static void TambahData(KategoriBarang kb)
        {
            string sql = "insert into kategori_barang_jadi(kode, keterangan_barang) values ('" + kb.Kode + "','" +
               kb.KeteranganBarang.Replace("'", "\\'") + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(KategoriBarang kb)
        {
            string sql = "update kategori_barang_jadi set keterangan_barang='" + kb.KeteranganBarang.Replace("'", "\\ '") + "'where kode='" + kb.Kode + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(KategoriBarang kb)
        {
            string sql = "delete from kategori_barang_jadi where kode='" + kb.Kode + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<KategoriBarang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from kategori_barang_jadi";
            }

            else
            {
                sql = "select * from kategori_barang_jadi where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<KategoriBarang> listKB = new List<KategoriBarang>();

            while (hasil.Read() == true)
            {
                KategoriBarang KB  = new KategoriBarang(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listKB.Add(KB);
            }

            return listKB;
        }
        #endregion
    }
}
