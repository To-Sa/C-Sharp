using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int sum(int max = 10)
        {
            int summmm = 0;
            for (int i = 1; i < max; i++)
            {
                summmm += i;
            }
            return summmm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                private static void Failed(int optional = 10, int something)        <= DO NOT WORKING
                
                   good sequence: first: compulsory parameter >>> optional parameter
                
            */

            var t1 = sum();             //sum 1-10
            var t2 = sum(100);          //sum 1-100
            listBox1.Items.Add(t1);
            listBox1.Items.Add(t2);
        }

        void Method(int value = 1, string name = "Joe")
        {
            listBox1.Items.Add(value + "; " + name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method();
            Method(2000);
            Method(5000, "Tom");
            Method(name: "White");
            Method(value: 5, name: "Red");
        }
    }
}
