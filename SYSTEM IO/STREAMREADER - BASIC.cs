using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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

            StreamReader sr = new StreamReader(path + @"\important.txt");
            List<string> nevsor = new List<string>(); while (!sr.EndOfStream) { nevsor.Add(sr.ReadLine()); }
            foreach (string item in nevsor) { Console.WriteLine(item); }
            sr.Close(); //!!!
            sr.Dispose(); //!!!

            using (StreamReader reader = new StreamReader(path + @"\important.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    MessageBox.Show(line);
                }
            }

            //KIVÉTELKEZELÉS
            try
            {
                StreamReader stRead = new StreamReader(@"C:\Users\XYZ\Desktop\adat.txt");
                List<string> adatok = new List<string>();

                while (!stRead.EndOfStream)
                {
                    adatok.Add(stRead.ReadLine());
                }

                foreach (string item in adatok)
                {
                    MessageBox.Show(item);
                }
                stRead.Close();
                stRead.Dispose();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nem található a fájl!");
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba keletkezett a fájl olvasása közben!");
            }
        }
    }
}
