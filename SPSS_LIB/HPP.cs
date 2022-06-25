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
        private BarangJadi brgJadi;
        private int quantity;
        private int jumlah;
        private int hpp;
        private List<DetailHPP> listDetailHPP;

        #region Constructors
        public HPP(string noBukti, DateTime tanggal, DateTime deadline, BarangJadi brgJadi, int quantity, int jumlah, int hpp)
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
        public BarangJadi BrgJadi { get => brgJadi; set => brgJadi = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public int Hpp { get => hpp; set => hpp = value; }
        public List<DetailHPP> ListDetailHPP { get => listDetailHPP; set => listDetailHPP = value; }
        #endregion


        #region Methods
        public void TambahHPPDetil(string kode, int quantity, int harga, int jumlah)
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
                                    hpp.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + hpp.Deadline.ToString("yyyy-MM-dd hh:mm:ss") + "','" + hpp.BrgJadi.KodeBarang + "','" +
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

        public static List<HPP> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT h.noBukti, h.tanggal, h.deadline, h.qty, h.jumlah, h.hpp, b.kodeBarang, b.nama" +
                    "FROM total_hpp h INNER JOIN barang_jadi b ON h.kodeBrgJadi = b.kodeBarang";
            }
            else
            {
                sql = "SELECT h.noBukti, h.tanggal, h.deadline, h.qty, h.jumlah, h.hpp, b.kodeBarang, b.nama" +
                    "FROM total_hpp h INNER JOIN barang_jadi b ON h.kodeBrgJadi = b.kodeBarang" +
                    " where " + kriteria + " LIKE '%" + nilaiKriteria + "%'";

            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);


            List<HPP> listHPP = new List<HPP>();
            while (hasil.Read() == true)
            { 
                List<BarangJadi> listBrgJadi = BarangJadi.BacaData("kodeBarang", hasil.GetValue(3).ToString());

                HPP h = new HPP(hasil.GetValue(0).ToString(), DateTime.Parse(hasil.GetValue(1).ToString()), DateTime.Parse(hasil.GetValue(2).ToString()), listBrgJadi[0], int.Parse(hasil.GetValue(4).ToString()), int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()));
                listHPP.Add(h);
            }
            return listHPP;
        }



        public static int HitungHPP(int total, int quantity)
        {
            int hpp = total / quantity;
            return hpp;
        }

        public static int HitungTotalBB(int harga, int quantity)
        {
            int total = harga * quantity;
            return total;
        }

        public static int HitungJumlah(int harga, int total)
        {
            int jumlah = harga + total;
            return jumlah;
        }
        #endregion
    }
}
