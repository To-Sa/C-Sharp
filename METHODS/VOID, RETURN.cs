using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
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
            upM();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = load();
            listBox1.Items.Add(i.ToString());
        }

        void upM()
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        static int load()
        {
            return 4324 + 8652;
        }
    }
}
