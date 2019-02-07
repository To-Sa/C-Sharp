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
            Jármű j = new Jármű(30);
            JárműKiír(j, 10);
            Autó a = new Autó(120, 5, 20); //nincs szintaktikai hiba, hiába Jármű példányt vár az eljárás: 
            JárműKiír(a, 10);

            Autó auto = new Autó(120, 5, 20); //Mivel az autó is egy jármű a következő kód érvényes.
            Jármű jarmu = auto;

            Jármű j2 = new Jármű(30);
            //Autó a2 = j2; De mivel egy jármű nem biztos, hogy autó a következő kód csak explicit konverzióval érvényes:

            Jármű jK = new Jármű(30);
            Autó aK = (Autó)jK;
        }

        static void JárműKiír(Jármű j, int h)
        {
            MessageBox.Show(j.sebesség.ToString());
            MessageBox.Show(j.Megy(h).ToString());
        }

        /*
         Használjuk az "is" és az "as" operátort, az "is" true értéket ad vissza, ha a baloldalán megadott példány megfelel a jobb oldalon lévő típussal, 
         az "as" operátor megvalósítja a konverziót akkor, ha az objektum megegyezik a jobb oldalon megadott típussal különben null értékre állítja be a példányt,
             */
        static void JárműKiír_1(Jármű j, int h)
        {
            MessageBox.Show(j.sebesség.ToString());
            MessageBox.Show(j.Megy(h).ToString());
            if (j is Autó)
            {
                Autó a = (Autó)j;
                MessageBox.Show(a.ajtókSzáma.ToString());
                MessageBox.Show(a.Csomagtér.ToString());
            }
        }

        static void JárműKiír_2(Jármű j, int h)
        {
            MessageBox.Show(j.sebesség.ToString());
            MessageBox.Show(j.Megy(h).ToString());
            Autó a = j as Autó;
            if (a != null)
            {
                MessageBox.Show(a.ajtókSzáma.ToString());
                MessageBox.Show(a.Csomagtér.ToString());
            }
        }
    }

    class Jármű
    {
        public Jármű(int seb)
        {
            sebesség = seb;
        }
        public int sebesség;
        public int Megy(int h)
        {
            return h * sebesség;
        }
    }

    //Jármű osztály leszármazottjai is egy jármű, az autó is egy jármű (az – egy… - is - a). Így a jármű osztályra megírt metódusoknak az Autó objektumokat, példányokat is átadhatjuk.

    class Autó : Jármű  //minden autó jármű, de nem minden jármű autó
    {
        public Autó(int seb, int ajtóksz, int cst) : base(seb)
        {
            ajtókSzáma = ajtóksz; Csomagtér = cst;
        }
        public int ajtókSzáma;
        public int Csomagtér;
    }
}
