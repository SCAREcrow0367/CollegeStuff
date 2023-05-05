using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int age;
            char rating;
            const int CHILD_AGE = 12;
            const int SENIOR_AGE = 65;
            age = Convert.ToChar(textBox1.Text);
            rating = Convert.ToChar(textBox2.Text);
            outputLabel.Text = String.Format
                ("When age is {0} and Rating is {1}", age, rating);
            if ((age <= CHILD_AGE || age >= SENIOR_AGE) && rating == 'G');
                outputLabel.Text += "\nDiscount applies";
            else 
                outputLabel.Text += "\nFull Price";
            
        }
    }
    }
}
