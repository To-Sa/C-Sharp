using System;
using System.Windows.Forms;
using System.IO;

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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter writer = new StreamWriter(path + @"\important.txt"))
            {
                writer.Write("Word ");
                writer.WriteLine("word 2");
                writer.WriteLine("Line");
            }

            using (StreamWriter writer = new StreamWriter(path + @"\important.txt", true)) //APPEND
            {
                writer.WriteLine("Line 2");
            }

            StreamWriter sw_gyumolcsok = new StreamWriter(path + @"\import.txt");
            sw_gyumolcsok.WriteLine("alma"); //írás 
            sw_gyumolcsok.Flush(); //puffer kiürítése 
            sw_gyumolcsok.Close(); //adatfolyam lezárása

            try
            {
                StreamWriter sw_elérésiúttal = new StreamWriter(@"D:\Saját\Fááálok\szöveg.txt");
                sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány");
                sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Nem található egy mappa, valószínűleg rossz elérési utat adott meg!");
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba lépett fel a fájl írása közben!");
            }
        }
    }
}
