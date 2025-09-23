namespace Presintion_Layer
{
    partial class ListAppointmensForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAppointmentList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatientSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment List";
            // 
            // dgvAppointmentList
            // 
            this.dgvAppointmentList.AllowUserToAddRows = false;
            this.dgvAppointmentList.AllowUserToDeleteRows = false;
            this.dgvAppointmentList.AllowUserToOrderColumns = true;
            this.dgvAppointmentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentList.Location = new System.Drawing.Point(1, 233);
            this.dgvAppointmentList.Name = "dgvAppointmentList";
            this.dgvAppointmentList.Size = new System.Drawing.Size(906, 344);
            this.dgvAppointmentList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name";
            // 
            // tbPatientSearch
            // 
            this.tbPatientSearch.ForeColor = System.Drawing.Color.Silver;
            this.tbPatientSearch.Location = new System.Drawing.Point(280, 127);
            this.tbPatientSearch.Name = "tbPatientSearch";
            this.tbPatientSearch.Size = new System.Drawing.Size(190, 20);
            this.tbPatientSearch.TabIndex = 4;
            this.tbPatientSearch.Text = "Search for Patients Here";
            this.tbPatientSearch.Click += new System.EventHandler(this.tbPatientSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListAppointmensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 575);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPatientSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAppointmentList);
            this.Controls.Add(this.label1);
            this.Name = "ListAppointmensForm";
            this.Text = "List Of Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAppointmentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPatientSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}