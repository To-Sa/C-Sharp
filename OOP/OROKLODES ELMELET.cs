using System;
using System.Windows.Forms;

namespace PCC
{
    /*  - Minden osztály őse az Object, akkor is, ha ezt nem jelöljük.
            - A már leszármaztatott osztálynak is lehetnek további örökösei, 
                így egy hierarchia alakul ki közöttük, egy osztálynak több leszármazottja is lehet, ugyanakkor csak egy őse!*/

    class Nagyszülő { }
    class Szülő : Nagyszülő { }
    class Gyerek1 : Szülő { }
    class Gyerek2 : Szülő { }

    //ősosztályban a leszármazott osztályok közvetlenül, míg a különálló osztályok példányosítás álltal tudják elérni
    
    class A                                                                     // PUBLIC   PROTECTED   PRIVATE láthatóság esetén
    {
        public int IntA; void Kiír() { MessageBox.Show(IntA.ToString()); }      // OK       OK          OK  
    }
    class B : A
    {
        void Kiír() { MessageBox.Show(IntA.ToString()); }                       // OK       OK          NOK
    }
    class C
    {
        void Kiír() { A a = new A(); MessageBox.Show(a.IntA.ToString()); }      // OK       NOK         NOK
    }

    /*  A konstruktorok nem öröklődnek, 
        ha az ősosztályban van paraméter nélküli konstruktor, a leszármazott osztály konstruktorában hivódik meg, 
        ha paraméterezve van az ősosztály konstruktora, akkor viszont a gyermek konstruktorában kell meghívni a base kulcsszóval.*/

    class X
    {
        private int a;
        public X(int a)
        {
            this.a = a;
        }
    }

    class Y : X //Mivel az leszármaztatott osztály örökli az „a” mezőt, ezért hibás az alábbi gyermekosztály konstruktora.
    {
        protected int b;
        public Y(int b) { this.b = b; }
    }

    class Y : X
    {
        protected int b;
        public X(int b, int a) : base(a)
        {
            this.b = b;
        }
    } //Ha az ősosztály mezője privát, így csak az ősosztály konstruktorával tudnánk beállítani a mezőt, különben elég lenne a base.mezőnév = xy; beállítani.

    //Attól még, hogy mi privátnak állítjuk be az ősök mezőit, attól még öröklődnek, csak nem látjuk.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }   
    }
}
