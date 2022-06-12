using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSS_LIB
{
    public class DetailHPP
    {
        private string kode;
        private int quantity;
        private int harga;
        private int jumlah;

        public DetailHPP(string kode, int quantity, int harga, int jumlah)
        {
            this.Kode = kode;
            this.Quantity = quantity;
            this.Harga = harga;
            this.Jumlah = jumlah;
        }

        public string Kode { get => kode; set => kode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
    }
}
