using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace U4A2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        public static string SetValueForText1 = "";
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtPricePaid.Text, out int PricePaid))
            {

                int points = (PricePaid * 100) / 2;


                txtPoints.Text = "" + points.ToString();
            }
            else
            {

                MessageBox.Show("Please Enter a Valid Amount of Money.");
            }

        }

        private void txtPricePaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPoints_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPricePaid.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))

            {

                MessageBox.Show("Enter a Username and Price Paid.");

                return;
            }

            SetValueForText1 = txtPoints.Text;

            MessageBox.Show("Points Added, Going To Redeem Page");
            Form3 RedeemForm = new Form3();
            RedeemForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lstRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
