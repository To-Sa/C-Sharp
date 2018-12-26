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

        private OleDbConnection conn = new OleDbConnection();   //new DATABASE CONNECTION

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //DESKTOP PATH

            conn.ConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\DATAB.accdb; Jet OLEDB:Database Password=123456;";

            try
            {
                conn.Open();
                OleDbCommand command1 = new OleDbCommand("SELECT COUNT(*) FROM First_Table WHERE ([userid] = @userid)", conn);

                command1.Parameters.AddWithValue("@userid", txtID.Text);

                int UserExist = (int)command1.ExecuteScalar();

                if (UserExist > 0)
                {
                    MessageBox.Show("Exist");
                }
                else
                {
                    MessageBox.Show("Not exist");
                }

                conn.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        } 
    }
}
