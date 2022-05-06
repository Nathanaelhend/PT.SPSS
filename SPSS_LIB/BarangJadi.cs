using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class BarangJadi
    {
        private string kodeBarang;
        private string nama;
        private int stok;
        private KategoriBarang kategoriBarang;

        #region Constructors
        public BarangJadi(string kodeBarang, string nama, int stok, KategoriBarang kategoriBarang)
        {
            this.KodeBarang = kodeBarang;
            this.Nama = nama;
            this.Stok = stok;
            this.KategoriBarang = kategoriBarang;
        }
        #endregion

        #region Properties
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Stok { get => stok; set => stok = value; }
        public KategoriBarang KategoriBarang { get => kategoriBarang; set => kategoriBarang = value; }
        #endregion

        #region Methods
        public static void TambahData(BarangJadi b)
        {
            string sql = "insert into barang_jadi(kodeBarang, nama, stok, kategori_barang) values ('" +
                b.KodeBarang + "','" + b.Nama.Replace("'", "\\'") + "','" + b.Stok +
                "','" + b.KategoriBarang.Kode + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(BarangJadi b)
        {
            string sql = "update barang_jadi set nama='" + b.Nama.Replace("'", "\\'") + "',stok='" + b.Stok +
                "',kategori_barang='" + b.KategoriBarang.Kode + "' where kodeBarang='" + b.KodeBarang + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(BarangJadi b)
        {
            string sql = "delete from barang_jadi where kodeBarang='" + b.kodeBarang + "'";
            Koneksi.JalankanPerintahDML(sql);
        }


        public static List<BarangJadi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select B.kodeBarang, B.nama, B.stok, B.kategori_barang" +
                    " from barang_jadi B inner join kategori_barang_jadi KB on B.kategori_barang = KB.kode";
            }
            else
            {
                sql = "select B.kodeBarang, B.nama, B.stok, B.kategori_barang" +
                    " from barang_jadi B inner join kategori_barang_jadi KB on B.kategori_barang = KB.kode" +
                    " where " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);


            List<BarangJadi> listBrgJadi = new List<BarangJadi>();
            while (hasil.Read() == true)
            {
                KategoriBarang kb = new KategoriBarang(hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());

                BarangJadi b = new BarangJadi(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), kb);
                listBrgJadi.Add(b);
            }
            return listBrgJadi;
        }
        #endregion
    }
}
