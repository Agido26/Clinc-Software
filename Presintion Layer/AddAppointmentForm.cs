using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presintion_Layer
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
            
        }

        clsPatients newPatient= new clsPatients();
        clsCommon Appointment = new clsCommon();
        DataTable dt = clsEmplyees.GetAllEmployees();
        int EmployeeID = -1;

        void _FillCbDoctors()
        {
            if (dt == null)
            {
                MessageBox.Show("No data available for doctors.");
                return;
            }
           
            foreach (DataRow dr in dt.Rows)
            {
                cbDoctors.Items.Add(dr["FirstName"]+" " +dr["LastName"]);
               
            }
           

        }

        void AddAppointmentInformation()
        {
            //patient Information
            newPatient.FirstName = tbFirstName.Text;
            newPatient.LastName = tbLastName.Text;
            newPatient.Phone = tbPhone.Text;
            newPatient.DateOfBirth = dtpBirth.Value;
            if (!newPatient.Save())
            { MessageBox.Show("Somthing wrong in Patient information"); }
           

                //Appointmaent Information
            Appointment.PatientID = newPatient.Id;
            Appointment.EmployeeID= EmployeeID;
            Appointment.AppointmentNote = tbNote.Text;
            Appointment.ApointmentDate = mcSchdeuale.SelectionEnd;


        }

        bool Validation()
        {
            bool valid=true;
            errorProvider1 = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                errorProvider1.SetError(tbFirstName, "First Name can't be empty");
                valid = false;
            }
            if(string.IsNullOrEmpty(tbLastName.Text))
            {
                errorProvider1.SetError(tbLastName, "Last Name can't be empty"); valid = false;

            }
            if (string.IsNullOrEmpty(tbPhone.Text) || !tbPhone.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(tbPhone, "Phone Number can't be empty"); valid = false;

            }

            if (!rbFemale.Checked && !rbMale.Checked)
            {
                errorProvider1.SetError(rbFemale, "Gender can't be unchecked"); valid = false;

            }
            if (string.IsNullOrEmpty(cbDoctors.Text))
            {
                errorProvider1.SetError(cbDoctors, "Can't Save until you choose doctor"); valid = false;

            }
            return valid;
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            _FillCbDoctors();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
           if(! Validation())
            { return; }

            EmployeeID =int.Parse(dt.Rows[cbDoctors.SelectedIndex][0].ToString());

            AddAppointmentInformation();
            if (Appointment.Save())
            { MessageBox.Show("Appointment was Added Succefully"); }
            else MessageBox.Show("Somthing Wrong");

        }
 
        private void RadioBoxGendor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                newPatient.Gendor = "F";
            }
            if (rbMale.Checked)
            {
                newPatient.Gendor = "M";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!Validation())
            { return; }

            EmployeeID = int.Parse(dt.Rows[cbDoctors.SelectedIndex][0].ToString());

            AddAppointmentInformation();
            if (Appointment.Save())
            { MessageBox.Show("Appointment was Added Succefully"); }
            else MessageBox.Show("Somthing Wrong");

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
