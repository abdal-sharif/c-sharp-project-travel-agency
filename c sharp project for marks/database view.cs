using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace c_sharp_project_for_marks
{
    public partial class database_view : KryptonForm
    {
        public database_view()
        {
            InitializeComponent();
        }

        private void database_view_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=travelagencyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from 	recipt_tb";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cmd.ExecuteReader();
            //MessageBox.Show(ds1.Tables[0].Rows[0][0].ToString);
            dataGridView1.DataSource = ds1.Tables[0];

            con.Close();


        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult iexit;

            iexit = MessageBox.Show("ma rabtaa ina ka bxado ", "travel agency managment system",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                new registration().Show();
                this.Hide();

            }




        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {





        }
        //on text chnage
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
   

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
          /*  String name = txtsearch.Text.Trim();
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=travelagencyDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from recipt_tb where fullname = '"+name+"'";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            con.Close();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
