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
            List<int> oldList = new List<int>() { 20, 31, 10 };
            List<int> newList = oldList; // REFERENCIA szerinti másolás: hatással vannak egymásra

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

            newList.Add(40); // REFERENCIA szerinti másolás

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
            List<List<int>> listA = new List<List<int>>() { new List<int>(), new List<int>() };   // összetett lista: lista a listában
            listA.Add(new List<int>());
            listA[0].Add(14);
            listA[1].Add(56);
            listA[2].Add(23);

            for (int i = 0; i < listA.Count; i++) //FOR
            {
                for (int j = 0; j < listA[i].Count; j++)
                {
                    listBox1.Items.Add(listA[i][j]);
                }
            }
            listBox1.Items.Add("-----");
            foreach (List<int> insideL in listA) //FOREACH
            {
                foreach (int elem in insideL)
                {
                    listBox1.Items.Add(elem);
                }
            }
        }
    }
}
