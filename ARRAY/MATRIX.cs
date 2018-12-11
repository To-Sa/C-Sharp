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
            int[,] matrix = new int[9, 9];              // MATRIX

            int[,] tobbD = new int[,]
            {
                {4, 76, 87},
                {57, 98, 54},
                {24, 7, 867},
            };

            for (int i = 0; i < tobbD.GetLength(0); i++)
            {
                for (int j = 0; j < tobbD.GetLength(1); j++)
                {
                    listBox1.Items.Add(tobbD[i, j]);
                }
            }

            Random rand = new Random();
            for (int i = 0; i < tobbD.GetLength(0); i++)
            {
                for (int j = 0; j < tobbD.GetLength(1); j++)
                {
                    tobbD[i, j] = rand.Next(10000, 100000);
                    listBox1.Items.Add(tobbD[i, j]);
                }
            }
        }
    }
}
