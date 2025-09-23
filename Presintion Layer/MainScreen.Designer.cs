namespace Presintion_Layer
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListAppointment = new System.Windows.Forms.Button();
            this.btnAddApointment = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClincApp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(755, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Appointment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appointments List";
            // 
            // btnListAppointment
            // 
            this.btnListAppointment.BackgroundImage = global::Presintion_Layer.Properties.Resources.list;
            this.btnListAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListAppointment.Location = new System.Drawing.Point(559, 220);
            this.btnListAppointment.Name = "btnListAppointment";
            this.btnListAppointment.Size = new System.Drawing.Size(67, 54);
            this.btnListAppointment.TabIndex = 4;
            this.btnListAppointment.UseVisualStyleBackColor = true;
            this.btnListAppointment.Click += new System.EventHandler(this.btnListAppointment_Click);
            // 
            // btnAddApointment
            // 
            this.btnAddApointment.BackgroundImage = global::Presintion_Layer.Properties.Resources.Plus_for_new_Appointment_btn;
            this.btnAddApointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddApointment.FlatAppearance.BorderSize = 0;
            this.btnAddApointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddApointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApointment.Location = new System.Drawing.Point(788, 220);
            this.btnAddApointment.Name = "btnAddApointment";
            this.btnAddApointment.Size = new System.Drawing.Size(62, 57);
            this.btnAddApointment.TabIndex = 1;
            this.btnAddApointment.UseVisualStyleBackColor = false;
            this.btnAddApointment.Click += new System.EventHandler(this.btnAddApointment_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "list.png");
            this.imageList1.Images.SetKeyName(1, "Plus for new Appointment btn.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "Welcome ,";
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.Location = new System.Drawing.Point(340, 101);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(234, 55);
            this.lWelcome.TabIndex = 7;
            this.lWelcome.Text = "Welcome ,";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddApointment);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Clicn App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddApointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button button1;
    }
}

