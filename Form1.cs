using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialProject2
{
    public partial class Form1 : Form
    {
        int x1, x2, x3, y2, y1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Red);
            pen.Width = 6;
            g.DrawRectangle(pen, 600, 50, 100, 100);
            g.DrawEllipse(pen, 525, 150, 250, 250);
            g.DrawEllipse(pen, 450, 400, 400, 400);
            g.DrawEllipse(pen, 400, 800, 500, 500);
            g.DrawLine(pen, 400, 150, 800, 100);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            Invalidate();
        }
    }
}

