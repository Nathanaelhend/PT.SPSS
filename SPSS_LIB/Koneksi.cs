using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SPSS_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        #endregion

        #region Constructors
        public Koneksi(string pserver, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pserver + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword;

            KoneksiDB = new MySqlConnection();

            koneksiDB.ConnectionString = strCon;

            Connect();
        }
        #endregion
        #region Methods
        public void Connect()
        {
            if(koneksiDB.State == System.Data.ConnectionState.Open)
            {
                koneksiDB.Close();
            }
            koneksiDB.Open();
        }
        #endregion
    }
}
