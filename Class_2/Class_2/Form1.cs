using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_2
{
    public partial class PurchaseTicket : Form
    {
        public string customerName = "";
        public int numberofTickets = 0;
        public int unitPrice = 0;
        public double totalprice=0;




        public PurchaseTicket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntoal_Click(object sender, EventArgs e)
        {
            customerName = txtCustomerName.Text;
            numberofTickets =Convert.ToInt32(txtNumberoftickets.Text) ;
            unitPrice = Convert.ToInt32(txtunitPrice.Text);


            totalprice = numberofTickets * unitPrice;

            txtCustomerName.Text = "";
            txtunitPrice.Text = "";
            MessageBox.Show("total price   " +totalprice);
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
