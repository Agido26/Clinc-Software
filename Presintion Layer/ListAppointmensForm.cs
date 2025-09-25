using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
namespace Presintion_Layer
{
    public partial class ListAppointmensForm : Form
    {
       
        public ListAppointmensForm()
        {
            InitializeComponent();

            _Load();
           
            
        }



       void SearchByPaitenName()
        {
            DataTable dt = clsPatients.FilterAppointmentsByPatienName(tbPatientSearch.Text);
            dgvAppointmentList.DataSource = dt;

        }

        private void _Load()
        {
            
            DataTable dt = clsCommon.ListAppointment();
            
                dgvAppointmentList.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchByPaitenName();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainScreen Home = new MainScreen();
            this.Close();
        }

        private void moreInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserInfo.Id=(int)dgvAppointmentList.SelectedCells[0].Value;
            PatientCardForm Form=new PatientCardForm();
            Form.ShowDialog();
        }
    }

}
