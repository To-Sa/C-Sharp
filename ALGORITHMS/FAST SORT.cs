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
            algorithms.fastSort(tmb);
            print(tmb);
        }

        class algorithms
        {
            public static void fastSort(int[] tmbb, int start = 0, int end = -1)
            {
                if (end == -1) end = tmbb.Length - 1;
                if (start < end)
                {
                    int kozepe = split(tmbb, start, end);
                    fastSort(tmbb, start, kozepe - 1);
                    fastSort(tmbb, kozepe + 1, end);
                }
            }

            private static int split(int[] tmbd, int start, int end)
            {
                int middle = tmbd[end];
                int middleIndex = start;

                for (int i = start; i < end; i++)
                {
                    if (tmbd[i] <= middle)
                    {
                        int temp = tmbd[i];
                        tmbd[i] = tmbd[middleIndex];
                        tmbd[middleIndex] = temp;
                        middleIndex++;
                    }
                }

                int anotherTemp = tmbd[middleIndex];
                tmbd[middleIndex] = tmbd[end];
                tmbd[end] = anotherTemp;
                return middleIndex;
            }
        }
    }
}
