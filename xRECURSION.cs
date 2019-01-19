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
            ulong i = factorial(6);
            listBox1.Items.Add(i.ToString());
        }

        static ulong factorial(ulong num)        // RECURSION
        {
            if (num <= 1)
            {
                return num;
            }
            return num * factorial(num - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int floors = 10;
            floorsColor("F", 1, ref floors);
            floorsColor("P", 1, ref floors);
            floorsColor("Z", 1, ref floors);
            MessageBox.Show(variationNUm.ToString());
        }

        static int variationNUm;
        static void floorsColor(string s, int theFloorsNum, ref int theFloorsTo)
        {
            if (theFloorsNum < theFloorsTo)
            {
                switch (s)
                {
                    case "P": floorsColor("F", theFloorsNum + 1, ref theFloorsTo); break;

                    case "F":
                        floorsColor("F", theFloorsNum + 1, ref theFloorsTo);
                        floorsColor("P", theFloorsNum + 1, ref theFloorsTo);
                        floorsColor("Z", theFloorsNum + 1, ref theFloorsTo); break;

                    case "Z":
                        floorsColor("F", theFloorsNum + 1, ref theFloorsTo);
                        floorsColor("P", theFloorsNum + 1, ref theFloorsTo); break;
                }
            }
            else variationNUm++;
        }
    }
}
