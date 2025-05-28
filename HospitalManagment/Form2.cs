using System;
using System.Windows.Forms;

namespace HospitalManagment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Optional: Load data or initialize dashboard elements
        }

        private void btnManagePatients_Click(object sender, EventArgs e)
        {
            FormPatients form = new FormPatients();
            form.ShowDialog();
        }

        private void btnManageTreatments_Click(object sender, EventArgs e)
        {
            FormTreatments form = new FormTreatments();
            form.ShowDialog();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close this form and possibly go to login screen
            this.Close();
        }
    }
}
