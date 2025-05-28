namespace HospitalManagment
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnManagePatients = new System.Windows.Forms.Button();
            this.btnPatientRecords = new System.Windows.Forms.Button();
            this.btnManageDoctors = new System.Windows.Forms.Button();
            this.btnManageNurses = new System.Windows.Forms.Button();
            this.btnManageTreatments = new System.Windows.Forms.Button();
            this.btnAssignTreatment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagePatients
            // 
            this.btnManagePatients.Location = new System.Drawing.Point(55, 24);
            this.btnManagePatients.Name = "btnManagePatients";
            this.btnManagePatients.Size = new System.Drawing.Size(252, 23);
            this.btnManagePatients.TabIndex = 0;
            this.btnManagePatients.Text = "Manage Patients";
            this.btnManagePatients.UseVisualStyleBackColor = true;
            this.btnManagePatients.Click += new System.EventHandler(this.btnManagePatients_Click);
            // 
            // btnPatientRecords
            // 
            this.btnPatientRecords.Location = new System.Drawing.Point(55, 72);
            this.btnPatientRecords.Name = "btnPatientRecords";
            this.btnPatientRecords.Size = new System.Drawing.Size(252, 23);
            this.btnPatientRecords.TabIndex = 1;
            this.btnPatientRecords.Text = "Patient Records";
            this.btnPatientRecords.UseVisualStyleBackColor = true;
            // 
            // btnManageDoctors
            // 
            this.btnManageDoctors.Location = new System.Drawing.Point(55, 192);
            this.btnManageDoctors.Name = "btnManageDoctors";
            this.btnManageDoctors.Size = new System.Drawing.Size(252, 23);
            this.btnManageDoctors.TabIndex = 2;
            this.btnManageDoctors.Text = "Manage Doctors";
            this.btnManageDoctors.UseVisualStyleBackColor = true;
            // 
            // btnManageNurses
            // 
            this.btnManageNurses.Location = new System.Drawing.Point(536, 192);
            this.btnManageNurses.Name = "btnManageNurses";
            this.btnManageNurses.Size = new System.Drawing.Size(252, 23);
            this.btnManageNurses.TabIndex = 3;
            this.btnManageNurses.Text = "Manage Nurses";
            this.btnManageNurses.UseVisualStyleBackColor = true;
            // 
            // btnManageTreatments
            // 
            this.btnManageTreatments.Location = new System.Drawing.Point(536, 24);
            this.btnManageTreatments.Name = "btnManageTreatments";
            this.btnManageTreatments.Size = new System.Drawing.Size(252, 23);
            this.btnManageTreatments.TabIndex = 4;
            this.btnManageTreatments.Text = "Manage Treatments";
            this.btnManageTreatments.UseVisualStyleBackColor = true;
            this.btnManageTreatments.Click += new System.EventHandler(this.btnManageTreatments_Click);
            // 
            // btnAssignTreatment
            // 
            this.btnAssignTreatment.Location = new System.Drawing.Point(536, 72);
            this.btnAssignTreatment.Name = "btnAssignTreatment";
            this.btnAssignTreatment.Size = new System.Drawing.Size(252, 23);
            this.btnAssignTreatment.TabIndex = 5;
            this.btnAssignTreatment.Text = "Assign Treatment";
            this.btnAssignTreatment.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(324, 285);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAssignTreatment);
            this.Controls.Add(this.btnManageTreatments);
            this.Controls.Add(this.btnManageNurses);
            this.Controls.Add(this.btnManageDoctors);
            this.Controls.Add(this.btnPatientRecords);
            this.Controls.Add(this.btnManagePatients);
            this.Name = "Form2";
            this.Text = "Hospital Management Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnManagePatients;
        private System.Windows.Forms.Button btnPatientRecords;
        private System.Windows.Forms.Button btnManageDoctors;
        private System.Windows.Forms.Button btnManageNurses;
        private System.Windows.Forms.Button btnManageTreatments;
        private System.Windows.Forms.Button btnAssignTreatment;
        private System.Windows.Forms.Button btnLogout;
    }
}
