using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator calculator = new Calculator();
        public int FstNbr;
        public int scnNbr;
        public double rst;
        public int Add;
        public int Subtract;
        public int Multiply;
        public double Divide;
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("First text Can not be empty ");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second text Can not be empty ");
                return;
            }


            FstNbr = calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
           scnNbr = calculator.SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);
         

            Add = FstNbr + scnNbr;
            resultTextBox.Text = Add.ToString();

            MessageBox.Show("Add: " + Add);


        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("First text Can not be empty ");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second text Can not be empty ");
                return;
            }


            FstNbr = calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            scnNbr = calculator.SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            Subtract = FstNbr - scnNbr;
            resultTextBox.Text =Subtract.ToString();

            MessageBox.Show("Add: " + Subtract);

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("First text Can not be empty ");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second text Can not be empty ");
                return;
            }


            FstNbr = calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            scnNbr = calculator.SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            Multiply = FstNbr * scnNbr;
            resultTextBox.Text = Multiply.ToString();

            MessageBox.Show("Add: " + Multiply);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                MessageBox.Show("First text Can not be empty ");
                return;
            }

            if (String.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Second text Can not be empty ");
                return;
            }


            FstNbr = calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            scnNbr = calculator.SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            Divide = FstNbr / scnNbr;
            resultTextBox.Text = Divide.ToString();

            MessageBox.Show("Add: " + Divide);
        }
    }
}
