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

        private void button1_Click(object sender, EventArgs e)
        {
            double value = 3.14;
            listBox1.Items.Add(value);
            valueSwap(value);
            listBox1.Items.Add(value);
            listBox1.Items.Add("-----");

            classExample o = new classExample();
            o.ert = 3.14;
            listBox1.Items.Add(o.ert);
            refExample(o);
            listBox1.Items.Add(o.ert);
        }

        static void valueSwap(double ertek)
        {
            ertek = 2.1 +5;
        }

        static void refExample(classExample refer)
        {
            refer.ert = 2.1 + 5;
        }

        class classExample
        {
            public double ert;
        }
    }
}
