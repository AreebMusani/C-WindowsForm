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
    public partial class ProjectForm : Form
    {
         SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public void loadGrpID()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Groups ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    selectGroupBox.Items.Add(dr[0].ToString());
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
        public ProjectForm()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
            loadGrpID();
        }

        private void selectCourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {


                cmd = new SqlCommand("insert into Project  (projectStart,projectReview,projectEnd ,projectPresentation,projectTopic,grpId) values ('" + proStart.Text.ToString() + "','" + proReview.Text.ToString() + "','" + proEnd.Text.ToString()+ "','" + proPresent.Text.ToString() + "','"+projectTopic.Text+"','" + selectGroupBox.Text.ToString() + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                if (projectTopic.Text == "" || selectGroupBox.Text == "")
                {
                    MessageBox.Show("Please fill required fields");
                }
                else
                    MessageBox.Show("New Project Added");

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

        private void selectGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grp = selectGroupBox.SelectedItem.ToString();
            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from Groups where grpId ='" + grp + "'", con);
                dr = cmd.ExecuteReader();

                dr.Read();

              
                std1.Text = dr.GetString(1);
                std2.Text = dr.GetString(2);
                std3.Text = dr.GetString(3);
                std4.Text = dr.GetString(4);



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

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
