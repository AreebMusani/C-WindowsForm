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

namespace Pro
{
    public partial class Register : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        

        void Clear()
        {
            firstNamereg.Text = lastNamereg.Text = fatherNamereg.Text = userNamereg.Text = pwordreg.Text = repwordreg.Text = "";
        }

        public Register()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string regUser = userNamereg.Text;
            string regPword = pwordreg.Text;
            string reregPword = repwordreg.Text;

            if (regUser == "" || regPword == "")
            {
                MessageBox.Show("Please fill required fields");
            }

            else if (regPword.Equals(reregPword))
            {
                cmd = new SqlCommand("insert into Login (username,pasword,ranking,firstName,lastName,fatherName) values ('" + regUser + "','" + regPword + "','1','"+ firstNamereg.Text+ "','" + lastNamereg.Text + "','" + fatherNamereg.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Registered");
                Clear();
                con.Close();
            }
            else
                MessageBox.Show("Passwords are not matched");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstNamereg_TextChange(object sender, EventArgs e)
        {

        }

        private void repwordreg_TextChange(object sender, EventArgs e)
        {

        }

        private void pwordreg_TextChange(object sender, EventArgs e)
        {

        }

        private void userNamereg_TextChange(object sender, EventArgs e)
        {

        }

        private void lastNamereg_TextChange(object sender, EventArgs e)
        {

        }

        private void fatherNamereg_TextChange(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

