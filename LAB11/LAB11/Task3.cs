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
    public partial class Task3 : Form
    {
        string data;

        public Task3()
        {
            InitializeComponent();
        }

        private void Task3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLname.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || txtemail.Text == "" || txtUserName.Text == "" || txtpassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("Field Should not be null!");
            }
            else
            {
                if (!radioButton1.Checked && !radioButton1.Checked)
                    MessageBox.Show("Please select Gender..");
                else
                {
                    if (txtpassword.Text == txtConPassword.Text)
                    {
                        passlabel.Text = "Password Match";
                        data = txtFName.Text + "\n" + txtLname.Text + "\n" + txtemail.Text + "\n" + txtContact.Text + "\n";
                        if (radioButton1.Checked)
                        {
                            data += "Male";
                        }
                        else
                        {
                            data += "Female";
                        }
                        data += "\n" + txtAddress.Text + txtUserName.Text + "\n" + txtpassword.Text;

                        MessageBox.Show(data);
                    }
                    else
                        passlabel.Text = "Password not Match!";
                }
                
            }
            
        }
    }
}
