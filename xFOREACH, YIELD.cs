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
            string elem = "OneTwoFiveNine";

            foreach (char gve in elem)     // FOREACH
            {
                listBox1.Items.Add(gve);
            }

            foreach (int jild in Enumerable_MET(10))
            {
                listBox1.Items.Add(jild);
            }
        }

        static public IEnumerable Enumerable_MET(int max)   // YIELD
        {
            for (int i = 0; i < max; i++)               // A metodus megtesz egy lepest majd kilep atadja az erteket, 
            {                                               // ujra meghivja es ott folytatja ahol abbahagyta es igy lesz a foreach korbejarasa
                yield return i;
            }
        }
    }
}
