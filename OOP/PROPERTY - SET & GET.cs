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
        /*
            Publikus adattagoknál, mezőknél nem tudunk ellenörzést csinálni, hogy ha csak bizonyos értékeket adhassunk meg, 
            akkor külön eljárást kell írnunk, viszont ez nem írható/olvasható közvetlenül, 
            ezért jellemzőket, tulajdonságokat (property) kell írnunk.
        */
        /*  Olyan speciális osztályelem, amely bár mező és változó módjára viselkedik, 
            de olvasása és írása esetén a memóriaterületek közvetlen írása helyett, 
            a megadott olvasó (get) és/vagy író (set) metódusok kerülnek meghívásra és azok futnak csak le.
        */

        private void button1_Click(object sender, EventArgs e)
        {
            //Ember em = new Ember("", 10, 9456);

            Idő idő = new Idő();
            idő.Másodperc = 180;
            //MessageBox.Show(idő.Másodperc.ToString()); //<-- mivel csak set metódust állítattunk be ez hibás 
            MessageBox.Show(idő.Perc.ToString());
        }

        class Ember
        { 
            //Ha a tulajdonságokkal adjuk meg a konstruktort akkor is ellenörzést végez 
            public Ember(string n, int é, int isz)
            {
                Név = n;
                Életkor = é;
                Irányítószám = isz;
            }

            private string név;
            public string Név
            {
                get { return név; }
                set { if (value.Length != 0) név = value; else Exception("A név mező nem lehet üres!"); }
            }
            private int életkor;
            public int Életkor
            {   get { return életkor; }
                set { if (value >= 0) életkor = value; else Exception("Az életkor mező nem lehet negatív"); }
            }
            private int irányítószám;
            public int Irányítószám
            {
                get { return irányítószám; }
                set { if (value.ToString().Length == 4) irányítószám = value; else Exception("Az irányítószám mező helytelen!"); }
            }
            private void Exception(string s)
            {
                MessageBox.Show(s);
                throw new FormatException(s);
            }
        }

        /*  Egy jellemző lehet csak írható (writeonline csak set metódus), 
            csak olvasható (readonline – csak get metódus) vagy írható és olvasható is.
        */

        class Idő
        {
            private int másodperc;
            public int Másodperc
            {
                //csak írható 
                set { if (value > 0) másodperc = value; else Exception("Nem lehet negatív!"); }
            }

            public double Perc
            { 
                //csak olvasható 
                get { return másodperc / 60.0; }
            }
            private void Exception(string s)
            {
                throw new FormatException(s);
            }
        }
    }
}
