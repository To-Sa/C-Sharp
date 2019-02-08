using System;
using System.Windows.Forms;

namespace PCC
{
    class EgészSzám
    {
        int szam;
        public int Szam { get { return szam; } set { szam = value; } }
        public EgészSzám(int szam) { this.szam = szam; }
        static public EgészSzám operator ++(EgészSzám sz1) { sz1.szam += 1; return sz1; } //++ megvalósítása
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            EgészSzám sz1 = new EgészSzám(7);
            EgészSzám sz2 = ++sz1; MessageBox.Show(sz1.Szam.ToString() + sz2.Szam.ToString()); //3, 3 
            EgészSzám sz3 = new EgészSzám(2);
            EgészSzám sz4 = sz3++; MessageBox.Show(sz3.Szam.ToString() + sz4.Szam.ToString()); //3, 3
        }  
    }
}
