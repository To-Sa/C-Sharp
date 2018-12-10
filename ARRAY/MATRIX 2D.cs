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
            var matrix_2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9,},
                { 77, 88, 99,}
            };

            for (int i = 0; i < matrix_2D.GetLength(0); i++)        //FOR
            {
                for (int j = 0; j < matrix_2D.GetLength(1); j++)
                {
                   listBox1.Items.Add(matrix_2D[i, j]);
                }
            }

            foreach (var elem in matrix_2D)     //FOREACH
            {
                listBox1.Items.Add(elem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[4, 2];

            Random r = new Random();

            for (int i = 0; i < matrix.GetLength(0); ++i)       //ROWS
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)   //COLUMNS
                {
                    matrix[i, j] = r.Next(1001, 1110);
                }
            }

            foreach (var elem in matrix)     //FOREACH
            {
                listBox1.Items.Add(elem);
            }
        }
    }
}
