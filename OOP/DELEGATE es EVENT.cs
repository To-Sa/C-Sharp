using System;
using System.Windows.Forms;

namespace PCC
{
    //Az event-eket másnéven eseményeket használó osztályok az osztály állapotának megváltoztatásakor értesíthetnek más osztályokat.
    //Létezik beépített delegate (EventHandler).
    class Szám
    {
        public delegate void EseménykezelőDelegate(string str);
        public event EseménykezelőDelegate ÁllapotváltozásEsemény;
        int szam = 0;
        public int Szam
        {
            get { return szam; }
            set
            {
                szam = value; //akkor indul be az esemény, ha megváltozik a szam mező: 
                ÁllapotVáltozás();
            }
        }
        private void ÁllapotVáltozás()
        {
            if (ÁllapotváltozásEsemény != null) ÁllapotváltozásEsemény("Megváltozott a szam mező!");
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void EseményKezelés(string str)
        {
            MessageBox.Show(str);
        }

        static void EseményKezelésEvent(object eseménytkiváltóosztály, Esemény e)
        {
            Console.WriteLine(e.üzenet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Szám sz = new Szám(); sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre 
            sz.Szam = 21; //kiváltjuk az eseményt; 

            Szám szEvent = new Szám(); sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre
            sz.Szam = 21; //kiváltjuk az eseményt;
        }

        /*Az eseménykezelőknek általában 2 paramétert szoktak megadni: egy objektumot, amin az esemény végbement, 
          valamint a második paraméter az EventArgs osztály vagy egy őse.*/
        class Esemény : EventArgs
        {
            public string üzenet;   
            public Esemény(string str) : base() { üzenet = str; }
        }
        class SzámEvent
        {
            public delegate void EseménykezelőDelegate(object o, Esemény e);
            public event EseménykezelőDelegate ÁllapotváltozásEsemény;
            int szam = 0;
            public int Szam
            { get { return szam; }
                set
                {
                    szam = value;
                    ÁllapotVáltozás();
                }
            }
            private void ÁllapotVáltozás()
            {
                if (ÁllapotváltozásEsemény != null)
                { 
                    ÁllapotváltozásEsemény(this, new Esemény("Változás!")); //a this-szel átadja az osztály saját magát 
                }
            }
        }
    }

}
        
