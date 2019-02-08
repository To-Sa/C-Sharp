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

        //Egy-egy metódusra vagy metódusokra mutatnak, egy delegate megadásával olyan mutatót hozunk létre, amely a megadott metódusra hivatkozik.
        delegate void VoidDelegate(); //a delegate létrehozása 
        static void Metódus()
        {
            MessageBox.Show("A metódus lefutott!");
        }

        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            MessageBox.Show("Üdvözzöllek: " + név);
        }
        static void Üzenet(string név)
        {
            MessageBox.Show("ID: " + név);
        }

        class Class
        {
            public delegate void Meghívás(int i);
            static public void Ciklus(Meghívás mh)
            {
                for (int i = 0; i < 10; i++)
                {
                    mh(i);
                }
            }
        }
        
       static void Kiír(int i)
       {
            MessageBox.Show(i.ToString());
       }
 
       private void button1_Click(object sender, EventArgs e)
       {
            VoidDelegate vd = new VoidDelegate(Metódus); //létrejön a hivatkozás 
            vd();//meghívja a megadott metódust, amire hivatkozik

            /*A delegate-hez a + és a += operátorral újjabb metódusokat adhatunk hozzá és a – valamint 
            a -= operátorral kitudjuk törölni az adott metódusra vonatkozó hivatkozást,
            a meghívás esetén az összes hivatkozott metódus lefut:*/
            Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üzenet);
            string név = "Tom";
            b(név);

            //Egy delegate példánya hasonlóan működik, mint egy változó, átadhatjuk eljárásoknak, függvényeknek, amelyek majd meghívják a benne lévő metódusokat.
            Class.Meghívás mhKiír = new Class.Meghívás(Kiír);
            Class.Ciklus(mhKiír);
       }      
    }
}
