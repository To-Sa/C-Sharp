using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //A struktúrák olyan adategységek, amelyekben különböző típusú adatokat foglalhatunk egy adatszerkezetbe.

        struct Diák
        {
            public string név; //a kapcsos zárójelek között a magadott mezők public láthatósággal
            public int életkor;
            public string lakhely;
            public List<int> jegyei;

            public Diák(string név, int k, string h) //konstruktor eljárást a struktúra nevével azonos nevű metódussal tudunk csinálni
            {
                this.név = név;
                this.életkor = k;
                this.lakhely = h;
                this.jegyei = null; //mivel kötelező az összes adattagot beállítani ezért a jegyei null
            }

            public void Kiír()
            {
                MessageBox.Show("Név: " + this.név); //A this szó, a struktúrán belüli mezők azonosítására szolgál.
                MessageBox.Show("Életkor: " + this.életkor);
                MessageBox.Show("Lakhely: " + this.lakhely);
                MessageBox.Show("Jegyei: ");
                foreach (int item in jegyei)
                {
                    MessageBox.Show(item + ", ");
                }
                MessageBox.Show("\nA diák átlaga: " + Átlag());
            }
            public double Átlag()
            {
                int összeg = 0;
                foreach (int item in this.jegyei)
                {
                    összeg += item;
                }
                return összeg / (double)this.jegyei.Count;
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            Diák d = new Diák();
            d.név = "Péter";
            d.lakhely = "Nyíregyháza";
            d.életkor = 15;
            MessageBox.Show("Neve: " + d.név);

            //Egy struktúrában megadhatunk eljárásokat és függvényeket is, ezeket nevezzük metódusoknak.

            Diák diak = new Diák("András", 17, "Sopron"); //struktúra deklarációjánál automatikusan lefutó metódust konstruktornak hívjuk
            d.jegyei = new List<int>() { 4, 5, 3, 5, 5, 4 }; //A struktúra egy értéktípus, tehát értékadáskor csak a mezők értékei másolódnak át.
            MessageBox.Show("A diák adatai:"); d.Kiír();

            //Például a lista, aminél referencia másolás történik, az egyes példányokon belül végzett módosítások nem hatnak a másik változóra. 
            //Egy struktúrából létrehozhatunk akár egy listát vagy tömböt is.
            List<Diák> diákok = new List<Diák>();
            Diák dd = new Diák("András", 17, "Sopron");
            diákok.Add(dd);
            //vagy rögtön: diákok.Add(new Diák("András", 17, "Sopron")); 
            //vagy tömb esetén: 
            Diák[] diákokT = new Diák[10];
            diákokT[0] = d;
        }
    }
}
