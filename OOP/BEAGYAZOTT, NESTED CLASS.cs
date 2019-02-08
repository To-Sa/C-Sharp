using System;
using System.Windows.Forms;

namespace PCC
{
    //Belső osztályokat beágyazott (nested) osztályoknak nevezzük.
    //Alapértelmezetten private módosítóval vannak ellátva, így külső osztályok csak láthatóság módosítás esetén használhatják.
    class Külső
    {
        //Ha nem public lenne nem érnénk el.
        public class Belső
        {
            static public void Helló(string uzenet)
            {
                MessageBox.Show("Helló");
                MessageBox.Show(uzenet);
            }
        }
    }

    //A beágyazott osztály hozzáfér az őt tartalmazó külső osztály minden tagjához de csak akkor, ha a beágyazott osztály egy referenciát tárol a külső osztályról:
    class outClass
    {
        private int szam = 15; private Belső b;
        public outClass() { b = new Belső(this); }

        public class Belső
        {
            private outClass k;
            public Belső(outClass k) { this.k = k; }
            public void KiírKülsőSzám()
            { //ez hibás: MessageBox.Show(szam.ToString()); Megoldás: 
                MessageBox.Show(k.szam.ToString());
            }
        }
        /*Ebben az esetben csináltunk a belső osztálynak egy olyan konstruktort, 
          ami egy „Külső” osztálypéldányt vár, hogy onnan tudjuk kiolvasni a szam tartalmát, 
          a külső osztályban szintén csináltunk egy konstruktort, ami a meghívása esetén átadja a saját példányát,
          önmagát (a this segítségével) a belső osztály konstruktorának.*/
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            //A pont operátor segítségével érhetjük el:
            Külső.Belső.Helló("HELLÓ MINDENKI!");
        }  
    }
}
