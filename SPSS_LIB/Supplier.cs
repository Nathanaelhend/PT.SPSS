using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class Supplier
    {
        private string kodeSupplier;
        private string nama;
        private string alamat;
        private string kota;

        #region Constructors
        public Supplier(string kodeSupplier, string nama, string alamat, string kota)
        {
            this.KodeSupplier = kodeSupplier;
            this.Nama = nama;
            this.Alamat = alamat;
            this.Kota = kota;
        }
        #endregion

        #region Properties
        public string KodeSupplier { get => kodeSupplier; set => kodeSupplier = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region Methods
        public static void TambahData(Supplier s)
        {
            string sql = "insert into supplier(kodeSupplier, nama, alamat, kota)" +
                " values ('" + s.KodeSupplier + "','" +
                s.Nama.Replace("'", "\\'") + "','" + s.Alamat + "','" + s.Kota + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Supplier s)
        {
            string sql = "update supplier set nama='" + s.Nama.Replace("'", "\\'") + "',alamat ='" + s.Alamat + "'," + "kota ='" + s.Kota + "'where kodeSupplier='" + s.KodeSupplier + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Supplier> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from supplier";
            }
            else
            {
                sql = "select * from supplier where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Supplier> listSupplier = new List<Supplier>();

            while (hasil.Read() == true)
            {
                Supplier s = new Supplier(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                listSupplier.Add(s);
            }
            return listSupplier;
        }

        public static string HapusData(Supplier s)
        {
            string sql = "DELETE FROM supplier WHERE kodeSupplier = '" + s.KodeSupplier + "'";
            try
            {
                Koneksi.JalankanPerintahDML(sql);
                return "1";
            }
            catch (MySqlException ex)
            {
                return ex.Message + ". Perintah sql : " + sql;
            }
        }
        #endregion

    }
}
