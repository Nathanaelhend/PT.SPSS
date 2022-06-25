using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSS_LIB
{
    public class PenerimaanProduksi
    {
        private string noBukti;
        private DateTime tglPenerimaan;
        private HPP hpp;
        private BahanBaku bhnBaku;
        private string hasilProduksi;

        #region Constructors
        public PenerimaanProduksi(string noBukti, DateTime tglPenerimaan, HPP hpp, BahanBaku bhnBaku, string hasilProduksi)
        {
            this.NoBukti = noBukti;
            this.TglPenerimaan = tglPenerimaan;
            this.Hpp = hpp;
            this.BhnBaku = bhnBaku;
            this.HasilProduksi = hasilProduksi;
        }
        #endregion

        #region Properties
        public string NoBukti { get => noBukti; set => noBukti = value; }
        public DateTime TglPenerimaan { get => tglPenerimaan; set => tglPenerimaan = value; }
        public HPP Hpp { get => hpp; set => hpp = value; }
        public BahanBaku BhnBaku { get => bhnBaku; set => bhnBaku = value; }
        public string HasilProduksi { get => hasilProduksi; set => hasilProduksi = value; }
        #endregion


        #region Methods
        public static void TambahData(PenerimaanProduksi p)
        {
            string sql = "insert into penerimaan_produksi(noBukti, tanggalPenerimaan, noBuktiHPP, tanggalOrderPotong, kodeBhnBaku, hasilProduksi) values ('" +
                p.NoBukti + "','" + p.TglPenerimaan.ToString("yyyy-MM-dd hh:mm:ss") + "','" + p.Hpp.NoBukti +
                "','" + p.Hpp.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + p.BhnBaku.Kode + p.HasilProduksi + "','" + "')";
            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}
