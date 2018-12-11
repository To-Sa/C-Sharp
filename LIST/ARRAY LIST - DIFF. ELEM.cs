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

        //Methods:  AddRange, Capacity, Clear, Count, Contains, IndexOf, Insert, InsertRange, Sort, listA[0].GetType()...

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList aList = new ArrayList(); //using System.Collections;

            aList.Add("string");     //STRING +INT +...  DIFFERENT ELEM
            aList.Add(7);
            aList.Add('c');

            foreach (var item in aList)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
