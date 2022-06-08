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
    public partial class loading : KryptonForm
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new registration().Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(load.Value < 100)
            {
                load.Value += 1;
                label2.Text = load.Value.ToString();
            }

            else
            {
                timer1.Stop();
                new registration().Show();
                this.Hide();
            }
        }
    }
}
