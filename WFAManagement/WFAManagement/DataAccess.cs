using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WFAManagement
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            set { this.sqlcon = value; }
            get { return sqlcon; }
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            set { this.sqlcom = value; }
            get { return sqlcom; }
        }

        private SqlDataAdapter sda;

        public SqlDataAdapter Sda
        {
            set { this.sda = value; }
            get { return sda; }
        }

        private DataSet ds;

        public DataSet Ds
        {
            set { this.ds = value; }
            get { return ds; }
        }
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=SHEFAT\SQLEXPRESS;Initial Catalog=helpme;Persist Security Info=True;User ID=sa;Password=shefat1234");
            this.Sqlcon.Open();
        }
        private void QueryTest(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }
        public DataSet ExecuteQuery(string sql)
        {
            this.QueryTest(sql);
            this.sda = new SqlDataAdapter(this.sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
            //return dataset
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryTest(sql);
            this.sda = new SqlDataAdapter(this.sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
            //return table
        }
        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryTest(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            //ExecuteNonQuery() the return number of row affected
            return u;
        }


    }
}
