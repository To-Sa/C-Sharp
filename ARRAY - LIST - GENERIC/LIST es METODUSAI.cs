using System;
using System.Windows.Forms;
using System.Collections.Generic;

//lista.Insert(hova, mit)
//lista.Remove(mit)
//lista.RemoveAt(index)
//lista.Clear()
//lista.AddRange(tmb) - Képes egy megfelelő típusú kollekció(tömbök(1dimeziós), halmazok, stb.) összes tartalmát átmásolni az adott lista végére.
//lista.InsertRange(index, elem)
//lista.Sort()
//lista.Contains(elem) ---TRUE or FALSE
//listaIndexOf(elem) --- return with index, false: -1
//lista.LastIndexof(elem) ---search from the end
//lista.ToArray() ---int[] tmb = lista.ToArray();

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
            List<string> listA = new List<string>() { "1", "2", "3" };

            int capacity = listA.Capacity;
            int meret = listA.Count;

            listA.Add("AAAA");
            listA.Add("BBBB");
            listA.Add("CCCC");
            listA.Add("DDDD");
            listA.Add("EEEE");
            listA.Add("FFFF");

            int newCap = listA.Capacity;
            int newSiz = listA.Count;

            MessageBox.Show(capacity.ToString() + "\n" + meret.ToString() + "\n" + newCap.ToString() + "\n" + newSiz.ToString());

            for (int i = 0; i < listA.Count; i++)
            {
                listBox1.Items.Add(listA[i]);
            }
        }
    }
}
