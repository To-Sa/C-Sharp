using System;
using System.Windows.Forms;

namespace PCC
{
    /*
        Az eddigi metódusok példánymetódusok voltak, tehát csak egy osztály példányosítása után volt lehetőségünk használni, 
        a statikus vagy osztálymetódusok a példányosítás nélkül vehetjük igénybe az Osztálynév.Statikusmetódusnév(paraméterek)–el.
        Statikus metódus esetén nem férünk hozzá az osztályunk mezőihez, így például csak a paraméterben átadott példány elemeit tudjuk használni.
    */

    class Diák
    {
        public string név;
        public int évfolyam;
        public void Kiír() //példánymetódus
        {  
            MessageBox.Show("Neve: " + this.név);
            MessageBox.Show("Éf.: " + this.évfolyam);
        }

        static public void Kiír(Diák d) //osztály/statikusmetódus
        {  
            //MessageBox.Show("Neve: " + this.név); <-- Hibás lenne 
            MessageBox.Show("Neve: " + d.név);
            MessageBox.Show("Éf.: " + d.évfolyam);
        }
    }

    class Állandók
    {
        //Használhatunk statikus mezőket is, melyhez csak közvetlenül az osztályon keresztül férhetünk hozzá.
        public static double PI = 3.14;
    }

    /*
        Ha csak statikus osztályok és mezők vannak az osztályunkban, lehetőségünk van statikus osztályok létrehozására is (ezzel vigyázzunk!!), 
        ekkor az osztályunk elé kell írni a static szót, de ha ezt tesszük, akkor az osztályból nem lehet példányt létrehozni. 
    */

    static class allandoPI
    {
        public static double PI = 3.14;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diák d = new Diák();
            d.név = "Szabó Tamás";
            d.évfolyam = 11;
            d.Kiír(); //<-- példánymetódus 
            Diák.Kiír(d); //<-- osztály/statikusmetódus 

            double pi = allandoPI.PI;
            MessageBox.Show(pi.ToString()); //Ez esetben csak így használható fel az osztály PI mezője.
        }
    }
}
