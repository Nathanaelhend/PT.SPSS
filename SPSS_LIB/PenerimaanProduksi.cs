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

        
        #endregion
    }
}
