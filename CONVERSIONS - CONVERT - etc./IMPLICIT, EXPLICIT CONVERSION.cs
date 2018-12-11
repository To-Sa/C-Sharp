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
            long y = x;             // IMPLICIT > (small to large) 
            listBox1.Items.Add(x);
            listBox1.Items.Add(y);

            int z = 30; // 300
            byte zs = (byte)z;          // EXPLICIT > (large to small)
            listBox1.Items.Add(z);
            listBox1.Items.Add(zs);         // value =  44 because 1 0010 1100 is too large so > 0010 1100 : 44(dec)

            checked
            {
                int o = 300;                // CONVERSION check  ERROR msg.
                //byte u = (byte)o;
                listBox1.Items.Add(o);
                //listBox1.Items.Add(u);
            }

            int a = 300;                // CONVERSION check  only 1-1 elem
            //byte b = checked((byte)a);
            //listBox1.Items.Add(b);

            int c = 300;                // CONVERSION check > SWITCH off
            byte d = unchecked((byte)c);
            listBox1.Items.Add(d);
        }
    }
}
