using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10
{
    public partial class Form_Task2 : Form
    {
        public Form_Task2()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (txtsubTotal.Text == "")
            {
                MessageBox.Show("Sub Total should not be Null...");
            }
            else
            {
                double DiscountPercent;
                double Subtotal = Convert.ToDouble(txtsubTotal.Text);
                if (Subtotal >= 500)
                    DiscountPercent = (double)20 / 100;
                else if (Subtotal >= 250 && Subtotal < 500)
                    DiscountPercent = (double)15 / 100;
                else if (Subtotal >= 100 && Subtotal < 250)
                    DiscountPercent = (double)10 / 100;
                else
                    DiscountPercent = (double)5 / 100;

                double DiscountAmount = DiscountPercent * Subtotal;
                double InvoiceAmount = Subtotal - DiscountAmount;

                txtdiscountper.Text = DiscountPercent.ToString("p1");
                txtdiscountamount.Text = DiscountAmount.ToString("c");
                txttotal.Text = InvoiceAmount.ToString("c");
                result.Text = $"Dear Customer You Have To Pay: {InvoiceAmount}";


            }
        }
    }
}
