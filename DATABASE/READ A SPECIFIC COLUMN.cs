using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OleDbConnection conn = new OleDbConnection();       //new DATABASE CONNECTION

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //DESKTOP PATH

            conn.ConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\DATAB.accdb; Jet OLEDB:Database Password=123456;";

            try
            {
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                command1.CommandText = "select NAME from  First_Table"; //READ A SPECIFIC COLUMN

                OleDbDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    listBox1.Items.Add("NAME: " + reader1[0]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
    }
}
