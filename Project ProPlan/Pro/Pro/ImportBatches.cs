using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pro
{
    public partial class ImportBatches : Form
    {
        public ImportBatches()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            //if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string fileName = OpenFileDialog1.FileName;

            //    StreamReader sr = new StreamReader(fileName);


            //    string dataa = sr.ReadToEnd();

            //    richTextBox1.Text = dataa;
            //    sr.Close();
            //}
        }

        private void loadExcel_Click(object sender, EventArgs e)
        {
            //string PathConn = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + textBoxPath.Text + ";Extended Properties=\"Excel8.0;HDR=Yes;\";";
            //OleDbConnection conn = new OleDbConnection(PathConn);

            //OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBoxSheet.Text + "$]", conn);
            //DataTable dt = new DataTable();

            //myDataAdapter.Fill(dt);
            //dataGridImport.DataSource = dt;
        }

        private void importBatchespnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void writeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
