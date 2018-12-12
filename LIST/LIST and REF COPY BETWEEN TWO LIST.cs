using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
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
            List<int> oldList = new List<int>() { 20, 31, 10 };
            List<int> newList = oldList;         // REF COPY: impact each other

            foreach (int item in oldList)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("-----");
            foreach (int item in newList)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("-----");

            newList.Add(40);                        // REF COPY

            foreach (int item in oldList)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("-----");
            foreach (int item in newList)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("-----");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<List<int>> listA = new List<List<int>>() { new List<int>(), new List<int>() };   // list IN list
            listA.Add(new List<int>());
            listA[0].Add(14);
            listA[1].Add(56);
            listA[2].Add(23);

            for (int i = 0; i < listA.Count; i++)       //FOR
            {
                for (int j = 0; j < listA[i].Count; j++)
                {
                    listBox1.Items.Add(listA[i][j]);
                }
            }
            listBox1.Items.Add("-----");
            foreach (List<int> insideL in listA)     //FOREACH
            {
                foreach (int elem in insideL)
                {
                    listBox1.Items.Add(elem);
                }
            }
        }
    }
}
                                            //LIST METHODS
                                            //lista.Insert(index, elem)
                                            //lista.Remove(del. elem)
                                            //lista.RemoveAt(index)
                                            //lista.Clear
                                            //lista.AddRange(tömb) ---copy the content of array to end of list
                                            //lista.InsertRange(index, elem)
                                            //lista.Sort()
                                            //lista.Contains(cont.) ---return with TRUE or FALSE value
                                            //listaIndexOf(searched elem) ---return with index, if do not find it than the value will be -1
                                            //lista.LastIndexof(searched elem) ---at the end of the file starts to search
                                            //lista.ToArray() ---int[] tmb = lista.ToArray();
