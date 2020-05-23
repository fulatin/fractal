using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clickaction(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();

            Sierpinski_triangle sierpinski_Triangle = new Sierpinski_triangle(g);
            sierpinski_Triangle.Draw();
        }
    }
    public class Sierpinski_triangle
    {
        Graphics g;
        Pen Pen = new Pen(Color.Black, 0.1f);
        public int[] a, b, c ,temppoint;
        public Sierpinski_triangle(Graphics graphics)
        {
            a = new int[] { 400,2 };
            b = new int[] { 2,500 };
            c = new int[] { 798, 500 };
            g = graphics;
            g.DrawLine(Pen, a[0], a[1], a[0] + 0.1f, a[1] + 0.1f);
            g.DrawLine(Pen, b[0], b[1], b[0] + 0.1f, b[1] + 0.1f);
            g.DrawLine(Pen, c[0], c[1], c[0] + 0.1f, c[1] + 0.1f);
        }
        public void Draw()
        {
            
        }

    }
} 
