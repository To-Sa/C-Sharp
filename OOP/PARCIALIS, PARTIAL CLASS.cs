using System;
using System.Windows.Forms;

namespace PCC
{
    //Partial szócskát használjuk, akkor a fordítónak mondjuk meg, hogy az az osztály nem teljes, még további töredékei vannak.
    //Csak azonos láthatósági módosítót használhatnak.
    //Több programozó is képes dolgozni egy-egy osztályon anélkül, hogy azokat késöbb összekelljen másolni, külön .cs-ben is elhelyezhetjük.

    partial class PartialClass
    {
        public void Kiír1()
        {
            MessageBox.Show("Töredék 1 - Hy");
        }
    }
    partial class PartialClass
    {
        public void Kiír2()
        {
            MessageBox.Show("Töredék 2 - Hy");
        }
    }

    /*Beágyazott parciális osztályt a parciális osztály is tartalmazhat (a nem parciális is). 
     Parciális osztályon belül lévő beágyazott parciális osztályok töredékei az őt tartalmazó osztály töredékei között oszlik szét.
     
     Lehetőségünk van (C#3.0 felett) parciális metódusok használatára is, ekkor csak a metódus deklarációja és definíciója oszlik szét, 
     parciális metódusnak nem lehet láthatósági módosítója így privát lesz, és void-al kell visszatérnie, 
     ebben az esetben is a partial kulcsszót ki kell tenni minden előfordulásnál:*/

    partial class PartialClassKiir
    {
        partial void Kiír();
    }
    partial class PartialClassKiir
    {
        partial void Kiír()
        {
            MessageBox.Show("Szia");
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
            PartialClass pc = new PartialClass(); //Mind a két metódust használni tudjuk a mainben egy példány készitése esetén
            pc.Kiír1();
            pc.Kiír2();
        }  
    }
}
