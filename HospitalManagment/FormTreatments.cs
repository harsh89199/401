using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManagment
{
    public partial class FormTreatments : Form
    {
        public FormTreatments()
        {
            InitializeComponent();
        }

        private void FormTreatments_Load(object sender, EventArgs e)
        {
            // Optional: auto-load treatments on form load
            LoadTreatments();
        }

        private void btnLoadTreatments_Click(object sender, EventArgs e)
        {
            LoadTreatments();
        }

        private void LoadTreatments()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    // You can use direct table or stored procedure, both are shown below:
                    string query = "SELECT t.treatment_id, t.treatment_name, t.description, t.start_date, t.end_date, " +
                                   "CONCAT(d.first_name, ' ', d.last_name) AS doctor_name " +
                                   "FROM Treatments t JOIN Doctors d ON t.doctor_id = d.doctor_id";

                    // If using stored procedure instead:
                    // MySqlCommand cmd = new MySqlCommand("GetAllTreatments", conn);
                    // cmd.CommandType = CommandType.StoredProcedure;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewTreatments.DataSource = dt;
                    FormatTreatmentGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading treatments:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewTreatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can add custom logic here later (e.g., edit/delete row on click)
        }


        private void FormatTreatmentGrid()
        {
            if (dataGridViewTreatments.Columns.Count == 0) return;

            dataGridViewTreatments.Columns["treatment_id"].HeaderText = "ID";
            dataGridViewTreatments.Columns["treatment_name"].HeaderText = "Treatment";
            dataGridViewTreatments.Columns["description"].HeaderText = "Description";
            dataGridViewTreatments.Columns["start_date"].HeaderText = "Start Date";
            dataGridViewTreatments.Columns["end_date"].HeaderText = "End Date";
            dataGridViewTreatments.Columns["doctor_name"].HeaderText = "Assigned Doctor";

            dataGridViewTreatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTreatments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTreatments.ReadOnly = true;
        }
    }
}
