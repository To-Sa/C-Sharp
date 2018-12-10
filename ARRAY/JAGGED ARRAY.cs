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

        private void button2_Click(object sender, EventArgs e)
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
