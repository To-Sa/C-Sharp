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
            //PARSE
            string i = "19"; int x = int.Parse(i) + 1; MessageBox.Show(x.ToString()); //csak string-ből képes valamilyen egyéb változóba konvertálni

            //CONVERT
            int j = 14; MessageBox.Show(Convert.ToString(++j));

            //CAST
            int szam1 = 7, szam2 = 5;
            double eredmeny = szam1 / szam2; MessageBox.Show(Convert.ToString(eredmeny)); //ha kiíratjuk 0-t kapunk
            double eredmenyCast = (double)szam1 / szam2; MessageBox.Show(Convert.ToString(eredmenyCast));
        }
    }
}
