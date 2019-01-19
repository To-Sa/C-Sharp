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
            //METHOD
            upM(); //Eljárások: nincs visszatérési értéke, ezért void (üres) típusú

            listBox1.Items.Add("");

            //FUNCTION
            int i = load(); //Függvények: van visszatérési értéke, a visszaadott értéktől függ, a return utasítással adjuk meg a visszaadott értéket.
            listBox1.Items.Add(i.ToString());
        }

        void upM()
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        static int load()
        {
            return 4324 + 8652; //A return utasítás után lévő parancsok nem futnak már le.
        }
    }
}
