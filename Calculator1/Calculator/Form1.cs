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
        private double result = 0, value=0;
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

        private void btnNum_click(object sender, EventArgs e)
        {
            if (action == true)
            {
                this.txtDisplay.Clear();
                if (operators == "")
                {
                    result = 0;
                }
            }

            Button btn = (Button)sender;           
            if (btn.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    this.txtDisplay.Text = this.txtDisplay.Text + btn.Text;
                    action = false;
                }
            }
            else
            {
                this.txtDisplay.Text = this.txtDisplay.Text + btn.Text;    
                action = false;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {    
            Button btnOperator = (Button)sender;          
            if (result != 0)
            {               
                btnEqual.PerformClick();
                operators = btnOperator.Text;
                txtDisplay.Text = result + " " + operators;
                action = true;
            }
            else
            {
                operators = btnOperator.Text;
                result = Convert.ToDouble(this.txtDisplay.Text);
                txtDisplay.Text = result + " " + operators;
                action = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (!this.txtDisplay.Text.Contains(operators))
            {
                switch (operators)
                {
                    case "+":
                        result = (result + Convert.ToDouble(this.txtDisplay.Text));
                        this.txtDisplay.Text = result.ToString();
                        action = true;

                        break;

                    case "-":
                        result = (result - Convert.ToDouble(this.txtDisplay.Text));
                        this.txtDisplay.Text = result.ToString();
                        action = true;
                        break;

                    case "*":
                        result = (result * Convert.ToDouble(this.txtDisplay.Text));
                        this.txtDisplay.Text = result.ToString();
                        action = true;
                        break;

                    case "/":
                        result = (result / Convert.ToDouble(this.txtDisplay.Text));
                        if (this.txtDisplay.Text == value.ToString())
                        {
                            value = (Convert.ToDouble(this.txtDisplay.Text)) / 0;
                            MessageBox.Show("Undefiend");
                            this.txtDisplay.Text = "";
                        }
                        this.txtDisplay.Text = result.ToString();
                        action = true;
                        break;

                    default:
                        operators = "";
                        txtDisplay.Text = result.ToString();
                        action = true;
                        break;
                }
                result = Double.Parse(txtDisplay.Text);
                operators = "";
                action = true;
            }   
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            result = Convert.ToDouble(this.txtDisplay.Text) / 100;
            this.txtDisplay.Text = result.ToString();
            action = true;
        }
    }
}

