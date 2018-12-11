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
            int[] arrayka = new int[9];             // ARRAY

            Random rand = new Random();            // RANDOM

            for (int i = 0; i < arrayka.Length; i++)
            {
                arrayka[i] = rand.Next(0, 100);
            }

            foreach (int kb in arrayka)
            {
                listBox1.Items.Add(kb);
            }

            char[] cari = new char[] { 'd', 'b', 'g', 'a' };

            foreach (var c in cari)
            {
                listBox1.Items.Add(c);
            }

            Array.Sort(cari);       //SORT

            foreach (var c in cari)
            {
                listBox1.Items.Add(c);
            }
        }
    }
}
