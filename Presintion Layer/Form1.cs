using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business;

namespace Presintion_Layer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


       private void testaddnewpatient()
        {
            clsBusinessLayer NewPaitent = new clsBusinessLayer();

            NewPaitent.FirstName = "Ba";
            NewPaitent.LastName = "ra";
            NewPaitent.DateOfBirth = "2002-5-7";
            NewPaitent.Address = "Jeddah";
            NewPaitent.Gendor = "M";
            NewPaitent.Emaill = "B@gmail.com";
            NewPaitent.Phone = "045245";
            if(NewPaitent.Save() ==true)
            {
                MessageBox.Show("Yes:)");
            }
            else
            {
                MessageBox.Show("no:(");
            }
        }

        private void testFindPatient(int id)
        {
            clsBusinessLayer Patient1 =  clsBusinessLayer.Find(id);
            if (Patient1 != null)
            {
                MessageBox.Show(Patient1.FirstName + " " + Patient1.LastName);
            }
            else MessageBox.Show("There no patient with id "+id );


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hi");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            testFindPatient(4);
        }
    }
}
