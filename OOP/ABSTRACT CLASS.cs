using System;
using System.Windows.Forms;

namespace PCC
{
    //Előfordul olyan eset, amikor olyan általános ősosztályt kell megcsinálni, aminek 
    //nem tudjuk teljesen kidolgozni egyes metódusait a „fejletlensége” miatt, de pl.már egy másik metódus használná.
    class Síkidom
    {
        protected int x;
        protected int y;
        //A Síkidom osztályban az Animáció eljárás hiábahasználná már a Rajzol metódust, hiszen az nincs kidolgozva.
        public virtual void Rajzol() { } //virtual-t beszúrtunk ide
        public void Animáció(int x_A, int y_A)
        {
            Console.Clear();
            x += x_A;
            y += y_A;
            this.Rajzol();
        }
    }
    //A fejlesztő elfelejti felüldefiniálni egy virtuális metódust és erre semmilyen hibaüzenetet nem kap, ha használnák az adott eljárást nem történne semmi.
    //Ha nem void típusú lenne, akkor mégis valamilyen értéket visszakelljen adjon a függvény, hogy szintaktikailag helyes legyen, de mit adjunk vissza?
    class Vonal : Síkidom
    {
        protected int k;
        public override void Rajzol()
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < k; i++)
            {
                Console.Write("-");
            }
        }
    }

    /*Az ilyen jellegű metódusok/osztályok megfelelő készítése az abstract szóval történik, ezzel a szóval megmondjuk a fordítónak, 
      hogy az ősosztályban nem tudtuk megírni ezeket az eljárásokat, de deklaráljuk őket, hogy a gyermekosztályban használhatók legyenek. 
      Ezeket a metódusoknál nem kell {} tenni csak egy pontosvesszőt a deklaráció végére.*/
    //Csakis absztrakt osztályban lehetnek absztrakt metódusok, és absztrakt osztály példányosítását megtiltja a fordító.

    abstract class SíkidomAbstract
    {
        protected int x;
        protected int y;
        public abstract void Rajzol();
        public void Animáció(int x_A, int y_A)
        {
            Console.Clear();
            x += x_A;
            y += y_A;
            this.Rajzol();
        }
    }
    class VonalAbstract : SíkidomAbstract
    {
        protected int k;
        public override void Rajzol()
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < k; i++)
            {
                Console.Write("-");
            }
        }
    }

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
