using DeveloperPerformanceTracker;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp5  // Sesuaikan dengan nama namespace Anda
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConn = new DatabaseConnection();
        private int selectedDevId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // METHOD INI YANG BELUM ADA - TAMBAHKAN!
        private void Form1_Load(object sender, EventArgs e)
        {
            // Test koneksi
            if (dbConn.TestConnection())
            {
                MessageBox.Show("Koneksi ke database berhasil!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Koneksi ke database gagal!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load data
            LoadProyek();
            LoadDeveloper();

            // Set dropdown status kontrak
            cmbStatusKontrak.Items.Add("freelance");
            cmbStatusKontrak.Items.Add("full time");
        }

        // METHOD INI YANG BELUM ADA - TAMBAHKAN!
        private void LoadProyek()
        {
            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_proyek, nama_proyek FROM proyek ORDER BY id_proyek";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            cmbProyek.DataSource = dt;
                            cmbProyek.DisplayMember = "nama_proyek";
                            cmbProyek.ValueMember = "id_proyek";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load proyek: " + ex.Message);
            }
        }

        // METHOD INI YANG BELUM ADA - TAMBAHKAN!
        private void LoadDeveloper()
        {
            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            d.id_dev,
                            d.nama_dev,
                            p.nama_proyek,
                            d.status_kontrak,
                            d.fitur_selesai,
                            d.jumlah_bug
                        FROM developer d
                        JOIN proyek p ON d.id_proyek = p.id_proyek
                        ORDER BY d.id_dev";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgDeveloper.DataSource = dt;

                            // Ubah nama kolom
                            dgDeveloper.Columns["id_dev"].HeaderText = "ID";
                            dgDeveloper.Columns["nama_dev"].HeaderText = "Nama Developer";
                            dgDeveloper.Columns["nama_proyek"].HeaderText = "Nama Proyek";
                            dgDeveloper.Columns["status_kontrak"].HeaderText = "Status Kontrak";
                            dgDeveloper.Columns["fitur_selesai"].HeaderText = "Fitur Selesai";
                            dgDeveloper.Columns["jumlah_bug"].HeaderText = "Jumlah Bug";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load developer: " + ex.Message);
            }
        }
    }
}