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
using System.IO;
using System.Configuration;

namespace Pro
{
    public partial class Student_Form : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        
        
        SqlDataReader dr;
        string gender;
        

        public void loadSemester()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Semester ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    semesterBox.Items.Add(dr.GetString(1));
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            void Clear()
        {
            firstNameStd.Text = lastNameStd.Text = fatherNameStd.Text = ageStd.Text = contactStd.Text = addressStd.Text =  "";
        }
        
        public Student_Form()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
            loadSemester();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Students (firstName,lastName,fathersName,age,contactNo#,gender,address,course,semester) values ('" + firstNameStd.Text + "','" + lastNameStd.Text + "','" + fatherNameStd.Text + "','" +ageStd.Text + "','"+contactStd.Text+"','" + gender+ "','" + addressStd.Text + "','" + courseBox.Text.ToString() + "','" + semesterBox.Text.ToString() + "')", con);
            
            con.Open();
            cmd.ExecuteNonQuery();
            if (firstNameStd.Text == "" || lastNameStd.Text == "")
            {
                MessageBox.Show("Please fill required fields");
            }
            else
            MessageBox.Show("Student Registered");
            Clear();
            con.Close();
        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void femaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uploadImgStd_Click(object sender, EventArgs e)
        {
            
        }

        private void registerUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string ct = courseText.Text;
            courseBox.Items.Add(ct);
            courseText.Clear();
        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            //SqlConnection con = new SqlConnection(mainconn);
            //string sqlquery = " Insert into Students (course) values ('"+courseBox.Text.ToString()+"')";
            //SqlCommand cmd = new  SqlCommand(sqlquery, con);

            //try
            //{
            //    con.Open();
            //    cmd.Parameters.AddWithValue("course", courseBox.Text.ToString());
            //    cmd.ExecuteNonQuery();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseText_TextChange(object sender, EventArgs e)
        {

        }

        private void semesterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Student_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
