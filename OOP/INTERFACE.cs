using System;
using System.Windows.Forms;

namespace PCC
{
    //Ha egy interfész egy osztály ősének állítunk, akkor meghatározza az osztály felületét, előír egy mintát.
    /*Interfésznek nagy előnye, hogy míg egy osztály csak egy db osztályból öröklődhet, 
      addig egy osztály több interfészt is használhat (class Osztály : Interfész1, Int2, …), 
      sőt interfészt akár struktúrák esetében is használhatunk. Az interfészek neveit konvenció szerint nagy "I" betűvel kezdjük. 
      Ugyanúgy, mint az absztrakt osztályoknál a metódusokhoz, jellemzőkhöz nem tartoznak definíciók, csak deklarációk.*/

    //Nem lehet láthatósági módosítót megadni alapértelmezetten publikusak lesznek.
    interface IKöszönés { void Reggel(); void Este(); void Napközben(); }
    interface IÜdvözlés { void Szia(string név); }
    class Köszönés_Üdvözlés : IKöszönés, IÜdvözlés
    {
        public void Reggel() { MessageBox.Show("Jó reggelt!"); }
        public void Este() { MessageBox.Show("Jó estét!"); }
        public void Napközben() { MessageBox.Show("Jó napot!"); }
        public void Szia(string név) { MessageBox.Show("Szia {0}!", név); }
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
