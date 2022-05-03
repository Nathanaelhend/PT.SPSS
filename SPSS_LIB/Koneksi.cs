using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SPSS_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Constructors 
        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();

            koneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            Connect();
        }

        public Koneksi(string pserver, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pserver + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword;

            KoneksiDB = new MySqlConnection();

            koneksiDB.ConnectionString = strCon;

            Connect();

            UpdateAppConfig(strCon);
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

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

        public void UpdateAppConfig(string con)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = con;

            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void JalankanPerintahDML(string sql)
        {
            Koneksi koneksi = new Koneksi();
            koneksi.Connect();

            MySqlCommand command = new MySqlCommand(sql, koneksi.KoneksiDB);

            command.ExecuteNonQuery();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            k.Connect();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static string GetNamaServer()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return con.DataSource;
        }

        public static string GetNamaDatabase()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;
            return con.Database;
        }
        #endregion
    }
}
