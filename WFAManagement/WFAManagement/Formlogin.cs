using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace WFAManagement
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        string sql = "select * from signin where id = '"+this.txtid.Text+"' and password='"+this.txtpassword.Text+"';";
        DataAccess da = new DataAccess();
        DataSet  dts = da.ExecuteQuery(sql);

            if(dts.Tables[0].Rows.Count==1) 
            {
                MessageBox.Show("login approved "+dts.Tables[0].Rows[0][1].ToString());
            }
            else
            {
                MessageBox.Show("login invalid");

            }
        }
    }
}
