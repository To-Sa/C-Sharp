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
            var bub = algorithms.bubble(tmb);
            print(bub);
        }

        class algorithms
        {
            public static int[] bubble(int[] input)
            {
                int[] tmbb = new int[input.Length];
                Array.Copy(input, tmbb, input.Length);

                var swap = true;

                for (int i = tmbb.Length - 1; i >= 0 && swap; i--)
                {
                    swap = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (tmbb[j] > tmbb[j + 1])
                        {
                            int tmp = tmbb[j];
                            tmbb[j] = tmbb[j + 1];
                            tmbb[j + 1] = tmp;
                            swap = true;
                        }
                    }
                }
                return tmbb;
            }
        }
    }
}
