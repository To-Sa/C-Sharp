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
            // 1st create some label in form or button
            // OR use this > this.Controls.Find("label1", true)[0].BackColor = Color.Red;
            foreach (Label lab in this.Controls.OfType<Label>().Where(lab => lab.Name.StartsWith("label")))
            {
                if (lab.Name.StartsWith("label4"))
                {
                    lab.BackColor = Color.Red;
                }
                else
                {
                    lab.BackColor = Color.BlueViolet;
                } 
            }

            foreach (Button lab in this.Controls.OfType<Button>().Where(lab => lab.Name.StartsWith("butt")))
            {
                lab.BackColor = Color.BlueViolet;
            }
        }       
    }
}
