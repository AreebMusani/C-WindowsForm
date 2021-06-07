using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pro
{
    public partial class BatchesForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public void loadBatches()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Batches ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    batchesBox.Items.Add(dr.GetString(0));
                }

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
        public void loadBatchTiming()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Batchtiming ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    batchTimingtext.Items.Add(dr.GetString(1));
                }

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

        void Clear()
        {
            firstNameStd.Text = lastNameStd.Text = stdFatherName.Text = ageStd.Text = stdContact.Text = addressStd.Text = genderStd.Text = courseStd.Text = semesterStd.Text ="";
        }
        public void loadStdNames()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Students ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    stdNameBox.Items.Add(dr.GetString(1));
                }

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

        public void Batches()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Batches ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    batchesBox.Items.Add(dr[0].ToString());
                }

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
        public BatchesForm()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
            loadStdNames();
            loadBatchTiming();
            Batches();

        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void addBatchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into Batches  (batchTiming,batchDuration,batchStartDate , maxStd) values ('" + batchTimingtext.Text.ToString() + "','" + batchDurationtext.Text + "','" + batchStartDatepick.Text.ToString() + "','" + maxStdtext.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                if (batchTimingtext.Text.ToString() == "" || batchDurationtext.Text == "")
                {
                    MessageBox.Show("Please fill required fields");
                }
                else
                    MessageBox.Show("New Batch Added");

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

        private void stdNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //stdNameBox.Items.Add(placeholder) = "Select Student's Name";
            string std = stdNameBox.SelectedItem.ToString();


            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from Students where firstName ='" + std + "'", con);
                dr = cmd.ExecuteReader();

                dr.Read();

                firstNameStd.Text = dr.GetString(1);
                lastNameStd.Text = dr.GetString(2);
                stdFatherName.Text = dr.GetString(3);
                ageStd.Text = dr["age"].ToString();
                genderStd.Text = dr.GetString(6);
                stdContact.Text = dr["contactNo#"].ToString();
                addressStd.Text = dr["address"].ToString();
                courseStd.Text = dr["course"].ToString();
                semesterStd.Text = dr["semester"].ToString();

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

        private void addBatchpnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stdNameBox_TextChanged(object sender, EventArgs e)
        {
            //{
            //    if (stdNameBox.Text == "")
            //        stdNameBox.Text = "Select Student";

            //}
        }

        private void fatherNameStd_TextChange(object sender, EventArgs e)
        {

        }

        private void batchTimingtext_SelectedIndexChanged(object sender, EventArgs e)
        {
            string batchtime = batchTimingtext.SelectedItem.ToString();
        }

        private void stdBatchbtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Students SET batchId = '" + batchesBox.Text.ToString() + "' where firstName = '" + firstNameStd.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            if (firstNameStd.Text == "" || lastNameStd.Text == "")
            {
                MessageBox.Show("Please fill required fields");
            }
            else
                MessageBox.Show("Student added to '" + batchesBox.Text.ToString() + "'");
            Clear();
            con.Close();
        }

        private void batchlblform_Click(object sender, EventArgs e)
        {

        }

        private void batchesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batchStartDatepick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void registerUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
