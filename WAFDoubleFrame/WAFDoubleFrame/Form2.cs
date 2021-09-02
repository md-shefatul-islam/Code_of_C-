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
    public partial class Form2 : Form
    {
       // private Form1 ff; 
       private Form1 ff { set; get; }
        public Form2()
        {
            InitializeComponent();
        }

        //public Form2(string Info) :this() //will call its own default constructor
        // public Form2(string Info) : base() //will call parent class default constructor

        //public Form2(string Info, Form1 f) : this()
        public Form2(Form1 f) : this()
        {
            //InitializeComponent(); //intialize the object
            //must have to write int every constuctor & write it int the first  
            //this.lblInfo.Text = Info;
            //get data from frame one; 
            this.ff = f;
            //give the value to ff
        }
       

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //or
            //this.Close();

            //this.ff.Visible = true;
            //or
           this.ff.Show();
        }
    }
}
