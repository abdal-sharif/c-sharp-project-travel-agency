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

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult iexit;

            iexit = MessageBox.Show("ma rabtaa ina ka bxado ", "travel agency managment system",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                /*     Application.Exit();*/
                new registration().Show();
                this.Hide();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
      /*      string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=travelagencyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();
            string query = " select * from recipt_tb";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();


   


            con.Close();*/





        }
    }
}
