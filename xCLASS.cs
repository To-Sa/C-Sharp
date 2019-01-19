using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PCC
{
    class person         // REF TYPE
    {
        public string name;
        public int age;
        public string address;
        public string job;
        public void WR()
        {
            MessageBox.Show("NAME: " + name);
            MessageBox.Show("AGE: " + age);
            MessageBox.Show("ADDRESS: " + address);
            MessageBox.Show("JOB: " + job);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person ts = new person();
            ts.name = "TOM";
            ts.age = 32;
            ts.address = "NY";
            ts.job = "XYZ Plc.";
            person e2 = ts; e2.name = "Joe";
            ts.WR();
            e2.WR();
        }
    }
}
