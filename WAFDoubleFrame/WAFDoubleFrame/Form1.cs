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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(this.txtInfo.Text, this);
            Form2 f2 = new Form2( this);
            f2.Visible = true; //make the form2 appear
            

            this.Visible = false; 
          //make the form1 invisibile
        }

        //close the full applicatioon with from1 
        
    }
}
