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
    public partial class Remark : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        void Clear()
        {
            std1.Text = std2.Text = std3.Text = std4.Text = MarksText.Text = "";
        }
        public void loadremarks()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Batchtiming ", con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                   remarkBox.Items.Add(dr.GetString(2));
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
        public void loadGroups()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from groups ", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                   grpIdBox.Items.Add(dr["grpId"].ToString());
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
        public Remark()
        {
            InitializeComponent();
            
        }

        private void grpIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grp = grpIdBox.SelectedItem.ToString();

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

        private void remarkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rem = remarkBox.SelectedItem.ToString();

            //    try
            //    {
            //        con.Open();
            //        cmd = new SqlCommand("Select * from Batchtiming where btId ='" + rem + "'", con);
            //        dr = cmd.ExecuteReader();

            //        dr.Read();

            //        std1.Text = dr.GetString(1);
            //        std2.Text = dr.GetString(2);
            //        std3.Text = dr.GetString(3);
            //        std4.Text = dr.GetString(4);



            //        con.Close();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRemarks_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Groups SET remarks = '" + remarkBox.Text.ToString() + "', marks = '"+ MarksText.Text + "' where grpId = '" + grpIdBox.Text.ToString() + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            
            Clear();
            con.Close();
        }

        private void registerUser_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void Remark_Load(object sender, EventArgs e)
        {
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
            loadGroups();
            loadremarks();
        }
    }
    
}
