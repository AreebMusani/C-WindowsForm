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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Checking name,Fname and Age fields are empty or not
            if(txtName.Text == "" || txtFname.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Field should not be null..");
            }
            else
            {
                //Checking BS or Intermediate are checked or not
                if(radioButton1.Checked || radioButton2.Checked)
                {
                    //checking uni is checked or not
                    if(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
                    {
                        MessageBox.Show("You are registered Successfully..");
                    }
                    else
                    {
                        MessageBox.Show("Please select University!");
                    }
                }
                else
                {
                    MessageBox.Show("plz select your education!");
                }
            }
        }
    }
}
