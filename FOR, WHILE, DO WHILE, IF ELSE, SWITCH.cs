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
            for (int i = 0; i < 20 && i != 10; i++) // FOR
            {
                listBox1.Items.Add(i);
            }

            for (int i = 800; i < 1000; i++)    //Egymásba ágyazott ciklusok FOR-val.
            {
                bool primszam = true;

                for (int j = 2; j < i && primszam; j++)
                {
                    if (i % j == 0) primszam = false;
                }

                if (primszam) listBox1.Items.Add(i);
            }

            int k = 100;
            while (k > 90)  // WHILE
            {
                listBox1.Items.Add(k);
                k--;
            }

            int l = 22222;  // DO WHILE > legalább 1-szer lefut a ciklusmag
            do
            {
                listBox1.Items.Add(l);
                l++;
            }
            while (l < 22229);

            if(k == 1)  // IF ELSE
            {
                listBox1.Items.Add("1");
            }
            else if(k == 2)
            {
                listBox1.Items.Add("2");
            }
            else
            {
                listBox1.Items.Add("NO");
            } //Fontos: egy blokkon, cikluson belül deklarált változó csak a blokkon belül használható, a ciklusmagon kívül nem létezik.

            switch (k)  // SWITCH CASE
            {
                case 1: { listBox1.Items.Add("1"); } break;
                case 2: { listBox1.Items.Add("2"); } break;
                default: { listBox1.Items.Add("NOK"); } break;
            }

            //BREAK:    
                        /*a ciklusból való kilépést, és a ciklus futásának felfüggesztését eredményezi*/
            //CONTINUE: 
                        /*a ciklusfutását úgy változtatja meg, hogy ha elér a continuig a ciklusmag az utána*/

            //A BREAK és a CONTINUE használata nem ajánlott, mert nem része a strukturált programozásnak!

        }
    }
}
