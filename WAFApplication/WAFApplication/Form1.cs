using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAFApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.otbID.Text = this.tbID.Text;
            this.Olbl2Password.Text = this.tbPassword.Text;
            this.olbl2Department.Text = this.comboBox1.Text;
            this.olbl2DoB.Text = this.tbdTP.Text;
            if (this.rbBachelors.Checked == true)
            {
                this.olbl2Program.Text = "Bachelors";
            }
            else if (this.rbMasters.Checked == true)
            {
                this.olbl2Program.Text = "Masters";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.otbID.Text = ""
;            this.Olbl2Password.Text = "";
            this.olbl2Department.Text = "";
            this.olbl2Program.Text = "";
            this.olbl2DoB.Text = "";
        }

       
    }
}
