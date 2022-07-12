using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraktal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void drawF(int x, int y, int len, double rotation, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            double x1, y1;
            x1 = x + len * Math.Sin(rotation * Math.PI * 2 / 270.0);
            y1 = y + len * Math.Cos(rotation * Math.PI * 2 / 270.0);
            g.DrawLine(new Pen(Color.CadetBlue, len / 8), x,panel1.Height- y, (int)x1, panel1.Height-(int)y1);
            if (len > 1)
            {
                drawF((int)x1, (int)y1, (int)(len / 1.35), (int)rotation + 30, e);
                drawF((int)x1, (int)y1, (int)(len / 1.35), (int)rotation - 30, e);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawF(panel1.Width / 2, 0, 150, 0, e);
            drawF(panel1.Width / 2, 0, 100, 0, e);
            drawF(panel1.Width / 2, 0, 50, 0, e);
        }
    }
}