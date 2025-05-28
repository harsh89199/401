namespace HospitalManagment
{
    partial class FormPatients
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button btnLoadPatients;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.btnLoadPatients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(30, 80);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewPatients.TabIndex = 0;
            // 
            // btnLoadPatients
            // 
            this.btnLoadPatients.Location = new System.Drawing.Point(30, 30);
            this.btnLoadPatients.Name = "btnLoadPatients";
            this.btnLoadPatients.Size = new System.Drawing.Size(120, 30);
            this.btnLoadPatients.TabIndex = 1;
            this.btnLoadPatients.Text = "Load Patients";
            this.btnLoadPatients.UseVisualStyleBackColor = true;
            this.btnLoadPatients.Click += new System.EventHandler(this.btnLoadPatients_Click);
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.btnLoadPatients);
            this.Controls.Add(this.dataGridViewPatients);
            this.Name = "FormPatients";
            this.Text = "Manage Patients";
            this.Load += new System.EventHandler(this.FormPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
