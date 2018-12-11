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
            var tmb = new int[] { 2, 6, 0, 0, 2, 2, 9, 2, 3, 1, 4, 4, 8, 8, 8, 0 };

            var stat = algorithms.statistics(tmb);

            foreach (var elem in stat)
            {
               listBox1.Items.Add(elem.Key + "; " + elem.Value);
            }
        }

        class algorithms
        {
            public static Dictionary<int, int> statistics(int[] blocks)
            {
                var stat = new Dictionary<int, int>();
                foreach (var elem in blocks)
                {
                    if (stat.ContainsKey(elem)) stat[elem] += 1;
                    else stat.Add(elem, 1);
                }
                return stat;
            }
        }
    }
}
