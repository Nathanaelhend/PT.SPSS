using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class PenerimaanProduksi
    {
        private string noBukti;
        private DateTime tglPenerimaan;
        private string noHPP;
        private DateTime tglHpp;
        private string kodeBrgJadi;
        private string hasilProduksi;

        public PenerimaanProduksi(string noBukti, DateTime tglPenerimaan, string noHPP, DateTime tglHpp, string kodeBrgJadi, string hasilProduksi)
        {
            this.NoBukti = noBukti;
            this.TglPenerimaan = tglPenerimaan;
            this.NoHPP = noHPP;
            this.TglHpp = tglHpp;
            this.KodeBrgJadi = kodeBrgJadi;
            this.HasilProduksi = hasilProduksi;
        }

        public string NoBukti { get => noBukti; set => noBukti = value; }
        public DateTime TglPenerimaan { get => tglPenerimaan; set => tglPenerimaan = value; }
        public string NoHPP { get => noHPP; set => noHPP = value; }
        public DateTime TglHpp { get => tglHpp; set => tglHpp = value; }
        public string KodeBrgJadi { get => kodeBrgJadi; set => kodeBrgJadi = value; }
        public string HasilProduksi { get => hasilProduksi; set => hasilProduksi = value; }




        #region Methods
        public static void TambahData(PenerimaanProduksi p)
        {
            //string sql = "insert into penerimaan_produksi(noBukti, tanggalPenerimaan, noBuktiHPP, tanggalOrderPotong, kodeBrgJadi, hasilProduksi) values ('" +
            //    p.NoBukti + "','" + p.TglPenerimaan.ToString("yyyy-MM-dd hh:mm:ss") + "','" + p.noHPP +
            //    "','" + p.TglHpp.ToString("yyyy-MM-dd hh:mm:ss") + "','" + p.KodeBrgJadi + "','" + p.HasilProduksi + "')";

            string sql = "insert into penerimaan_produksi(noBukti, tanggalPenerimaan, noBuktiHPP, tanggalOrderPotong, hasilProduksi, kodeBrgJadi) VALUES('" + p.NoBukti + "','" +
                          p.TglPenerimaan.ToString("yyyy-MM-dd hh:mm:ss") + "','" + p.NoHPP + "','" + p.TglHpp.ToString("yyyy-MM-dd hh:mm:ss") + "','" +
                          p.HasilProduksi + "','" + p.KodeBrgJadi + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        //public static void SisaProduksi(PenerimaanProduksi p)
        //{
        //    string sql = "SELECT SUM(penerimaan_produksi.hasilProduksi) , (total_hpp.qty - SUM(penerimaan_produksi.hasilProduksi)) FROM penerimaan_produksi" +
        //                 "INNER JOIN total_hpp ON penerimaan_produksi.noBuktiHPP = total_hpp.noBukti WHERE penerimaan_produksi.noBuktiHPP = 'UP001'";
        //}
        #endregion
    }
}
