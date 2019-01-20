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
            //A C#3.0 verziótól bevezettek egy általános típust a VAR-t, ahol a fordítóra bízzuk az adott változó típusának meghatározását.
            var szám = 2; //int 
            var str = "string"; //string 
            //var valami; //hibás, hiszen nincs kezdőértéke 
            //str = 3; //hibás 
            szám = 17; //jó

            /*  VAR-t használhatjuk akár struktúrák, listák, osztályok példányosítására is, 
                de így nem látszik rögtön az adott változó szerepe, továbbá fordításkor időt pazarlunk vele*/

            //A GOTO nem része a struktúrált programozásnak, mert átláthatatlanná teszi a kódot, ha lehet NE HASZNÁLJUK!
            int i = 0;
            vissza: MessageBox.Show("Az i értéke: " + (++i));
            if (i < 10)
                goto vissza;
        }
    }
}
