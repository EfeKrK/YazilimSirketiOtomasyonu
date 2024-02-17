using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazilimSirketiOtomasyonu
{
    internal class BaglantiDB
    {
        private string ConnectionString = "Data Source=EFEKRK;Initial Catalog=MarketYonetimSistemi;Integrated Security=True";
        private SqlConnection connection;

        public BaglantiDB()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public void BaglantiOpen()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    Console.WriteLine("Veritabanı bağlantısı açıldı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanı bağlantısı açılırken hata oluştu: " + ex.Message);
            }
        }

        public void BaglantiClose()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                    Console.WriteLine("Veritabanı bağlantısı kapatıldı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanı bağlantısı kapatılırken hata oluştu: " + ex.Message);
            }

        }
    }
}
