using System;
using System.Windows.Forms;

namespace PCC
{
    class Kutya
    {
        public string nev;
        private int ehsegJelzo = 10;

        public Kutya(string n, int eh) //ez a KONSTRUKTOR
        {
            this.nev = n;
            this.ehsegJelzo = eh;
            MessageBox.Show("KONSTRUKTOR...");
        }

        public Kutya() { } //Destruktor
        ~Kutya()
        {
            MessageBox.Show("Destruktor...");
        }

        public void etet(int kaja)
        {
            ehsegJelzo -= kaja;
        }

        public void jatek()
        {
            if (ehsegJelzo <= 80)
            {
                ehsegJelzo += 50;
                MessageBox.Show("Játék...");
            }
            else
                MessageBox.Show("A kutya éhes, nem tudsz játszani vele!");
        }
    }

    class Ember
    {
        /*  Túlterhelés esetén az osztályokban nem kell teljesen új konstruktort megadni, elég egy olyan konstruktort írni, ami az összes adattagot beállítja, 
            majd egy eltérő paraméterlistával rendelkező konstruktort írni, majd utána ":" (kettősponttal) this(paraméterek) alakban megadni az adott konstruktort,
            a nem megadott mezőket állítjuk értéktípusú(int, double) esetén 0-ra referencia típus esetén null értékre. 
            Így az új konstruktorunk gyakorlatilag csak meghívja a teljes értékűt.
        */
        public string nev;
        public int eletkor; 
        //összes értéket beállító konstruktor 
        public Ember(string név, int életkor)
        {   this.nev = név;
            this.eletkor = életkor;
        } 
        //csak a nevet beállító 
        public Ember(string név) : this(név, 0){ }
    }

        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*  KONSTRUKTORNAK hívjuk egy osztály azon metódusát, mely az objektum példányositásakor kerül meghívásra, a paraméterekkel együtt.
            A konstruktort az osztály nevével kell megadni és public láthatósággal különben nem tudnánk elérni.
            A konstruktórból csinálhatunk többet is (túlterhelés), ekkor eltérő szignatúrájú konstruktorokat készítünk, melyek egymástól függetlenül használhatók.
        */

        /*  Az objektum adatmezőinek eltávolítását a DESTRUKTOR végzi, mivel a Garbage Collector autómatikusan végzi a szemét eltakarítását,
            nem determisztikusan (kiszámíthatóan) történik a destruktor meghívása, destruktort a ~OsztályNeve alakban tudjuk megadni, 
            destruktort struktúránál nem lehet megadni mivel értéktípus.
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Kutya kutyi = new Kutya("BUKSI", 12);
            kutyi.jatek();
        }
    }
}
