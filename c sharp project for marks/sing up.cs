using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace c_sharp_project_for_marks
{
    public partial class sing_up : KryptonForm
    {
        public sing_up()
        {
            InitializeComponent();
        }

        private void sing_up_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
       
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=travelagencyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string user = usertxt.Text;
            string pass = passwordtxt.Text;

            string query = "insert into userTB(username , user_Password)values('"+user +"','"+pass+"')";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

       

            MessageBox.Show("userkada wala sameyay");



            cmd.CommandText = "select * from 	recipt_tb";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cmd.ExecuteReader();

            con.Close();



        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            DialogResult iexit;

            iexit = MessageBox.Show("ogolaaw si add uga baxdo", "travel agency system",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                new login().Show();
                this.Hide();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            passwordtxt.Text = "";
            usertxt.Focus();
        }
    }
    }

