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
    public partial class FormDashboard : Form
    {
        private FormLogin f { set; get; }
        public FormDashboard()
        {
            InitializeComponent();
        }
        public FormDashboard(string id, FormLogin fl) : this()
        {
            this.labelds.Text += id;
            this.f = fl;
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();
            this.Visible = false;
            this.f.Visible = true;
        }

        
    }
}
