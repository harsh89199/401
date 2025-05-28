using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HospitalManagment
{
    public partial class Form1 : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "server=127.0.0.1;user=root;password=C0ventryCUC;database=example;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM LoginUsers WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form2 dashboard = new Form2();
                                dashboard.FormClosed += (s, args) => this.Show();
                                dashboard.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleName = "txtUsername";
            this.txtUsername.Location = new System.Drawing.Point(221, 119);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(221, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "btnLogin";
            this.btnLogin.Location = new System.Drawing.Point(221, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(243, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 354);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.btnLogin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
