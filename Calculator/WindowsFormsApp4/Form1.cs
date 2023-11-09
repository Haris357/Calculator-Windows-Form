using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Calculator : Form
    {
        Double resultvalue = 0;
        String operationPerformed = "";
        bool isoperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isoperationPerformed))
                textBox1.Clear();

            isoperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else

                textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultvalue != 0)
            {
                button11.PerformClick();
                operationPerformed = button.Text;
                isoperationPerformed = true;
                label1.Text = resultvalue + "" + operationPerformed;
            }
            else
            {

                operationPerformed = button.Text;
                resultvalue = Double.Parse(textBox1.Text);
                isoperationPerformed = true;
                label1.Text = resultvalue + "" + operationPerformed;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultvalue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultvalue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultvalue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultvalue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
