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
        private double quantity;
        private double harga;
        private double jumlah;

        public DetailHPP(string kode, double quantity, double harga, double jumlah)
        {
            this.Kode = kode;
            this.Quantity = quantity;
            this.Harga = harga;
            this.Jumlah = jumlah;
        }

        public string Kode { get => kode; set => kode = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Harga { get => harga; set => harga = value; }
        public double Jumlah { get => jumlah; set => jumlah = value; }
    }
}
