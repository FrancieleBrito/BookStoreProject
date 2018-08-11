using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Bookstore : Form
    {
        public Bookstore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This is just for the testing purposes 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This button is for bla bla 
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            // This button here for displaying the information about the publishers
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promo promoForm = new Promo();
            promoForm.ShowDialog();
            //this.Close();
        }
    }
}
