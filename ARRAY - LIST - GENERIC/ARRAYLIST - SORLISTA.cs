using System;
using System.Windows.Forms;
using System.Collections;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Methods:  AddRange, Capacity, Clear, Count, Contains, IndexOf, Insert, InsertRange, Sort, listA[0].GetType()...

        //Referencia típus, mivel minden féle típust feltudunk bele venni, ezért nem kell megadnunk semmilyen típusra utaló jelzőt.

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList aList = new ArrayList(); //using System.Collections;

            aList.Add("string"); //STRING +INT +...  DIFFERENT ELEM
            aList.Add(7);
            aList.Add('c');

            foreach (var item in aList)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
