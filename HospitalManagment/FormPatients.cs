using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManagment
{
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            // Optional: Automatically load data on form load
            // LoadPatients();
        }

        private void btnLoadPatients_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Patients";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewPatients.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }
    }
}
