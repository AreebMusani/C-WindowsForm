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
    public partial class adGroups : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public void loadStdNames()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Students ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    stdBox1.Items.Add(dr.GetString(1));
                    stdBox2.Items.Add(dr.GetString(1));
                    stdBox3.Items.Add(dr.GetString(1));
                    stdBox4.Items.Add(dr.GetString(1));
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public adGroups()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
            loadStdNames();
        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stdBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string std1 = stdBox1.SelectedItem.ToString();
            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from Students where firstName ='" + std1 + "'", con);
                dr = cmd.ExecuteReader();

                dr.Read();

                course1.Text = dr["course"].ToString();
                semesterStd1.Text = dr["semester"].ToString();
                batchStd1.Text = dr[10].ToString();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void stdBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string std2 = stdBox2.SelectedItem.ToString();
            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from Students where firstName ='" + std2 + "'", con);
                dr = cmd.ExecuteReader();

                dr.Read();

                course2.Text = dr.GetString(8);
                semesterStd2.Text = dr.GetString(9);
                batchStd2.Text = dr[10].ToString();



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void stdBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string std3 = stdBox3.SelectedItem.ToString();
            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from Students where firstName ='" + std3 + "'", con);
                dr = cmd.ExecuteReader();

                dr.Read();

                course3.Text = dr.GetString(8);
                semesterStd3.Text = dr.GetString(9);
                batchStd3.Text = dr[10].ToString();



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void stdBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string std4 = stdBox4.SelectedItem.ToString();

            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from Students where firstName ='" + std4 + "'", con);
                dr = cmd.ExecuteReader();

                dr.Read();

                course4.Text = dr.GetString(8);
                semesterStd4.Text = dr.GetString(9);
                batchStd4.Text = dr[10].ToString();
                


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            try
            {


                cmd = new SqlCommand("insert into Groups  (student1,student2,student3,student4,batchId) values ('" + stdBox1.Text.ToString() + "','" + stdBox2.Text + "','" + stdBox3.Text.ToString() + "','" + stdBox4.Text.ToString() + "','"+ batchStd4.Text+ "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                if (stdBox1.Text.ToString() == "" || stdBox2.Text.ToString() == "" || stdBox3.Text.ToString() == "" || stdBox4.Text.ToString() == "" )
                {
                    MessageBox.Show("Please select four Students");
                }
                else if(stdBox1.Text.ToString() == stdBox2.Text.ToString() || stdBox3.Text.ToString() == stdBox4.Text.ToString() || stdBox1.Text.ToString() == stdBox3.Text.ToString() || stdBox2.Text.ToString() == stdBox4.Text.ToString())
                {
                    MessageBox.Show("Please select four Students");
                }
                else if (batchStd1.Text != batchStd2.Text || batchStd3.Text != batchStd4.Text || batchStd1.Text != batchStd4.Text || batchStd2.Text != batchStd3.Text)
                {
                    MessageBox.Show("Select same Batch Students");
                }
                else
                {
                    MessageBox.Show("new Group Added");
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
    
}
