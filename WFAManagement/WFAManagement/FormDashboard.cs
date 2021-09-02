using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAManagement
{
    public partial class FormDashboard : Form
    {
        private DataAccess Da { get;  set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public FormDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //so that it make conncction as the constructor created

            //string sql = "select * from movies;";
            /*this.Ds = Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = this.Ds.Tables[0];*/
            //this.PopulateGridView(sql);

            
            this.PopulateGridView();

            // MessageBox.Show(this.Ds.Tables[0].Rows[0][1].ToString());
            //MessageBox.Show(this.Ds.Tables[0].Rows[0]["id"].ToString());   // rows[row][colum name of database]
            // the value from table will show in the message box from specific postition of table
            //
            this.GenerateMovieId();
            //checking is it working

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            //string sql = "select * from movies;";
            /*this.Ds = Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = this.Ds.Tables[0];
            //tke the information to the grid view
            */
            //this.PopulateGridView(sql);


            this.PopulateGridView();

        }

        // private void PopulateGridView(string sql)
        private void PopulateGridView(string Sql = "select * from movies;")
        {
            this.Ds = Da.ExecuteQuery(Sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = this.Ds.Tables[0];
            //tke the information to the grid view
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this. Sql = "select * from movies where genre='" + this.txtsearch.Text + "';";
            this.PopulateGridView(this.Sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from movies where title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from movies where id = '" + this.txtMovieID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update movies
            set title= '" + this.txtMovieTitle.Text + @"',
            imdbrating = " + this.txtIMDB.Text + @", 
            income = " + this.txtBox.Text + @",
            releasedate='" + this.dtpReleaseDate.Text + @"',
            genre = '" + this.cmbGenre.Text + @"'
            where id = '" + this.txtMovieID.Text + @"';";



                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(" Data updated");
                    }
                    else
                    {
                        MessageBox.Show("Data updated failed");
                    }
                    // this.PopulateGridView();
                }
                else
                {

                    this.Sql = @" insert into movies 
                     values('" + this.txtMovieID.Text + "', '" + this.txtMovieTitle.Text + "', " + this.txtIMDB.Text + "," + this.txtBox.Text + ",' " + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "');";
                    int count = Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        //this.GenerateMovieId();

                    }
                    else
                    {
                        MessageBox.Show("Data Insertion failed");
                    }
                    //this.PopulateGridView();
                    //this.Clear();
                }
                this.PopulateGridView();
                this.Clear();
            }catch(Exception exc)
            {
                MessageBox.Show("error occured while inserting");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
                string name = this.dgvMovie.CurrentRow.Cells["title"].Value.ToString();
                //take the value of selected(current row), cell[selected row er koto tomo colum]
                // MessageBox.Show(info);
                this.Sql = @"delete from movies
                where id = '" + id + "'; ";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data Deleted failed");
                }
                this.PopulateGridView();
                this.Clear();
            }catch(Exception exc)
            {
                MessageBox.Show("error occured while deletting");
            }

        }

       

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtMovieID.ReadOnly = true;
            this.txtMovieID.Text = this.dgvMovie.CurrentRow.Cells["id"].Value.ToString();
            this.txtMovieTitle.Text = this.dgvMovie.CurrentRow.Cells["title"].Value.ToString();
            this.txtIMDB.Text = this.dgvMovie.CurrentRow.Cells["imdbrating"].Value.ToString();
            this.txtBox.Text = this.dgvMovie.CurrentRow.Cells["income"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells["releasedate"].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells["genre"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Sql = @"update movies
            set title= '" + this.txtMovieTitle.Text + @"',
            imdbrating = " + this.txtIMDB.Text + @", 
            income = " + this.txtBox.Text + @",
            releasedate='" + this.dtpReleaseDate.Text + @"',
            genre = '" + this.cmbGenre.Text + @"'
            where id = '" + this.txtMovieID.Text + @"';";



            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show(" Data updated");
            }
            else
            {
                MessageBox.Show("Data updated failed");
            }
            this.PopulateGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        public void Clear()
        {
            this.txtMovieID.Clear();
            this.txtMovieID.ReadOnly = true;
            this.txtMovieTitle.Clear();
            this.txtIMDB.Clear();
            this.txtBox.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.Text = "";
            //this.cmbGenre.SelectedIndex = -1;
            //work only in selection mode

            this.GenerateMovieId();
        }

        private void GenerateMovieId()
        {
            this.Sql = "select * from movies order by id desc;";

            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0]["id"].ToString();
            //MessageBox.Show(id);

            id.Split();
            //divided int to sub string
            string[] str = id.Split('m');

            //string y = "help please";
            //string[] str = y.Split('l'); // charecter will be bad
            //MessageBox.Show(str[0] + "\n" + str[1]);

           int num = Convert.ToInt32(str[1]);
            //o11 is the string , make it int 
           string newId='m' + (++num).ToString("d3");

            this.txtMovieID.Text = newId;
            //MessageBox.Show(newId);
        }

    }
}
