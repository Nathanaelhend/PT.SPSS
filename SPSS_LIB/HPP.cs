﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
        public void TambahHPPDetil(BahanBaku bhnBaku, int quantity, int harga, int jumlah)
        {
            DetailHPP detailHPP = new DetailHPP(bhnBaku, quantity, harga, jumlah);

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
                                       hpp.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + hppDetail.BhnBaku.Kode + "','" + hppDetail.Quantity + "','" +
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
        #endregion
    }
}