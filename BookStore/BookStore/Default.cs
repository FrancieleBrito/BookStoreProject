﻿using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {

        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promo promoForm = new Promo();
            promoForm.ShowDialog();


        }
    }
}