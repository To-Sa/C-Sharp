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
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                double y = r.NextDouble()*10;
                listBox1.Items.Add(r.Next(1, 100));
                listBox1.Items.Add(y);
                //r.NextBytes(); - byte tömbök feltöltésére szolgál
            }
        }
    }
}
