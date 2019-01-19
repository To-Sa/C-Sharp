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

        //Methods: Count, Remove (only key), Clear...

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dicT = new Dictionary<string, string>() { { "1", "red" }, { "2", "blue" } };

            foreach (KeyValuePair<string, string> item in dicT) //KeyValuePair
            {
                listBox1.Items.Add(item.Key + "-" + item.Value);
            }

            dicT.Add("5", "green"); //.Add

            foreach (KeyValuePair<string, string> item in dicT)
            {
                listBox1.Items.Add(item.Key + "-" + item.Value); //.Key      .Value
            }

            if (dicT.ContainsKey("5")) //.ContainsKey or .ContainsValue
            {
                listBox1.Items.Add("OK");
            }
            else
            {
                listBox1.Items.Add("NOK");
            }
        }
    }
}
