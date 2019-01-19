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

        string alma = "alma"; //A string az alábbi módon írható fel, mint char tömb, mérete változtatható(stringnek). 
        char[] almaTomb = new char[] { 'a', 'l', 'm', 'a' };

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alma.Length.ToString()); //4
            MessageBox.Show(almaTomb.Length.ToString()); //4

            for (int i = 0; i < alma.Length; i++)
            {
                listBox1.Items.Add(alma[i]);
            }

            foreach (var item in alma)
            {
                listBox1.Items.Add(item);
            }

            //string.Substring(honnantól, hány darabot) 
            string str = alma.Substring(1, 2);
            MessageBox.Show(str); //alma >>> lm

            //string.IndexOf(keresett string, mettől keressem)
            string str2 = alma.Substring(0, 2);
            MessageBox.Show(str2); //alma >>> al

            //string.Replace(régi string, új string)
            string str3 = alma.Replace("al", "");
            MessageBox.Show(str3); //alma >>> ma

            //string.ToUpper()/ToLower
            string str4 = alma.ToUpper();
            MessageBox.Show(str4); //alma >>> ALMA

            //string.Split(határoló karakter) - A megadott határoló karakter mentén szét darabolja a stringet
            string splitreFel = "C# programozás könyv";
            string[] strT = splitreFel.Split(' ');
            foreach (string item in strT)
            {
                listBox1.Items.Add(item);
            }

            //string.Trim() - Láthatatlan karaktereket töröl le a string elejéről és végéről.
            char[] charsTrim = { '*', ' ', '\'' };
            string szoveg = "*** SZOVEG";
            listBox1.Items.Add(szoveg);
            string eredmeny = szoveg.Trim(charsTrim);
            listBox1.Items.Add(eredmeny);

            //string.Remove(honnantól, mennyit)
            string str5 = alma.Remove(2, 2);
            MessageBox.Show(str3); //alma >>> al

            //string.Contains(string)
            string almaFa = "almaFa";
            bool hamise = almaFa.Contains("fa");
            MessageBox.Show(hamise.ToString()); //hamis
            bool igaze = almaFa.Contains("Fa");
            MessageBox.Show(igaze.ToString()); //igaz

            //string.Insert(hova , mit)
            string str6 = alma.Insert(0, "Fa "); 
            string str7 = alma.Insert(4, "Fa"); 
            MessageBox.Show(str6); //Fa alma
            MessageBox.Show(str7); //almaFa

            //string.PadLeft/Padright(hosszúság, mit) - Kiegészíti az adott stringet a megadott hosszúságig a megadott karakterrel balról vagy jobbról feltöltve.
            string str8 = alma.PadRight(10, '?');
            MessageBox.Show(str8); //alma??????
        }
    }
}
