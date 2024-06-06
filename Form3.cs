using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace U4A2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
    }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWrapping_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Form3_Load(object sender, EventArgs e)
        {
            txtPoints3.Text = Form4.SetValueForText1;
        }
    }
    }

