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
            int[] tombom = new int[9]; // ARRAY
            Random rand = new Random(); // RANDOM

            for (int i = 0; i < tombom.Length; i++)
            {
                tombom[i] = rand.Next(0, 100);
            }

            foreach (int kb in tombom)
            {
                listBox1.Items.Add(kb);
            }

            char[] sorba = new char[] { 'd', 'b', 'g', 'a' };

            foreach (var c in sorba)
            {
                listBox1.Items.Add(c);
            }

            Array.Sort(sorba); //SORT

            foreach (var c in sorba)
            {
                listBox1.Items.Add(c);
            }
        }
    }
}
