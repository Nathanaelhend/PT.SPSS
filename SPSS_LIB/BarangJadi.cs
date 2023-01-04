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
        private int harga;
        private string satuan;
        private KategoriBarang kategoriBarang;

        #region Constructors
        public BarangJadi(string kodeBarang, string nama, int harga, string satuan, KategoriBarang kategoriBarang)
        {
            this.KodeBarang = kodeBarang;
            this.Nama = nama;
            this.Harga = harga;
            this.Satuan = satuan;
            this.KategoriBarang = kategoriBarang;
        }
        #endregion

        #region Properties
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Harga { get => harga; set => harga = value; }
        public string Satuan { get => satuan; set => satuan = value; }
        public KategoriBarang KategoriBarang { get => kategoriBarang; set => kategoriBarang = value; }
        #endregion

        #region Methods
        public static void TambahData(BarangJadi b)
        {
            string sql = "insert into barang_jadi(kodeBarang, nama, harga, satuan, kodeKategori) values ('" +
                b.KodeBarang + "','" + b.Nama.Replace("'", "\\'") + "','" + b.Harga +
                "','" + b.Satuan + "','" + b.KategoriBarang.Kode + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(BarangJadi b)
        {
            string sql = "update barang_jadi set nama='" + b.Nama.Replace("'", "\\'") + "',harga='" + b.Harga + "',satuan='" + b.Satuan +
                 "',kodeKategori='" + b.KategoriBarang.Kode + "' where kodeBarang='" + b.KodeBarang + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(BarangJadi b)
        {
            string sql = "delete from barang_jadi where kodeBarang='" + b.KodeBarang + "'";
            Koneksi.JalankanPerintahDML(sql);
        }


        public static List<BarangJadi> BacaData(string nilaiKriteria)
        {
            string sql = "";
            //if (kriteria == "")
            //{
            //    sql = "select B.kodeBarang, B.nama, B.harga, B.satuan, B.kodeKategori, KB.keteranganBarang" +
            //        " from barang_jadi B inner join kategori_barang_jadi KB on B.kodeKategori = KB.kode";
            //}
            //else
            //{
                sql = "select B.kodeBarang, B.nama, B.harga, B.satuan, B.kodeKategori, KB.keteranganBarang" +
                    " from barang_jadi B inner join kategori_barang_jadi KB on B.kodeKategori = KB.kode" +
                    " where  B.nama "+ " LIKE '%" + nilaiKriteria + "%'";
            //}

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);


            List<BarangJadi> listBrgJadi = new List<BarangJadi>();
            while (hasil.Read() == true)
            {
                KategoriBarang kb = new KategoriBarang(hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());

                BarangJadi b = new BarangJadi(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()), hasil.GetValue(3).ToString(), kb);
                listBrgJadi.Add(b);
            }
            return listBrgJadi;
        }
        #endregion
    }
}
