using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class HPP
    {
        private string noBukti;
        private DateTime tanggal;
        private DateTime deadline;
        private string brgJadi;
        private double quantity;
        private double jumlah;
        private double hpp;
        private List<DetailHPP> listDetailHPP;

        #region Constructors
        public HPP(string noBukti, DateTime tanggal, DateTime deadline, string brgJadi, double quantity, double jumlah, double hpp)
        {
            this.NoBukti = noBukti;
            this.Tanggal = tanggal;
            this.Deadline = deadline;
            this.BrgJadi = brgJadi;
            this.Quantity = quantity;
            this.Jumlah = jumlah;
            this.Hpp = hpp;
            this.ListDetailHPP = new List<DetailHPP>();
        }
        #endregion

        #region Properties
        public string NoBukti { get => noBukti; set => noBukti = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string BrgJadi { get => brgJadi; set => brgJadi = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Jumlah { get => jumlah; set => jumlah = value; }
        public double Hpp { get => hpp; set => hpp = value; }
        public List<DetailHPP> ListDetailHPP { get => listDetailHPP; set => listDetailHPP = value; }
        #endregion


        #region Methods
        public void TambahHPPDetil(string kode, double quantity, double harga, double jumlah)
        {
            DetailHPP detailHPP = new DetailHPP(kode, quantity, harga, jumlah);

            this.ListDetailHPP.Add(detailHPP);
        }

        public static void TambahData(HPP hpp)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    string sql1 = "insert into total_hpp(noBukti, tanggal, deadline, kodeBrgJadi, qty, jumlah, hpp) VALUES('" + hpp.NoBukti + "','" +
                                    hpp.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + hpp.Deadline.ToString("yyyy-MM-dd hh:mm:ss") + "','" + hpp.BrgJadi + "','" +
                                    hpp.Quantity + "','" + hpp.Jumlah + "','" + hpp.Hpp  + "')";

                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (DetailHPP hppDetail in hpp.ListDetailHPP)
                    {
                        string sql2 = "insert into detail_hpp(noBukti, tanggal, kodeBhnBaku, qty, harga, jumlah) VALUES('" + hpp.NoBukti + "','" +
                                       hpp.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + hppDetail.Kode + "','" + hppDetail.Quantity + "','" +
                                       hppDetail.Harga + "','" + hppDetail.Jumlah + "')";

                        Koneksi.JalankanPerintahDML(sql2);
                    }
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    throw (new Exception("Penyimpanan Data HPP gagal. Pesan Kesalahan : " + ex.Message));
                }

            }
        }

        public static List<HPP> BacaData(string kriteria, string nilaiKriteria, ref string nama)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT h.noBukti, h.tanggal, h.deadline, h.qty, h.jumlah, h.hpp, b.kodeBarang, b.nama" +
                    " FROM total_hpp h INNER JOIN barang_jadi b ON h.kodeBrgJadi = b.kodeBarang";
            }
            else
            {
                sql = "SELECT h.noBukti, h.tanggal, h.deadline, h.qty, h.jumlah, h.hpp, b.kodeBarang, b.nama" +
                    " FROM total_hpp h INNER JOIN barang_jadi b ON h.kodeBrgJadi = b.kodeBarang" +
                    " where " + kriteria + " LIKE '%" + nilaiKriteria + "%'";

            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);


            List<HPP> listHPP = new List<HPP>();
            
            while (hasil.Read() == true)
            {
                nama = hasil.GetValue(7).ToString();
                string brgJadi = hasil.GetValue(6).ToString();

                DateTime tanggal = DateTime.Parse(hasil.GetValue(1).ToString());

                DateTime deadline = DateTime.Parse(hasil.GetValue(2).ToString());

                HPP h = new HPP(hasil.GetValue(0).ToString(), tanggal, deadline, brgJadi, int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()), int.Parse(hasil.GetValue(5).ToString()));
                listHPP.Add(h);
            }
            return listHPP;
        }

        public static string TampilNama(string nama)
        {
            string sql = "SELECT nama FROM barang_jadi WHERE kodeBarang = " + nama;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string name = "";
            while (hasil.Read() == true)
            {
                name = hasil.GetValue(0).ToString();
            }
            return name;
        }

        public static double HitungHPP(double total, double quantity)
        {
            double hpp = total / quantity;
            return hpp;
        }

        public static double HitungTotalBB(double harga, double quantity)
        {
            double total = harga * quantity;
            return total;
        }

        public static double HitungJumlah(double harga, double total)
        {
            double jumlah = harga + total;
            return jumlah;
        }
        #endregion
    }
}
