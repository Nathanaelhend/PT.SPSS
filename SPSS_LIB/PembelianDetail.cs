using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSS_LIB
{
    public class PembelianDetail
    {
        private BahanBaku bhnBaku;
        private int quantity;
        private int harga;
        private int jumlah;
        private double discPersen;
        private int discRph;
        private int totalHarga;

        #region Constructors
        public PembelianDetail(BahanBaku bhnBaku, int quantity, int harga, int jumlah, double discPersen, int discRph, int totalHarga)
        {
            this.BhnBaku = bhnBaku;
            this.Quantity = quantity;
            this.Harga = harga;
            this.Jumlah = jumlah;
            this.DiscPersen = discPersen;
            this.DiscRph = discRph;
            this.TotalHarga = totalHarga;
        }
        #endregion

        #region Properties
        public BahanBaku BhnBaku { get => bhnBaku; set => bhnBaku = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public double DiscPersen { get => discPersen; set => discPersen = value; }
        public int DiscRph { get => discRph; set => discRph = value; }
        public int TotalHarga { get => totalHarga; set => totalHarga = value; }
        #endregion

    }
}
