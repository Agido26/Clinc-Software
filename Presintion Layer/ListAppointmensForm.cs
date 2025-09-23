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

        private void button1_Click(object sender, EventArgs e)
        {
            SearchByPaitenName();
        }

        private void tbPatientSearch_Click(object sender, EventArgs e)
        {

            if (tbPatientSearch.ForeColor == System.Drawing.Color.Silver)
            {
                tbPatientSearch.Text = "";
                tbPatientSearch.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainScreen Home=new MainScreen();
            this.Close();
        }
    }

}
