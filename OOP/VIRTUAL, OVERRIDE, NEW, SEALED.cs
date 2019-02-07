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
         POLIMORFIZMUS!!!
         Egy osztályhierarchián belül egy adott metódusnak más-más alakjai is létezhetnek, 
         úgy hogy csak a program futása során derül ki, hogy melyik metódus fog lefutni, melyik fog meghívásra kerülni (polimorfizmus).
        */

        //Az alábbi módosítók adják meg, hogy a metódus felülbírálható-e, elfeledhető-e…

            // VIRTUAL 
        //A virtual módosítóval ellátott metódus a leszármaztatott osztályokban felülbírálható az override-el

            // OVERRIDE 
        //Az override módosítót a leszármazott osztályban annak a metódusunk elé kell tenni, 
        //aminek az ősosztályában az eljárásnál a virtual szerepel, így átdefiniálhatjuk, felülbírálhatjuk az ősmetódust.
        
            // NEW 
        //A new módosító az ősosztályban létrehozott metódusokat elfedi, árnyékolja
        
            // SEALED 
            //A sealed módosítóval ellátott metódust később nem tudjuk felülbírálni, ha osztály előtt használjuk, azzal jelezzük, hogy az osztálynak nem lehetnek leszármazottjai

        private void button1_Click(object sender, EventArgs e)
        {
            Emlősök emlos = new Emlősök(); emlos.Evés(); //Etetés 
            Kutya k = new Kutya(); k.Evés(); //Etetés, farok csóválás 
            Labrador l = new Labrador();l.Evés(); //Etetés, ugatás 
        }

        //Az override módosítóval ellátott eljárások egyben virtual módosítóval elvannak látva, így a további leszármazott osztályok is felültudják definiálni.
        class Emlősök           { public virtual void Evés()    { MessageBox.Show("Etetés"); } }
        class Kutya : Emlősök   { public override void Evés()   { MessageBox.Show("Etetés, farok csóválás"); } }
        class Labrador : Kutya  { public override void Evés()   { MessageBox.Show("Etetés, ugatás"); } }

        class KutyaNew : Emlősök { public new void Evés() { Console.WriteLine("Etetés, farok csóválás"); } }
        //Ugyanakkor a kutya további leszármazottjai a new módosító miatt nem tudják felülírni az Evés metódust, 
        //így ha azt szeretnénk, hogy továbbra is módosítható legyen a new szó után használjuk újra a virtual szócskát:
        class KutyaNewVirtual : Emlősök  { public new virtual void Evés() { Console.WriteLine("Etetés, farok csóválás"); } }
        class LabradorOverride : KutyaNewVirtual { public override void Evés() { Console.WriteLine("Etetés, ugatás"); } }


        //Ha a sealed kulcsszót egy osztály előtt használjuk, akkor azt mondjuk meg, hogy az osztálynak már nem lehetnek további leszármazottai, 
        //így például a Labrador osztályt tobább nem lehet származtatni:
        sealed class LabradorSealed : Kutya { public override void Evés() { Console.WriteLine("Etetés, ugatás"); } }
        class SzomszédKutyájaSealed : LabradorSealed
        { 
            //hiba: Cannot derive from sealed type 'Labrador' 
        }

        //A sealed módosítót metódusoknál csak az override-al együtt használhatjuk, azt mondjuk meg, 
        //hogy az adott metódust már nem lehet a leszármaztatott osztályokban felülbírálni, igy a Labrador osztály helytelen:
        class KutyaSealedBad : Emlősök { public sealed override void Evés() { Console.WriteLine("Etetés, farok csóválás"); } }
        class LabradorSealedBad : KutyaSealedBad { public override void Evés() { Console.WriteLine("Etetés, ugatás"); } }
    }
}
