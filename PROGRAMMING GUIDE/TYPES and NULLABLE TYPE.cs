using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int x = 1000;
            var something = "3kjgkj%%";
            string zero = null;
            string[] str = new string[2] { null, "vmi" };

            MessageBox.Show(Convert.ToString(x));
            MessageBox.Show(something);
            MessageBox.Show(zero);
            MessageBox.Show(str[0]);
            MessageBox.Show(str[1]);
            MessageBox.Show(Convert.ToString(str.Length));

            int? asd = null;    // NULLABLE TYPE
            MessageBox.Show(Convert.ToString(asd));
        }       
    }
}
