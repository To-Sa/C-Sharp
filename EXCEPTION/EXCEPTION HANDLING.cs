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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            try
            {
                a = int.Parse("3.5");
                MessageBox.Show("OK?");
            }
            catch (FormatException)     // catch the all error
            {
                MessageBox.Show("ERROR - I CAN NOT CONVERT IT!");
            }
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;

            a = int.Parse("3.5");

            MessageBox.Show("OK?");

            MessageBox.Show("ERROR - I CAN NOT CONVERT IT!");

            MessageBox.Show(a.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;

            try
            {
                a = int.Parse("");
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR - I CAN NOT CONVERT IT!");
            }
            catch (OverflowException ofe)
            {
                MessageBox.Show(ofe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            MessageBox.Show(a.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool err = true;
            do
            {
                string s = "";
                try
                {
                    s = "";
                    if (s.Length == 0) throw new Exception("NO TEXT");
                    err = false; //it will run if do not have Exc.
                }
                catch (Exception NEVE)
                {
                    MessageBox.Show(NEVE.Message);
                }
            }
            while (err);

            //it is going to run, all time
            MessageBox.Show("END");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 10;
                int b = 0;
                MessageBox.Show((a / b).ToString());
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("ERROR AGAIN no use: 0");
            }
            finally
            { //ez az ág mindenképpen lefut! 
                MessageBox.Show("END AGAIN");
            }
        }
    }
}
