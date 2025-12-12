using Npgsql;
using System;
using System.Data;

namespace DeveloperPerformanceTracker
{
    public class DatabaseConnection
    {
        // Connection string ke PostgreSQL
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=100805;Database=db_developer_tracker";

        // Method untuk mendapatkan koneksi
        public NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Koneksi gagal: " + ex.Message);
            }
        }

        // Method untuk test koneksi
        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}