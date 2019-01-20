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
            csonkoltLogOp(); //A csonkolt logikai operátorok.
            haromOp(); //A háromoperandusú operátor C#-ban.
            MessageBox.Show(AbszolutErtek(-10).ToString());
            bitMuveletek();
        }

        void bitMuveletek()
        {
            //Bitenkénti és-&, vagy-|, kizáró vagy-^, valamint tagadás-~
            byte a = 13, b = 7; //1101 és 0111
            MessageBox.Show("a: " + Convert.ToString(a, 2)); //1101 
            MessageBox.Show("b: " + Convert.ToString(b, 2)); //0111 
            int c = a & b;
            MessageBox.Show("c: " + Convert.ToString(c, 2)); //0101

            MessageBox.Show("a: " + Convert.ToString(a, 2)); //1101 = 13dec 
            int d = a >> 2; MessageBox.Show("d: " + Convert.ToString(d, 2)); //0011 = 3dec

        }

        static int AbszolutErtek(int szám)
        {
            return szám > 0 ? szám : szám * -1;
        }

        void haromOp()
        {
            int szám = 10;
            
            //if-else: 
            if (szám < 0)
                MessageBox.Show("Negatív");
            else
                MessageBox.Show("Pozitív");

            //Hármas operátor:
            MessageBox.Show(szám < 0 ? "Negatív" : "Pozitív");
        }

        void csonkoltLogOp()
        {
            bool i = true;

            if (i == (false || true))
            {
                MessageBox.Show("OK");
            }
            else
            {
                //rögtön az else ágra ugrik 
            }
            if (i == (false | true)) //ugyanarra valók, mint a rendes társaik, csak a csonkolt operátorok a teljes feltételt kielemzik
            {
                MessageBox.Show("OK");
            }
            else
            {
                //hiába lesz már false, a második operandust is vizsgálja 
            }
        }
    }
}
