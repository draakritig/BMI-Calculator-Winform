using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BMICalculator
{
    public partial class Form2 : Form
    {
        Form1 bmiForm = new Form1();
        public Form2()
        {    // Intializes Form 2       
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Loading of Form 2
            textResultBox.Show();
            textResultBox.Text = Form1.SaveResult;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            // For going back to Form 1 or main form
            this.Hide();
            Program.bmiCalculator.Show();
        }

        private void textResultBox_TextChanged(object sender, EventArgs e)
        {
            double bmiMsg = double.Parse(textResultBox.Text);

            if (bmiMsg < 18.5)
            {
                MessageBox.Show("You are Underweight!");
            }
            else if (bmiMsg >= 18.5 && bmiMsg <= 24.9)
            {
                MessageBox.Show("You are Healthy!");
            }
            else if ((bmiMsg >= 25 && bmiMsg <= 29.9))
            {
                MessageBox.Show("You are Overweight!");
            }
            else if ((bmiMsg >= 30 && bmiMsg <= 34.9))
            {
                MessageBox.Show("You are Obese!");
            }
            else if ((bmiMsg >= 35 && bmiMsg <= 39.9))
            {
                MessageBox.Show("You are Severely Obese!");
            }
            else if ((bmiMsg >= 40 && bmiMsg <= 49.9))
            {
                MessageBox.Show("You are Morbidly Obese!");
            }
            else
            {
                MessageBox.Show("You are Super Obese!");
            }
        }
    }
}
