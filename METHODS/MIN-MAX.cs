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

        void print(int[] tomb)
        {
            foreach (var elem in tomb)
            {
                listBox1.Items.Add(elem); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmb = new int[] { 2, 6, 0, 0, 2, 2, 9, 2, 3, 1, 4, 4, 8, 8, 8, 0 };

            int min = 0;
            int max = 0;

            algorithms.MinMax(tmb, out min, out max);
            listBox1.Items.Add(min + "; " + max);
        }

        class algorithms
        {
            public static void MinMax(int[] tmb, out int min, out int max)
            {
                int _min = tmb[0];
                int _max = tmb[0];

                for (int i = 0; i < tmb.Length; i++)
                {
                    if (tmb[i] < _min) _min = tmb[i];
                    if (tmb[i] > _max) _max = tmb[i];
                }
                min = _min;
                max = _max;
            }
        }
    }
}
