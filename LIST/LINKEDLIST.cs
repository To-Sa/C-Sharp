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
            LinkedList<string> linkList = new LinkedList<string>();     // DATA SWAP is FASTER

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

            LinkedListNode<string> nPoint = linkList.First; // or .Last
            MessageBox.Show(nPoint.ToString());

            linkList.AddAfter(nPoint, "2nd");     //insert a new node 

            LinkedListNode<string> searchNode = linkList.Find("SUGAR");   //get the node what the value uses and stores in LinkedList
            MessageBox.Show(searchNode.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedList<string> linkList = new LinkedList<string>();     //LinkedListNode
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
