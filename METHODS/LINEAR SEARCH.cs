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
            var tmb = new int[] { 2, 6, 0, 0, 2, 2, 9, 2, 3, 1, 4, 4, 8, 8, 8, 0 };

            int position = algorithms.linearSearch(tmb, 0);

            listBox1.Items.Add(position);
        }

        class algorithms
        {
            public static int linearSearch(int[] tmbb, int elem)
            {
                int index = -1;
                for (int i = 0; i < tmbb.Length; i++)
                {
                    if (tmbb[i] == elem)
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
        }
    }
}
