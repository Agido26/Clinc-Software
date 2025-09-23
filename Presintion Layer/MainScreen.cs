using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business;

namespace Presintion_Layer
{
    public partial class MainScreen : Form
    {


        public MainScreen()
        {
            InitializeComponent();
            lWelcome.Text= UserInfo.UserName;
        }

        private void btnAddApointment_Click(object sender, EventArgs e)
        {
            AddAppointmentForm AddApointment=new AddAppointmentForm();
            AddApointment.ShowDialog();

        }

        private void btnListAppointment_Click(object sender, EventArgs e)
        {
            ListAppointmensForm List=new ListAppointmensForm();
            List.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
