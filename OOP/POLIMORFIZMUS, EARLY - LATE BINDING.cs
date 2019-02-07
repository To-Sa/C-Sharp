using System;
using System.Windows.Forms;

namespace PCC
{
    class FegyverekKorai { public int Sebzés() { return 20; } }
    class GépfegyverKorai : FegyverekKorai { public int Sebzés() { return 5 * 20; } }

    class FegyverekKesei { public virtual int Sebzés() { return 20; } }
    class GépfegyverKesei : FegyverekKesei { public override int Sebzés() { return 5 * 20; } }

    class FegyverekToString { public override string ToString() { return "Egyéb infók: . . . "; } }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void ElsütKorai(FegyverekKorai f)
        {
            /* Ebben az esetben mivel nem írtuk felül (nem volt virtual és override), 
             ezért mind a kettő fegyver elsütésénél 20-at írt ki a képernyőre a korai kötés (early binding) miatt. */
            MessageBox.Show("Sebzés mértéke: " + f.Sebzés().ToString());
        }

        static void ElsütKesei(FegyverekKesei f)
        {
            /*Egészítsük ki tehát a virtualal az ősmetódust és overridal a Gépfegyver osztály metódusát:*/
            MessageBox.Show("Sebzés mértéke: " + f.Sebzés().ToString());
            /*A nyelvnek azt a képességét, miszerint futási időben is képes dönteni késői (late binding), 
             míg a deklarációkor, fordításkor lefutó típusmeghatározás a korai kötés.*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Mivel Fegyver példányt vár az Elsüt eljárás, ezért került meghívásra mind a két esetben a 20-as, tehát a fegyverhez tartozó érték.*/
            FegyverekKorai fegyverKorai = new FegyverekKorai();
            ElsütKorai(fegyverKorai);
            GépfegyverKorai gepfegyverKorai = new GépfegyverKorai();
            ElsütKorai(gepfegyverKorai);

            /*Polimorfizmus azt a tulajdonságot jelenti, hogy futási időben dönti el, melyik metódus fusson le.*/
            FegyverekKesei fegyverKesei = new FegyverekKesei();
            ElsütKesei(fegyverKesei);
            GépfegyverKesei gepfegyverKesei = new GépfegyverKesei();
            ElsütKesei(gepfegyverKesei);

            /*Például ha egy olyan Fegyver kollekciót hozunk létre, amelyben különböző fegyverek vannak, akkor nem kell aggódnunk amiatt, 
             hogy egy foreach vagy for-ciklus esetén ugyanazok a metódusok futnak le*/
            FegyverekKesei[] fT = new FegyverekKesei[] { new FegyverekKesei(), new GépfegyverKesei() };
            foreach (FegyverekKesei item in fT)
            {
                MessageBox.Show("Sebzés mértéke: " + Convert.ToString(item.Sebzés()));
            }

            //Mivel minden osztály az Object osztályból származik, örökli a ToString() nevezetű metódusát, ezt mi felül tudjuk írni:
            //Ha nem hívjuk meg külön a ToString metódust és csak közvetlenül a változót íratjuk ki, akkor is a ToString függvény értékét adja vissza:
            FegyverekToString fegyverToString = new FegyverekToString(); MessageBox.Show(fegyverToString.ToString());
        }  
    }
}
