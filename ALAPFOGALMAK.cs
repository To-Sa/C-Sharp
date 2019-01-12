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

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("HELLO")  >>> SZINTAKTIKAI HIBA:  hiányzik a sorvégi ";".
            //                                SZEMANTIKAI HIBA:   Pl.: Prímszámokat kiíró program esetén kiírja az 1-et.
            //  VÁLTOZÓ:            A változó a memóriában lefoglalt bitek azonosítója és tartalma.
            //  DEKLARÁLÁS:         Egy változónévvel ellátott típust hozunk létre.
            //  DEFINIÁLÁS:         Változónévvel ellátott típusnak értéket is adunk.
            //  TÍPUSOK:            A C# erősen típusos nyelv. 
                                    /*A típus határozza meg, hogy egy változó milyen értékeket tartalmazhat illetve mekkora helyet foglal a memóriában.*/
            //  PREFIX:             ++a; Először növeli az a változó értékét majd a többi részt.
            //  POSTFIX:            a++; A postfix alaknál csak utólag adódik hozzá az a változóhoz az +1.
            //  TÚLCSORDULÁS:       Akkor beszélünk túlcsordulásról, ha az adott érték már nem fér el a változónak fenntartott területen.
            //  PRECEDENCIA:        Egy olyan rangsor, amelyet a nyelv követ és olyan sorrendben értelmezi a műveleteket.
            //  RÖVIDÍTETT VERZIÓ:  int szam1 = 7;
            //                      szam1 *= -5; MessageBox.Show(Convert.ToString(szam1));
            //  VÉGTELEN CIKLUS:    Pl.: WHILE(true) > Az adott ciklusból a program nem tud kilépni, így folyton ismételgeti önmagát.
        }
    }
}
