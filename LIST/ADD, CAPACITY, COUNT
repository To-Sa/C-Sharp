using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                                //lista.Insert(location index, elem)
                                //lista.Remove(del)
                                //lista.RemoveAt(index)
                                //lista.Clear
                                //lista.AddRange(tmb) ---Copy the array content to the end of list.
                                //lista.InsertRange(location index, elem)
                                //lista.Sort()
                                //lista.Contains(cont.) ---TRUE or FALSE
                                //listaIndexOf(elem) --- return with index, false: -1
                                //lista.LastIndexof(elem) ---search from the end
                                //lista.ToArray() ---int[] tmb = lista.ToArray();
