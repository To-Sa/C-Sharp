using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
            LinkedList<string> linkList = new LinkedList<string>();

            /*A lassúság kiküszöbölésére hozták létre a láncolt listákat(LinkedList), 
              amit akkor érdemes használni, ha adatstruktúránkban sok mozgatás van, fontos megjegyezni, 
              hogy a láncolt lista nem biztos, hogy gyorsabb, mint a sima lista, amíg a listánkban csak a végére szúrunk be.*/

            linkList.AddLast("WAIT");

            foreach (string item in linkList)
            {
                listBox1.Items.Add(item);
            }

            linkList.AddLast("SUGAR");
            linkList.AddLast("WAIT");

            foreach (string item in linkList)
            {
                listBox1.Items.Add(item);
            }

            linkList.AddLast("WAIT");
            linkList.AddLast("SUGAR");
            linkList.AddFirst("CAR");

            foreach (string item in linkList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkedList<string> linkList = new LinkedList<string>(); //get the FIRST or LAST node
            linkList.AddLast("WAIT");
            linkList.AddLast("SUGAR");
            linkList.AddFirst("CAR");

            LinkedListNode<string> nPoint = linkList.First; //or .Last
            MessageBox.Show(nPoint.ToString());

            linkList.AddAfter(nPoint, "2nd"); //insert a new node 

            LinkedListNode<string> searchNode = linkList.Find("SUGAR"); //get the node what the value uses and stores in LinkedList
            MessageBox.Show(searchNode.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedList<string> linkList = new LinkedList<string>(); //LinkedListNode
            linkList.AddLast("WAIT");
            linkList.AddLast("SUGAR");
            linkList.AddFirst("CAR");
            LinkedListNode<string> nPoint = linkList.First;

            while (nPoint != null)
            {
                listBox1.Items.Add(nPoint.Value);      //get the value of node
                nPoint = nPoint.Next;                 //jump to next node
            }                                        //.Previous -jump to previous node
        }
    }
}
