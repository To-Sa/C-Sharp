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

        enum Animal { Cat, Dog, Tiger, Wolf };      // ENUM

        enum ByteAnimal : byte { Cat = 1, Dog = 3, Tiger, Wolf };

        private void button1_Click(object sender, EventArgs e)
        {
            Animal b = Animal.Dog;

            if (b == Animal.Cat || Convert.ToString(b) == "Dog")
            {
                MessageBox.Show("OK");
            }
            else { MessageBox.Show("NOK"); }

            int x = (int)b;
            MessageBox.Show(Convert.ToString(x));

            /*string s1 = "Cat";
			Animal a1;
			Enum.TryParse(s1, true, out a1);*/
        }
    }
}
