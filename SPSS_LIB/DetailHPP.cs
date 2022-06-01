using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSS_LIB
{
    public class DetailHPP
    {
        private BahanBaku bhnBaku;
        private int quantity;
        private int harga;
        private int jumlah;

        #region Constructors
        public DetailHPP(BahanBaku bhnBaku, int quantity, int harga, int jumlah)
        {
            this.BhnBaku = bhnBaku;
            this.Quantity = quantity;
            this.Harga = harga;
            this.Jumlah = jumlah;
        }
        #endregion

        #region Properties
        public BahanBaku BhnBaku { get => bhnBaku; set => bhnBaku = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        #endregion


    }
}
