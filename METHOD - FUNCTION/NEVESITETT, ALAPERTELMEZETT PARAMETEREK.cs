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
            int a = 10;
            int b = 10;
            //Az aktuális paraméterlistán úgy adhatjuk meg az argumentumot, hogy megadjuk az adott formális paraméter nevét, 
            //amelyet kettősponttal zárunk le majd megadjuk az argumentum értékét.
            //Nem kell betartanunk azt a szabályt, hogy sorrendben is egyeznie kell a két paraméterlistának.
            int ertek = Szorzas(szam2:b = 10, szam1:a = 20);
            MessageBox.Show(ertek.ToString());

            //Alapértelmezett paraméterek, amelyek segítségével alapértelmezett értéket rendelhetünk hozzá egy formális paraméterhez.
            //Formális paraméterlista több alapértelmezett paramétert is tartalmazhat, azonban ezeknek mindig a lista végén kell lenniük.
            int c = 40;
            int alapParameterekErteke = AlapParameterek(c);
            MessageBox.Show(alapParameterekErteke.ToString());
        }
    
        private static int Szorzas(int szam1, int szam2)
        {
            return szam1 * szam2;
        }

        private static int AlapParameterek(int szam1, int szam2 = 200)
        {
            return szam1 * szam2;
        }
    }
}
        
