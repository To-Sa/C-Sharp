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
            int x = 10;

            string v = (x == 1) ? "ONE" : "NOT 1";        // ?:
            MessageBox.Show(v);

            if (x == 2) { MessageBox.Show("TWO"); }       // IF-ELSE
            else { MessageBox.Show("NOT 2"); }

            if (x == 1) { MessageBox.Show("1"); }
            else if (x == 2) { MessageBox.Show("2"); }
            else { MessageBox.Show("NOT 1, NOT 2"); }       //ELSE-IF

            switch (x)
            {
                case 10: { MessageBox.Show("10"); } break;
                default: { MessageBox.Show("NOT 10"); } break;
            }

            Animal anim = Animal.Dog;

            switch (anim)
            {
                case Animal.Tiger: { MessageBox.Show("TIGER"); } break;
                default: { MessageBox.Show("NOP"); } break;         //SWITCH CASE
            }
        }
    }
}
