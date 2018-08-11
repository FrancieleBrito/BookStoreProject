using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class Promo : Form
    {
        public Promo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckPromotion_Click(object sender, EventArgs e)
        {


            //try {

            //    //Connection
            //    string connection = "";

            //    SqlConnection conn = new SqlConnection(connection);

            //    SqlCommand cmd = new SqlCommand();

            //    SqlDataReader reader;
            //    conn.Open();
            //    reader = cmd.ExecuteReader();
            //    int count = 0;

            //    //Call Procedure PROMO


            //}
            //catch (Exception e )
            //{

            //    e.Message("a");
            //    //  connection problem

            //}

            

            //Result of promo procedure 
            lblPromoResult.Text = "You have earned " ; // here display 50 ,25 or 0

            int promoCustId =Convert.ToInt32( txtPromoCustomerId.Text);
            CheckPromo(promoCustId);
        }
        private static void CheckPromo(int customerId)
        {
            int custId = customerId;





        }
    }
}
