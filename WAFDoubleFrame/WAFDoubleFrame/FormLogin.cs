using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAFDoubleFrame
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textId.Text=="me" && this.textPass.Text == "123")
            {
                MessageBox.Show("Login approved for me");
                FormDashboard f = new FormDashboard(this.textId.Text, this);
                f.Show();
                this.Hide();
            }
            else if(this.textId.Text == "she" && this.textPass.Text == "1234")
            {
                MessageBox.Show("Login approved she");
                FormDashboard f = new FormDashboard(this.textId.Text, this);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login degined");
            }
        }
    }
}
