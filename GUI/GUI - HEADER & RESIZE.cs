using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;			//UI
            DoubleBuffered = true;									//UI
            this.SetStyle(ControlStyles.ResizeRedraw, true);		//UI
        }

        // UI
        private const int gripSize = 15;      // Grip size
        private const int headerSize = 30;   // Header height

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle headerAndGrip = new Rectangle(this.ClientSize.Width - gripSize, this.ClientSize.Height - gripSize, gripSize, gripSize);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, headerAndGrip);

            headerAndGrip = new Rectangle(0, 0, this.ClientSize.Width, headerSize);
            Color myColor = ColorTranslator.FromHtml("#343740");
            SolidBrush myBrush = new SolidBrush(myColor);
            e.Graphics.FillRectangle(myBrush, headerAndGrip);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {                                               // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < headerSize)
                {
                    m.Result = (IntPtr)2;       // HTCAPTION
                    return;
                }

                if (pos.X >= this.ClientSize.Width - gripSize && pos.Y >= this.ClientSize.Height - gripSize)
                {
                    m.Result = (IntPtr)17;      // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

     
    }
}
