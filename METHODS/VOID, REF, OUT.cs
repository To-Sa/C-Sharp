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
            hiMessage();     //Print-out: HELLO
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hiMessage("HI");     //Print-out: HI 
        }

        static void hiMessage(string s = "HELLO")
        {
            MessageBox.Show(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20;
            int c = fv(a, b);
            MessageBox.Show("A: " + a.ToString() + " B: " + b.ToString() + " C: " + c.ToString()); // 10, 20, 60
        }

        static int fv(int egy, int ket)
        {
            egy = egy * 2;
            ket = ket * 2;

            return egy + ket;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20;
            int c = calc(ref a, ref b);
            MessageBox.Show("A: " + a.ToString() + " B: " + b.ToString() + " C: " + c.ToString());  // // 20, 40, 60
        }

        static int calc(ref int egy, ref int ket)
        {
            egy = egy * 2;
            ket = ket * 2;

            return egy + ket;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool par;
            Paros(3, out par);
            MessageBox.Show(par.ToString());
        }

        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0)
            {
                log = true;
            }
            else
            {
                log = false;
            }
        }
    }
}
