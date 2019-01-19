using System;
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
            //Escape karakterek 

            /*  \a alert hang
                \b törlés, backspace
                \n új sorba ugrik a kurzor
                \r vissza ugrik a kurzor
                \t tabulátor vízszintesen
                \v tabulátor függőlegesen
                \’ ’ karaktert illeszt be
                \’’ ’’ karaktert illeszt be
                \\ \ karaktert illeszt be        */
            MessageBox.Show("EGY\n \b KETTO \t HAROM \' NEGY \"  OT \\\\");
        }
    }
}
