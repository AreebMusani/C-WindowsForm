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


namespace Pro
{
    public partial class Main : Form
    {
        
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataTable dt;

        void searchUser(string searchData)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Login where username like '%" + searchData + "%' OR firstName like '%" + searchData + "%' OR lastName like '%" + searchData + "%' OR fatherName like '%" + searchData + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewUser.DataSource = dt;
            con.Close();
        }
        void searchStudent(string searchData)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Students where stdId like '%" + searchData + "%' OR age like '%" + searchData + "%' OR firstName like '%" + searchData + "%' OR lastName like '%" + searchData + "%' OR fathersName like '%" + searchData + "%' OR contactNo# like '%" + searchData + "%' OR gender like '%" + searchData + "%' OR address like '%" + searchData + "%' OR course like '%" + searchData + "%' OR semester like '%" + searchData + "%' OR batchId like '%" + searchData + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewStd.DataSource = dt;
            con.Close();
        }
        void searchBatch(string searchData)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Batches where batchId like '%" + searchData + "%' OR batchStartDate like '%" + searchData + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridBatches.DataSource = dt;
            con.Close();
        }
        void searchGroup(string searchData)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Groups where grpId like '%" + searchData + "%' OR student1 like '%" + searchData + "%' OR student2 like '%" + searchData + "%' OR student3 like '%" + searchData + "%' OR student4 like '%" + searchData + "%' OR batchId like '%" + searchData + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridBatches.DataSource = dt;
            con.Close();
        }
        void searchProject(string searchData)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Project where projectId like '%" + searchData + "%' OR projectStart like '%" + searchData + "%' OR projectReview like '%" + searchData + "%' OR projectEnd like '%" + searchData + "%' OR projectPresentation like '%" + searchData + "%' OR grpId like '%" + searchData + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridBatches.DataSource = dt;
            con.Close();
        }
        void searchMarks(string searchData)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Groups where grpId like '%" + searchData + "%' OR student1 like '%" + searchData + "%' OR student2 like '%" + searchData + "%' OR student3 like '%" + searchData + "%' OR student4 like '%" + searchData + "%' OR batchId like '%" + searchData + "%' OR  marks like '%" + searchData + "%' OR  remarks like '%" + searchData + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridBatches.DataSource = dt;
            con.Close();
        }
        //void BulkCopy()
        //{
        //    SqlConnection cong;
        //    cong = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        //}

        void pnlOn()
        {
            pnlOnUsers.Visible = true;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;
            //User Panel Visible
            UsersPnl.Visible = true;
            StudentsPnl.Visible = false;
            BatchesPnl.Visible = false;
            Groupspnl.Visible = false;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = false;
            MarkPnl.Visible = false;

        }
        

        public Main()
        {
            InitializeComponent();
            sqlconnection connection = new sqlconnection();
            con = connection.connectionMethod();
            pnlOn();
            //searchUser("");
            //searchStudent("");
            //searchBatch("");
            //searchGroup("");
            //BulkCopy();



        }

        public void bunifuButton1_Click(object sender, EventArgs e)
        {
            pnlOnUsers.Height = Usersbtn.Height;
            pnlOnUsers.Top = Usersbtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = true;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;

            //User Panel Visible
            UsersPnl.Visible = true;
            BatchesPnl.Visible = false;
        }
       
        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void BatchesPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void Batchesbtn_Click(object sender, EventArgs e)
        {
            pnlOnBatches.Height = Batchesbtn.Height;
            pnlOnBatches.Top = Batchesbtn.Top;
          
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = true;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;

            //Bactches Panel Visible
            BatchesPnl.Visible = true;
            UsersPnl.Visible = false;
            StudentsPnl.Visible = false;
            Groupspnl.Visible = false;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = false;
            MarkPnl.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            try {
                scb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information Updated");
                loadUsers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void viewUsers_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Login",con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewUser.DataSource = dt;
            con.Close();
        }

        private void delUser_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Login where loginId =" + dataGridViewUser.Rows[selectedId].Cells[0].Value;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Row Deleted");
            loadUsers();


        }
        int selectedId = 0;
        private void dataGridViewUser_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }

        private void UsersPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void GroupsBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ProjectsBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ReminderBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void MarksBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void StudentBtn_Click_1(object sender, EventArgs e)
        {
            pnlonStudents.Height = StudentBtn.Height;
            pnlonStudents.Top = StudentBtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = true;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;

            //Student Panel Visible
            UsersPnl.Visible = false;
            BatchesPnl.Visible = false;
            StudentsPnl.Visible = true;
            Groupspnl.Visible = false;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = false;
            MarkPnl.Visible = false;
        }

        private void GroupsBtn_Click_1(object sender, EventArgs e)
        {
            pnlOnGroups.Height = GroupsBtn.Height;
            pnlOnGroups.Top = GroupsBtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = true;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;

            UsersPnl.Visible = false;
            StudentsPnl.Visible = false;
            BatchesPnl.Visible = false;
            Groupspnl.Visible = true;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = false;
            MarkPnl.Visible = false;
        }

        private void ProjectsBtn_Click_1(object sender, EventArgs e)
        {
            pnlOnProjects.Height = ProjectsBtn.Height;
            pnlOnProjects.Top = ProjectsBtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = true;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;



            UsersPnl.Visible = false;
            StudentsPnl.Visible = false;
            BatchesPnl.Visible = false;
            Groupspnl.Visible = false;
            Projectspnl.Visible = true;
            ReminderPnl.Visible = false;
            MarkPnl.Visible = false;

        }

        private void ReminderBtn_Click_1(object sender, EventArgs e)
        {
            pnlOnReminders.Height = ReminderBtn.Height;
            pnlOnReminders.Top = ReminderBtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = true;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;

            UsersPnl.Visible = false;
            StudentsPnl.Visible = false;
            BatchesPnl.Visible = false;
            Groupspnl.Visible = false;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = true;
            MarkPnl.Visible = false;
        }

        private void MarksBtn_Click_1(object sender, EventArgs e)
        {
            pnlOnMarks.Height = MarksBtn.Height;
            pnlOnMarks.Top = MarksBtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Form stdForm = new Student_Form();
            stdForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //con.Open();
            //StreamReader sr = new StreamReader(Application.StartupPath + "\\files\\test.csv");

            //while (!sr.EndOfStream)
            //{
            //    var data = sr.ReadLine().Split(',');

            //    cmd = new SqlCommand("insert into Students (firstName,lastName,fathersName,age,contactNo#,gender,course) values ('" + data[0] + "','" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "','" + data[5] + "','" + data[7] + "')", con);
            //    cmd.ExecuteNonQuery();
            //}
            //MessageBox.Show("data Inserted");
            //sr.Close();
            //con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Students", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewStd.DataSource = dt;
            con.Close();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewStd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }

        private void delStdBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Students where stdId =" + dataGridViewStd.Rows[selectedId].Cells[0].Value;
            cmd.ExecuteNonQuery();
            con.Close();
            loadStudents();
            MessageBox.Show("Selected Student Record Deleted");

        }

        private void loadStudents()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Students", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewStd.DataSource = dt;
            con.Close();
        }

        private void loadUsers()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Login", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewUser.DataSource = dt;
            con.Close();
        }
        private void loadGroups()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Groups", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridGrp.DataSource = dt;
            con.Close();
        }
        private void loadProjects()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Project", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewProject.DataSource = dt;
            con.Close();
        }
        private void loadBatches()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Batches", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridBatches.DataSource = dt;
            con.Close();
        }
        private void loadReminders()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Project where reminder is not null", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridReminders.DataSource = dt;
            con.Close();
        }
        private void addReminders()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Project", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridReminders.DataSource = dt;
            con.Close();
        }

        private void loadMarks()
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Groups where Marks IS NOT NULL OR remarks IS NOT NULL = "" ", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridMarks.DataSource = dt;
            con.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void updateStdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information Updated");
                loadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBatches_Click(object sender, EventArgs e)
        {
            BatchesForm batf = new BatchesForm();
            batf.Show();
        }

        private void batchesDetail_Click(object sender, EventArgs e)
        {
            loadBatches();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadBatches();
        }

        private void delBatchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            //dataGridBatches.ColumnCount = 5;
            //cmd.CommandText = "Delete from Batches where batchId =" + dataGridBatches.Rows[selectedId].Cells[0].Value;
            cmd = new SqlCommand("delete from Batches where batchId=" + dataGridBatches.Rows[selectedId].Cells[0].Value + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Batch Deleted");
            loadBatches();
            
        }
       
        private void dataGridBatches_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void addgroup_Click(object sender, EventArgs e)
        {
            adGroups addg = new adGroups();
            addg.Show();
        }

        private void Projectspnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Remark rem = new Remark();
            rem.Show();
        }

        private void updateBatchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                scb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information Updated");
                loadBatches();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBoxUser_TextChange(object sender, EventArgs e)
        {

        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            pnlOnUsers.Height = Usersbtn.Height;
            pnlOnUsers.Top = Usersbtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = true;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = false;
            //User Panel Visible
            UsersPnl.Visible = true;
            StudentsPnl.Visible = false;
            BatchesPnl.Visible = false;
            Groupspnl.Visible = false;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = false;
            MarkPnl.Visible=false;


        }

        private void searchBoxUser_KeyUp(object sender, KeyEventArgs e)
        {

            string su = searchBoxUser.Text;
            searchUser(su);
        }

        private void searchBoxStd_TextChange(object sender, EventArgs e)
        {

        }

        private void searchBoxStd_KeyUp(object sender, KeyEventArgs e)
        {
            string ss = searchBoxStd.Text;
            searchStudent(ss);
        }

        private void searchBoxBatch_TextChange(object sender, EventArgs e)
        {

        }

        private void searchBoxBatch_KeyUp(object sender, KeyEventArgs e)
        {
            string sb = searchBoxBatch.Text;
            searchBatch(sb);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadProjects();
        }

        private void updateProjectbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter(@"Select * from Project", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewProject.DataSource = dt;
            con.Close();
        }

        private void delProjectbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Project where projectId =" + dataGridViewProject.Rows[selectedId].Cells[0].Value;
            cmd.ExecuteNonQuery();
            con.Close();
            loadStudents();
            MessageBox.Show("Project Deleted");
        }

        private void dataGridViewProject_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            importCSV impcsv = new importCSV();
            impcsv.Show();

            //SqlConnection cong;
            //cong = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
            //DataSet ds = new DataSet();
            //ds.(@"Application.StartupPath + \\files\\test.csv");
            //dt = ds.Tables["Batches"];
            //SqlBulkCopy copy = new SqlBulkCopy(cong);
            //copy.DestinationTableName = "Students";
            //copy.ColumnMappings.Add("stdId", "stdId");
            //copy.ColumnMappings.Add("firstName", "firstName");
            //copy.ColumnMappings.Add("lastName", "lastName");
            //copy.ColumnMappings.Add("age", "age");
            //copy.ColumnMappings.Add("fathersName", "fathersName");
            //copy.ColumnMappings.Add("course", "course");
            //copy.ColumnMappings.Add("semester", "semester");
            //copy.ColumnMappings.Add("batchId", "batchId");
            //cong.Open();
            //copy.WriteToServer(dt);
            //cong.Close();



            //con.Open();
            //StreamReader sr = new StreamReader(Application.StartupPath + "\\files\\test.csv");

            //while (!sr.EndOfStream)
            //{
            //    var data = sr.ReadLine().Split(',');

            //    cmd = new SqlCommand("insert into Students (firstName,lastName,fathersName,age,contactNo#,gender,course) values ('" + data[0] + "','" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "','" + data[5] + "','" + data[7] + "')", con);
            //    cmd.ExecuteNonQuery();
            //}
            //MessageBox.Show("data Inserted");
            //sr.Close();
        }

        private void DetailReminders_Click(object sender, EventArgs e)
        {
            loadReminders();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadMarks();
        }

        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void DetailGrpBtn_Click(object sender, EventArgs e)
        {
            loadGroups();
        }

        private void UpdateGrpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information Updated");
                loadGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelGrpBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Groups where grpId =" + dataGridGrp.Rows[selectedId].Cells[0].Value;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Group Deleted");
            loadGroups();
        }

        private void dataGridGrp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }

        private void searchGroups_KeyUp(object sender, KeyEventArgs e)
        {
            string sg = searchGroups.Text;
            searchBatch(sg);
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm();
            pf.Show();
        }

        private void searchProject_TextChange(object sender, EventArgs e)
        {
           
        }

        private void DetailMarksbtn_Click(object sender, EventArgs e)
        {
            loadMarks();
        }

        private void dataGridMarks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }

        private void UpdateMarksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information Updated");
                loadMarks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMarksBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Groups where grpId =" + dataGridViewUser.Rows[selectedId].Cells[0].Value;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
            loadMarks();
        }

        private void searchProjects_TextChange(object sender, EventArgs e)
        {
            string sp = searchProjects.Text;
            searchProject(sp);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            pnlOnUsers.Height = Usersbtn.Height;
            pnlOnUsers.Top = Usersbtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = false;
            pnlonLogOut.Visible = true;

            this.Close();
            Form1 lf = new Form1();
            lf.Show();
        }

        private void addRemindBtn_Click(object sender, EventArgs e)
        {

            try
            {
                scb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Reminder Added");
                addReminders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void popup()
        {
            //DateTime dueTime = ;//set someplace else

            //    if (DateTime.Now.AddDays(-2) >= dueTime)
            //{
            //    MessageBox.Show("Two Days Left to Submit Project");
            //}
            //     //Due time is in one month or less
        }

        private void DelReminders_Click(object sender, EventArgs e)
        {

        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MarksBtn_Click_2(object sender, EventArgs e)
        {
            pnlOnMarks.Height = MarksBtn.Height;
            pnlOnMarks.Top = MarksBtn.Top;
            //pnlOn Click
            pnlOnUsers.Visible = false;
            pnlonStudents.Visible = false;
            pnlOnBatches.Visible = false;
            pnlOnGroups.Visible = false;
            pnlOnProjects.Visible = false;
            pnlOnReminders.Visible = false;
            pnlOnMarks.Visible = true;
            pnlonLogOut.Visible = false;

            UsersPnl.Visible = false;
            StudentsPnl.Visible = false;
            BatchesPnl.Visible = false;
            Groupspnl.Visible = false;
            Projectspnl.Visible = false;
            ReminderPnl.Visible = false;
            MarkPnl.Visible = true;
        }
    }
}
