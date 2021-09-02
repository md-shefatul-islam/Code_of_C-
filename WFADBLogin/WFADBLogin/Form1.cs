using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WFADBLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string query = "select * from signin;";

            SqlConnection sqlcon = new SqlConnection(@"Data Source = SHEFAT\SQLEXPRESS; Initial Catalog = helpme; User ID = sa; Password = shefat66");
            //to connect the sql server
            sqlcon.Open(); //open the connection to sql

            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            //create a trminal to write sql

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            //to execute the query
            DataSet ds = new DataSet();
            //hold the result of query
            lblname.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = "select * from signin;";

            SqlConnection sqlcon = new SqlConnection(@"Data Source = SHEFAT\SQLEXPRESS; Initial Catalog = helpme; User ID = sa; Password = shefat66");
            //to connect the sql server
            sqlcon.Open(); //open the connection to sql

            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            //create a trminal to write sql

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            //to execute the query
            DataSet ds = new DataSet();
            //hold the result of query

            sda.Fill(ds);

            int count = 0;
            bool d = false;
            while(count< ds.Tables[0].Rows.Count)
            {
                if(txtid.Text== ds.Tables[0].Rows[count][0].ToString() && txtpassword.Text == ds.Tables[0].Rows[count][2].ToString())
                {
                    MessageBox.Show("Login approved for" + ds.Tables[0].Rows[count][0]);
                    d = true;
                    break;
                }
                count++;
            }
            if(!d)
            {
                MessageBox.Show("Login invalid");
                sqlcon.Close();
            }
        }
    }
}
