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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        

        public Form1()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginUserName_TextChanged(object sender, EventArgs e)
        {
            string lun = loginUserName.Text;
            string lup = loginUserPass.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void loginUserName_TextChange(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            string lun = loginUserName.Text;
            string lup = loginUserPass.Text;

            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Login where username ='" + lun + "' and pasword = '" + lup + "'" , con);
                dr = cmd.ExecuteReader();


                if (dr.HasRows & lun == "admin")
                {
                    this.Hide();
                    Main nw = new Main();
                    nw.Show();
                }
                else if (dr.HasRows)

                {
                    this.Hide();
                    Main nw = new Main();
                    nw.Show();
                    nw.Usersbtn.Enabled = false;
                    nw.UsersPnl.Visible = false;
                }

                else
                {
                    MessageBox.Show("Login Failed! Check your Username or Password");
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void loginUserName_Click(object sender, EventArgs e)
        {

        }

        private void loginUserName_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void loginUserName_TextChange_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            importCSV impcsv = new importCSV();
            impcsv.Show();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
