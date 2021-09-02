using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gridview
{
    public partial class UserControl1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public UserControl1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string Sql = "select * from product;";
            this.Ds = this.Da.ExecuteQuery(Sql);
            this.dgv.DataSource = this.Ds.Tables[0];
        }

        
    }
}
