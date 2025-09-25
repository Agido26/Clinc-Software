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
            button1.HoverState.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\log2.png");
            button1.PressedState.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\log3.png");
            btnAddApointment.HoverState.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\logo2.png");
            btnAddApointment.PressedState.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\logo3.png");
            btnListAppointment.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\List.png");
            btnListAppointment.HoverState.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\List1.png");
            btnListAppointment.PressedState.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\List2.png");
            pbLogo.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\code\\Clicn Software\\Presintion Layer\\UI\\Photo\\icons8-banana-64.png");
        }

        private void btnAddApointment_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddApointment_Click_1(object sender, EventArgs e)
        {
            AddAppointmentForm AddApointment = new AddAppointmentForm();
            AddApointment.ShowDialog();

        }

        private void btnListAppointment_Click_1(object sender, EventArgs e)
        {
            ListAppointmensForm List = new ListAppointmensForm();
            List.ShowDialog();
        }
    }
}
