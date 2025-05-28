namespace HospitalManagment
{
    partial class FormTreatments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();
            this.btnLoadTreatments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.AccessibleName = "dataGridViewTreatments";
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(144, 42);
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            this.dataGridViewTreatments.Size = new System.Drawing.Size(480, 233);
            this.dataGridViewTreatments.TabIndex = 0;
            this.dataGridViewTreatments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTreatments_CellContentClick);
            // 
            // btnLoadTreatments
            // 
            this.btnLoadTreatments.AccessibleName = "btnLoadTreatments";
            this.btnLoadTreatments.Location = new System.Drawing.Point(315, 302);
            this.btnLoadTreatments.Name = "btnLoadTreatments";
            this.btnLoadTreatments.Size = new System.Drawing.Size(162, 38);
            this.btnLoadTreatments.TabIndex = 1;
            this.btnLoadTreatments.Text = "btnLoadTreatments";
            this.btnLoadTreatments.UseVisualStyleBackColor = true;
            // 
            // FormTreatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadTreatments);
            this.Controls.Add(this.dataGridViewTreatments);
            this.Name = "FormTreatments";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormTreatments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTreatments;
        private System.Windows.Forms.Button btnLoadTreatments;
    }
}