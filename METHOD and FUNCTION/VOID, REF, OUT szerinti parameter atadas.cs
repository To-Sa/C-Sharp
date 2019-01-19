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
            hiMessage();     //Print-out: HELLO
            hiMessage("HI");     //Print-out: HI 

            int a = 10, b = 20; //Érték szerinti paraméterátadás: 
            int c = fv(a, b);   //Ha nem adunk meg semmilyen kulcsszót, akkor ilyen módon adódnak át a változók (kivéve tömbök, objektumok...).
            listBox1.Items.Add("A: " + a.ToString() + " B: " + b.ToString() + " C: " + c.ToString()); // 10, 20, 60

            int aa = 10, bb = 20; //Cím (Referencia) szerinti paraméterátadás: A ref kulcsszóval érhető el.
            int cc = calc(ref aa, ref bb); //Az alprogramon belül végzett változtatások érvénybe lépnek az átadott változóban is!
            listBox1.Items.Add("A: " + aa.ToString() + " B: " + bb.ToString() + " C: " + cc.ToString());  // 20, 40, 60

            bool par; //Kimeneti változó: Az out kulcsszóval érhető el.
            Paros(3, out par); //Az (out) átadott paraméternek kezdetben nincs értéke, a függvényünk ad neki.
            MessageBox.Show(par.ToString());
        }

        static void hiMessage(string s = "HELLO")
        {
            MessageBox.Show(s);
        }

        static int fv(int egy, int ket)
        {
            egy = egy * 2;
            ket = ket * 2;

            return egy + ket;
        }

        static int calc(ref int egy, ref int ket)
        {
            egy = egy * 2;
            ket = ket * 2;

            return egy + ket;
        }

        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0)
            {
                log = true;
            }
            else
            {
                log = false;
            }
        }
    }
}
