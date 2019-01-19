using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //METHODS: Clear, Contains, ToArray...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue<int> rowS = new Queue<int>();

            rowS.Enqueue(1);      //Queue - Sor ---FIFO First in First out
            rowS.Enqueue(2);
            rowS.Enqueue(3);      //.Enqueue
            rowS.Enqueue(4);

            foreach (int item in rowS)
            {
                listBox1.Items.Add(item);
            }

            while (rowS.Count != 0)
            {
                listBox1.Items.Add(rowS.Dequeue()); //get the 1st item and clear
            }
        }
    }
}
