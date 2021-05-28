using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("UserName or Password Should not be null!");
            }
            else
            {
                MessageBox.Show("Congratulation! you are login Successfully");
            }
        }
    }
}
