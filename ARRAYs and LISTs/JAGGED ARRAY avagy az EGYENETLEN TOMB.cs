using System;
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
            int[][] mutatovektor = new int[][]
            {
                new int[] { 6, 2, 2, 7, 3 },
                new int[] { 3, 1 },
                new int[] { 12, 31, 56 }
            };

            for (int i = 0; i < mutatovektor.Length; i++)
            {
                for (int j = 0; j < mutatovektor[i].Length; j++)
                {
                    listBox1.Items.Add(mutatovektor[i][j]);
                }
            }

            listBox1.Items.Add("-------------------");

            foreach (int[] belsovektor in mutatovektor)
            {
                foreach (int elem in belsovektor)
                {
                    listBox1.Items.Add(elem);
                }
            }

            listBox1.Items.Add("-------------------");

            jaggedEgy();

            listBox1.Items.Add("-------------------");

            jaggedKetto();
        }

        void jaggedEgy()
        {
            int[][] jarray = new int[3][];  //A jagged array is an array whose elements are arrays.

            Random r = new Random();

            for (int i = 0; i < 3; ++i)
            {
                jarray[i] = new int[r.Next(1, 5)];

                for (int j = 0; j < jarray[i].Length; ++j)
                {
                    jarray[i][j] = i + j;
                    listBox1.Items.Add(jarray[i][j]);
                }
            }
        }

        void jaggedKetto()
        {
            var jagged = new int[][]
            {
                new int[] { 11, 12, 13 },
                new int[] { 14, 15, 16, 97 },
                new int[] { 17, 18, 19, 98, 99 }    //different dimensions and sizes
            };

            foreach (var row in jagged)
            {
                foreach (var columns in row)
                {
                    listBox1.Items.Add(columns);
                }
            }
        }
    }
}
