using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using CsvHelper;

namespace Pro
{
    public partial class importCSV : Form
    {
        //public string StdId { get; set; }
        //public string FirstN { get; set; }
        //public string LastN { get; set; }
        //public string FatherN { get; set; }
        //public string Age { get; set; }
        //public string Gender { get; set; }
        //public string ContactNo { get; set; }
        //public string Course { get; set; }
        //public string Semester { get; set; }
        //public string BatchId { get; set; }


        public importCSV()
        {
            InitializeComponent();
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            //SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            //if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string fileName = SaveFileDialog1.FileName;

            //    StreamWriter sw = new StreamWriter(fileName);


            //    string dataa = sw.Write(File);


            //    dataGridImport.Text = dataa;
            //    sw.Close();
            //}
        }


        private void importCSV_Load(object sender, EventArgs e)
        {
            //importBatchesBindingSource.DataSource = new List<importCSV>();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {

            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
            //        var csv = new CsvReader(sr);
            //        importBatchesBindingSource.DataSource = csv.GetRecord<importCSV>();
            //    }
        }

        private void importBatch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSheet_TextChange(object sender, EventArgs e)
        {
            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
            //        var csv = new CsvReader(sr);
            //        dataGridImport.DataSource = csv.GetRecord<importCSV>();
            //    }
        }

        private void WriteBtn_Click_1(object sender, EventArgs e)
        {
            //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV*.csv", ValidateNames = true })
            //{
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        using (var sw = new StreamWriter(sfd.FileName))
            //        {
            //            var writer = new CsvWriter(sw);
            //            writer.WriteHeader(typeof(importCSV));
            //            foreach (importCSV s in importBatchesBindingSource.DataSource as List<importCSV>)
            //            {
            //                writer.WriteRecord(s);
            //            }
            //        }
            //        MessageBox.Show("Your Data Has Been Successfully Saved.", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //    }
            //}
        }

        private void loadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = OpenFileDialog1.FileName;

                StreamReader sr = new StreamReader(fileName);


                string dataa = sr.ReadToEnd();

                richTextBox1.Text = dataa;
                sr.Close();
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = SaveFileDialog1.FileName;

                StreamWriter sr = new StreamWriter(fileName);
                using (StreamWriter sw1 = new StreamWriter(@"D:\text.csv", true))
                {
                    sw1.WriteLine(richTextBox1.Text);
                    sw1.Close();
                }
                //    string dataa = sr.WriteLine();

                //richTextBox1.Text = dataa;
                //sr.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
