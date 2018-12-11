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
            for (int i = 0; i < 20 && i != 10; i++) // FOR
            {
                listBox1.Items.Add(i);
            }

            int k = 100;
            while (k > 90)  // WHILE
            {
                listBox1.Items.Add(k);
                k--;
            }

            int l = 22222;  // DO - WHILE
            do
            {
                listBox1.Items.Add(l);
                l++;
            }
            while (l < 22229);
        }
    }
}
