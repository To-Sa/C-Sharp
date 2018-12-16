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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //PATH

            conn.ConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\DATAB.accdb; Jet OLEDB:Database Password=123456;";

            try
            {
                conn.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                command1.CommandText = "select * from  First_Table  where  Username='" + txtID.Text + "'  and Password='" + txtPW.Text + "' ";

                OleDbDataReader reader1 = command1.ExecuteReader();

                int count = 0;
                while (reader1.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("LOGIN OK", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear(); txtPW.Clear();
                }
                else if (count > 1)
                {
                    MessageBox.Show("DUPLICATED ID or PW!"); txtID.Clear(); txtPW.Clear();
                }
                else
                {
                    MessageBox.Show("WRONG ID or PW!"); txtID.Clear(); txtPW.Clear();
                }
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
    }
}
