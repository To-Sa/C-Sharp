using System;
using System.Windows.Forms;

namespace PCC
{
    class Kutya
    {
        public string nev; 
        private int ehsegJelzo = 10;

        //Public: bárhonnan hozzáférhetünk, az adatmezőt/eljárást lekérhetjük, módosíthatjuk.
        //Protected: csak származtatott osztályból érhetjük el, OOP Öröklődés.
        //Private: csakis az osztályon belül érhető el, a származtatott osztályok nem láthatják és nem is módosíthatják.
        //Internal:
        //Protected internal:

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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kutya k = new Kutya();
            k.jatek(); //Játék...
            k.jatek(); //Játék...
            k.jatek(); //A kutya éhes, nem tudsz játszani vele!
        }
    }
}
