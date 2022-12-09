using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class PembelianDetail
    {
        private string kode;
        private int quantity;
        private int harga;
        private int jumlah;
        private double discPersen;
        private int discRph;
        private int totalHarga;

        #region Constructors
        public PembelianDetail(string kode, int quantity, int harga, int jumlah, double discPersen, int discRph, int totalHarga)
        {
            this.Kode = kode;
            this.Quantity = quantity;
            this.Harga = harga;
            this.Jumlah = jumlah;
            this.DiscPersen = discPersen;
            this.DiscRph = discRph;
            this.TotalHarga = totalHarga;
        }
        #endregion

        #region Properties
        public string Kode { get => kode; set => kode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public double DiscPersen { get => discPersen; set => discPersen = value; }
        public int DiscRph { get => discRph; set => discRph = value; }
        public int TotalHarga { get => totalHarga; set => totalHarga = value; }
        #endregion
    }
}
