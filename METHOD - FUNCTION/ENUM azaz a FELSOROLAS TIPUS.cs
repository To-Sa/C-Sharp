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

        enum Animal { Cat, Dog, Tiger, Wolf }; //ENUM - A felsorolás típus.

        //A felsorolás egy adatszerkezet, amelyben egy meghatározott konstans értékek adategységét jelenti. 
        //Enum típust csak eljárásokon kívül, de még osztályon belül szabad csak deklarálni.

        enum ByteAnimal : byte { Cat = 1, Dog = 3, Tiger, Wolf };

        private void button1_Click(object sender, EventArgs e)
        {
            Animal b = Animal.Dog;
            MessageBox.Show(b.ToString());

            MessageBox.Show(((Animal)0).ToString());

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

            regiSuly();
        }

        enum regiMertekek : uint { Kar = 200, Lab = 100, Beka = 10, Veka = 5 }

        void regiSuly()
        {
            regiMertekek[] rsmT = (regiMertekek[])Enum.GetValues(typeof(regiMertekek));
            //Az Enum.GetValues egy tömböt ad vissza, melyben a megadott felsorolás elemei szerepelnek.

            foreach (regiMertekek item in rsmT)
            {
                MessageBox.Show(item.ToString());
            }

            string[] rsmTstr = Enum.GetNames(typeof(regiMertekek));
            //GetNames is ugyan ez az elven működik csak string tömböt ad vissza.

            foreach (string item in rsmTstr)
            {
                MessageBox.Show(item);
            }

            string str = Enum.GetName(typeof(regiMertekek), 100);
            MessageBox.Show(str);
        }
    }
}
