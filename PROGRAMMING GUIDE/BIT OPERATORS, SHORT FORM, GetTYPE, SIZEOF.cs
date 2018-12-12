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
            int x = 10;

            MessageBox.Show(Convert.ToString(127 & 2));
            MessageBox.Show(Convert.ToString(100 | 2));
            MessageBox.Show(Convert.ToString(1024 << 1));
            MessageBox.Show(Convert.ToString(1024 >> 1));   // BIT OPERATORS

            MessageBox.Show(Convert.ToString(x++));
            MessageBox.Show(Convert.ToString(++x));
            MessageBox.Show(Convert.ToString(x--));
            MessageBox.Show(Convert.ToString(--x));
            MessageBox.Show(Convert.ToString(x *= -5));     // SHORT FORM

            if (typeof(int) == x.GetType())
            {
                MessageBox.Show("Type of X is INT");    // TypeOf + GetType	
            }

            MessageBox.Show(Convert.ToString(sizeof(int)) + " BYTE");   // SIZEOF
        }       
    }
}
