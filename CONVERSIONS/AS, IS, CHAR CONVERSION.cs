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

            if (x is int)                           // IS: use in the INTERFACE
            {
                listBox1.Items.Add("X is INT");
            }

            object a = "123";                       // "AS" like "IS", but use the conversion, ONLY use with REF. types
            object b = "HELLO";                             // REF. types.: class, interface, object, string, array, delegate
            object c = 10;

            string aa = a as string;
            string yes = aa == null ? "NULL" : aa;
            listBox1.Items.Add(yes);

            string bb = b as string;
            string yes2 = bb == null ? "NULL" : bb;
            listBox1.Items.Add(yes2);

            string cc = c as string;
            string yes3 = cc == null ? "NULL" : cc;
            listBox1.Items.Add(yes3);

            for (char ch = 'a'; ch < 'z'; ch++)             // UNICODE NUMBERS
            {
                listBox1.Items.Add((int)ch);
            }
        }

    }
}
