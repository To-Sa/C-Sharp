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
            bool okNok = ConvBinDec("v", out int vmi);
            MessageBox.Show(okNok.ToString());
        }
        /// <summary> This method converts the binary number to decimal. </summary>  
        /// <param name="bin">Binary Number</param> /// <param name="dec">The modified number will be here IF the conversion is successful </param> 
        /// <returns>IF the conversion is success than the value of return is TRUE against FALSE</returns> 
        /// <exception cref="System.OverflowException"/> 
        static bool ConvBinDec(string bin, out int dec)
        {
            dec = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    dec += (int)Math.Pow(2, bin.Length - 1 - i);
                }
                else if (bin[i] != '0') dec = 0;
                return false;
            }
            return true;
        }
    }
}
