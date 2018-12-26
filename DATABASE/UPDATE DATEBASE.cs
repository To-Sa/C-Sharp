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
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = conn;

                //                                                 \/'"string"'                    \/"int"
                string str = "update First_Table set USERPASS='"+ txtPW.Text + "' where IDs= " + txtID.Text + "";

                //Don't use the specific words, for example:    PASSWORD
                //string str = "update First_Table set          PASSWORD='"     + txtPW.Text + "' where IDs= " + txtID.Text + "";

                MessageBox.Show(str);

                command1.CommandText = str;

                command1.ExecuteNonQuery();

                MessageBox.Show("OK");

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
