using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMetro
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string path = "C:\\Users\\ASUS\\Desktop\\me\\Love.jpg";
            this.pictureBox1.Image = Image.FromFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.progressBar.value *= 20;
        }
    }
}
