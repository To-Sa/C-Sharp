using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //METHODS: Clear, Contains, ToArray...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashSet<int> HS = new HashSet<int>() { 17, 10, 20, 43 }; //contains unique element

            listBox1.Items.Add("BEFORE: " + HS.Count);

            HS.Add(17);
            HS.Add(99);

            listBox1.Items.Add("AFTER: " + HS.Count);

            Random r = new Random(); HashSet<int> lotto = new HashSet<int>();
            while (lotto.Count < 5)
            {
                lotto.Add(r.Next(0, 91));
            }

            listBox1.Items.Add("NUMBERS:");

            foreach (int item in lotto)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HashSet<int> union = new HashSet<int>() { 10, 32 }; //UNION
            HashSet<int> another = new HashSet<int>() { 20, 32 };
            union.UnionWith(another);

            foreach (int item in union)
            {
                listBox1.Items.Add(item);
            }

            listBox1.Items.Add("-----");

            HashSet<int> def2 = new HashSet<int>() { 10, 32 }; //!union
            HashSet<int> defT2 = new HashSet<int>() { 20, 32 };
            def2.SymmetricExceptWith(defT2);

            foreach (int item in def2)
            {
                listBox1.Items.Add(item);
            }

            listBox1.Items.Add("-----");

            HashSet<int> def3 = new HashSet<int>() { 10, 32, 120, 20 }; //def3 = def3 \ defT3
            HashSet<int> defT3 = new HashSet<int>() { 20, 32, 20 };
            def3.ExceptWith(defT3);

            foreach (int item in def3)
            {
                listBox1.Items.Add(item);
            }

            listBox1.Items.Add("-----");

            HashSet<int> def4 = new HashSet<int>() { 10, 32 }; // Intersect with
            HashSet<int> defT4 = new HashSet<int>() { 20, 32 };
            def4.IntersectWith(defT4);

            foreach (int item in def4)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
