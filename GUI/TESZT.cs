using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESZT
{
    class Class1
    {
        public void Update(Form1 Sender)
        {
            Button kilepes = new Button();
            kilepes.Text = "EXIT";
            kilepes.Location = new Point(150, 150);
            kilepes.Click += new EventHandler(btnKilepes_Click);
            //kilepes.Click += btnKilepes_Click;
            Sender.Controls.Add(kilepes);
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXIT GOMB");
        }
    }  
}





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESZT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLetrehoz_Click(object sender, EventArgs e)
        {
            Class1 _class = new Class1();
            _class.Update(this);
        }
    }
}
