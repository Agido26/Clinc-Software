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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void CheckForUser()
        {
            if (clsEmplyees.IsEmployeeExist(tbUser.Text, tbPasssword.Text))
            {

                UserInfo  user=new UserInfo();
                UserInfo.UserName = clsEmplyees.GetNameifEmployeeExist(tbUser.Text,tbPasssword.Text);
                MainScreen mainScreen = new MainScreen();
                this.Hide();
                tbPasssword.Text = "";
                tbUser.Text = "";
                mainScreen.ShowDialog();
                this.Show();

            }
            else { MessageBox.Show("User or passwrd was wrong try again"); }
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            CheckForUser();  
        }

       
        private void tbPasssword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_MouseEnter(object sender, EventArgs e)
        {
            tbPasssword.UseSystemPasswordChar = false;
        }

        private void guna2ImageButton1_MouseLeave(object sender, EventArgs e)
        {
            tbPasssword.UseSystemPasswordChar = true;

        }
    }
}
