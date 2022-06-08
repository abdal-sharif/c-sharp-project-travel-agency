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

    public partial class registration : KryptonForm
    {
        String chcekedradio = "";

        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            chxlugage.Checked = true;
            chxairmiles.Checked = true;
            chxtax.Checked = true;
            chxtravel.Checked = true;


            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0);
            this.Size = new Size(w,h);



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdeparture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=travelagencyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();
       

            string firstname = txtfname.Text;
            string surname = txtsurname.Text;
            string addresss = txtaddress.Text;
            string tel = txttell.Text;
            string email = txtemail.Text;

        
            string depature = cmdeparture.Text;
            string distanation = cmdestination.Text;
            string accomadtion = cmaccom.Text;
            string flight_standerd = rdeconomy.Text + rdfirstclass.Text + rdstandard.Text;
            string total = txttotal.Text;



            string query = "	insert into registrationinfo (firstname,surname,addresss,tel,email) values ('"+firstname+"', '"+surname+"', '"+addresss+"', '"+tel+"', '"+email+ "');insert into recipt_tb (fullname,depature,distanation,accomadtion,flight_standerd,total_price) values ('" + firstname + "\t" + surname + "', '" + depature + "', '" + distanation + "', '" + accomadtion + "','" + chcekedradio + "', '" + total + "')";
      

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("data daada wala xareeyay");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtsurname.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txttell .Clear();
            txtfname.Focus();

            txtsubtotal.Text = "";
            txttax.Text = "";
            txttotal.Text = "";


            cmdeparture.Text = "none";
            cmaccom.Text = "none";
            cmdestination.Text = "none";

            chxlugage.Checked = true;
            chxtax.Checked = true;
            chxtravel.Checked = true;
            chxairmiles.Checked = true;


            rdeconomy.Checked = false;
            rdfirstclass.Checked = false;
            rdstandard.Checked = false;

            chxspecialneeds.Checked = false;
            chxsingle.Checked = false;
            chxreturn.Checked = false;
            chxchild.Checked = false;
            chxadult.Checked = false;


            rtrecipt.Text = "";




            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult iexit;

            iexit = MessageBox.Show("aqbal hadi ad rabto ina ka baxdo", "travel agency system",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void total_Click(object sender, EventArgs e)
        {
            Cprice travelprice = new Cprice();
            itax airtax = new itax();
            double[] travelcost = new double[20];
            double[] taxcost = new double[20];
            double total;

            if(cmdestination.Text == "hargeisa  5 days laascanood")
            {
                travelcost[0] = travelprice.hargeisa +travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance ;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0] ;

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "hargeisa  5 days berbera")
            {
                travelcost[0] = travelprice.hargeisa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "hargeisa  5 days borama")
            {
                travelcost[0] = travelprice.hargeisa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }


            if (cmdestination.Text == "mogadishu 5 days banaadir ")
            {
                travelcost[0] = travelprice.mogadishu + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "jabuuri 5 days ali sabiix ")
            {
                travelcost[0] = travelprice.jabuuti + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }




            if (cmdestination.Text == "jabuuti 4 days jabuuti ")
            {
                travelcost[0] = travelprice.jabuuti + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "rwanda 30 days gigali ")
            {
                travelcost[0] = travelprice.rwanda + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }


            if (cmdestination.Text == "south africa 5 day cape town  ")
            {
                travelcost[0] = travelprice.south_africa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "south africa 4 days joahnburg")
            {
                travelcost[0] = travelprice.south_africa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "nigeria - 6 days in lagos")
            {
                travelcost[0] = travelprice.nigeria + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }


            if (cmdestination.Text == "india 20 days new delhi")
            {
                travelcost[0] = travelprice.india + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
       


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            new database_view().Show();
            this.Activate();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnrecipt_Click(object sender, EventArgs e)
        {
       


        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

   




            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(4239, 34339);
            num1 = 1234 + num1;
            string refs = Convert.ToString(num1);



            rtrecipt.AppendText( "Travel managment system:\n\n"
                + "Ref:\t\t\t\t" + refs
                + "\n----------------------------------------------"
                + "\nName:\t\t\t" + txtfname.Text +"\t"+ txtsurname.Text
                + "\nAddress:\t\t\t" + txtaddress.Text
                + "\ntell:\t\t\t" + txttell.Text
                + "\nemail:\t\t\t" + txtemail.Text
                + "\ndestination:\t\t" + cmdestination.Text
                + "\n Tax Price:\t\t" + txttax.Text
                + "\n total Price:\t\t" + txttotal.Text
                + "\n-----------------------------------------------"
                + "\n " + lbldate.Text + "\t\t\t" + lbltime.Text
                + "\n------------------------------------------------"
                + "\n\nWa ku mahad sanatahy \n\tDoorashada travel agency geena "
                );
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        //standerd rido
        private void rdstandard_CheckedChanged(object sender, EventArgs e)
        {
            if(rdstandard.Checked)
            {
                chcekedradio = "";
                chcekedradio = "standered";
            }
        }
        //econmic rido
        private void rdeconomy_CheckedChanged(object sender, EventArgs e)
        {
            if(rdeconomy.Checked)
            {
                chcekedradio = "";
                chcekedradio = "economoy";
            }

        }
        //first class raido
        private void rdfirstclass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdfirstclass.Checked)
            {
                chcekedradio = "";
                chcekedradio = "first class";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime iTime = DateTime.Now;
            lbltime.Text = iTime.ToLongTimeString();

            DateTime iDate = DateTime.Now;
            lbldate.Text = iDate.ToLongDateString();

        }
    }
}
