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
            int[] intTomb = new int[] {1,2,3,4,5};
            int atlag = Atlag(out int atlagom, intTomb);
            MessageBox.Show(atlag.ToString());
        }
    
        //Egy paraméterlistán csak egy paramétertömb lehet, s ennek kell az utolsónak lennie.
        private static int Atlag(out int atlagom, params int[] szamok)
        {
            int atlag = 0;
            foreach (var item in szamok)
            {
                atlag = atlag + item;
            }
            return atlagom = atlag/szamok.Length;
        } 
    }
}
        
