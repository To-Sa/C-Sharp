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
            //Saját alprogramunk túlterhelése.

            //Lehet azonos név alatt különböző szignatúrájú (más típus, valamint a visszaadott érték) függvényeket, eljárásokat létrehozni.
            int a = metA(10, 45); 
            double b = metA(11.5, 13.2);
            double c = metA(13.1, 10);

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            listBox1.Items.Add(c);
        }

        static int metA(int num1, int num2)
        {
            return num1 + num2;
        }

        static double metA(double num1, double num2)
        {
            return num1 + num2;
        }

        static double metA(double num1, int num2)
        {
            return num1 + num2;
        }

        static double metA(int num1, double num2)
        {
            return num1 + num2;
        }
    }
}
