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

        void print(int[] tmbb)
        {
            foreach (var elem in tmbb)
            {
                listBox1.Items.Add(elem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmb = new int[] { 2, 6, 0, 0, 2, 2, 9, 2, 3, 1, 4, 4, 8, 8, 8, 0 };

            //BEFORE
            print(tmb);

            listBox1.Items.Add("---------");

            //AFTER
            var afterSwap = algorithms.sortWithSwap(tmb);
            print(afterSwap);
        }

        class algorithms
        {
            public static int[] sortWithSwap(int[] input)
            {
                int[] tmb = new int[input.Length];
                Array.Copy(input, tmb, input.Length);

                for (int i = 0; i < tmb.Length; i++)
                {
                    for (int j = 0; j < tmb.Length; j++)
                    {
                        if (tmb[i] < tmb[j])
                        {
                            var tmp = tmb[i];
                            tmb[i] = tmb[j];
                            tmb[j] = tmp;
                        }
                    }
                }
                return tmb;
            }
        }
    }
}
