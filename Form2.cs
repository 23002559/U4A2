using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4A2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }


            bool isUserValid = UserData.Users.Any(user =>  user.Password == txtPassword.Text && user.Email == txtEmail.Text);

            if (isUserValid)
            {
                MessageBox.Show("Login Successful");

            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }

            Form3 RedeemForm = new Form3();
           RedeemForm.Show();
            this.Hide();



        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)  || string.IsNullOrWhiteSpace(txtPassword.Text))

            {

                MessageBox.Show("All Fields Are Required.");

                return;
            }

            if (txtPassword.Text == "admin" && txtEmail.Text == "admin@admin.com")
            {
                MessageBox.Show("Admin Login Approved");

                Form4 AdminForm = new Form4();
                AdminForm.Show();
                this.Hide();
            }
            
                
        }
           
              
        }
        
    }

