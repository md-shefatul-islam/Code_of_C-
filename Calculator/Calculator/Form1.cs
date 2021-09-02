using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operators = "";
        private bool action = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            result = 0;
        }

        private void btn1to9_click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            action = false;

            if (btn.Text == ".")
            {
                if (!this.txtDisplay.Text.Contains("."))
                {
                    this.txtDisplay.Text += btn.Text;
                }
            }
            else
            {
                this.txtDisplay.Text += btn.Text;
            }


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operators = btn.Text;
            result = Double.Parse(this.txtDisplay.Text);
            if (btn.Text == "+")
            {
                if (!this.txtDisplay.Text.Contains("+"))
                {
                    result = Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString() + operators;
                    action = true;
                }
            }
            else if (btn.Text == "-")
            {
                if (!this.txtDisplay.Text.Contains("-"))
                {
                    result = Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString() + operators;
                    action = true;
                }
            }
            else if (btn.Text == "*")
            {
                if (!this.txtDisplay.Text.Contains("*"))
                {
                    result = Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString() + operators;
                    action = true;
                }
            }
            else if (btn.Text == "/")
            {
                if (!this.txtDisplay.Text.Contains("/"))
                {
                    result = Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString() + operators;
                    action = true;
                }
            }
            else
            {
                this.txtDisplay.Text += btn.Text;
            }
            action = true;

        }



        private void btnEqual_Click(object sender, EventArgs e)
        {

            switch (operators)
            {
                case "+":
                   this.result = (result + Convert.ToDouble(this.txtDisplay.Text));

                    this.txtDisplay.Text = result.ToString();
                    break;

                case "-":
                    this.result = result - Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString();
                    break;

                case "*":
                   this.result = result * Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString();
                    break;

                case "/":
                   this.result = result / Convert.ToDouble(this.txtDisplay.Text);
                    this.txtDisplay.Text = result.ToString();
                      break;

                default:
                    break;
            }
        }

    }
}          
        

       // private void btnPercent_Click(object sender, EventArgs e)
       /* {
            Button btn = (Button)sender;
            result = Convert.ToDouble(this.txtDisplay.Text);
            value = result / 100;
            this.txtDisplay.Text = value.ToString();
            performed = true;
        }*/
    




