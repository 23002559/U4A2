using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace U4A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))

            {

                MessageBox.Show("All fields are required.");

                return;

            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }




            User newUser = new User(txtEmail.Text, txtFullName.Text,  txtPassword.Text);

            UserData.Users.Add(newUser);

        


            Form2 loginForm = new Form2();

            loginForm.Show();

            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtFullName.Text)  || string.IsNullOrWhiteSpace(txtPassword.Text))

            {

                MessageBox.Show("All fields are required.");

                return;

            }
           

            if (txtFullName.Text == "admin" && txtPassword.Text == "admin" && txtEmail.Text == "admin@admin.com")
            {
                MessageBox.Show("Admin Login Approved");

                Form4 AdminForm = new Form4();
                AdminForm.Show();
                this.Hide();
            }

            
        }
    }
}
