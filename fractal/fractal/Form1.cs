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
            long times = 0;
            Sierpinski_triangle sierpinski_Triangle = new Sierpinski_triangle(g);
            while (times < +10000)
            {
                sierpinski_Triangle.Draw();
            }
        }
    }
    public class Sierpinski_triangle
    {
        Graphics g;
        Pen Pen = new Pen(Color.Black, 0.1f);
        public int[] a, b, c;
        public double[] temppoint;
        public double a_Between_temppoint, b_Between_temppoint,c_Between_temppoint;
        public Sierpinski_triangle(Graphics graphics)
        {
            a = new int[] { 400,2 };
            b = new int[] { 2,500 };
            c = new int[] { 798, 500 };
            temppoint = new double[] { 12.33f, 123.2f };
            g = graphics;
            g.DrawLine(Pen, a[0], a[1], a[0] + 0.1f, a[1] + 0.1f);
            g.DrawLine(Pen, b[0], b[1], b[0] + 0.1f, b[1] + 0.1f);
            g.DrawLine(Pen, c[0], c[1], c[0] + 0.1f, c[1] + 0.1f);
        }
        public void Draw()
        {
            a_Between_temppoint = Get_Distance(a, temppoint);
            b_Between_temppoint = Get_Distance(b, temppoint);
            c_Between_temppoint = Get_Distance(c, temppoint);
            if (a_Between_temppoint >= b_Between_temppoint)
            {
                if (a_Between_temppoint >= c_Between_temppoint)
                {
                    temppoint = Getmidpoint(a, temppoint);
                }
            }
            else if(b_Between_temppoint >= c_Between_temppoint)
            {
                temppoint = Getmidpoint(b, temppoint);
            }
            else
            {
                temppoint = Getmidpoint(c, temppoint);
            }
            float x = (float)temppoint[0];
            g.DrawLine(Pen, (float)temppoint[0], (float)temppoint[1], (float)(temppoint[0] + 0.1), (float)(temppoint[1] + 0.1));
        }
        protected double Get_Distance(int[]a , double[] temp)
        {
            return Math.Sqrt(Math.Pow(a[0]-b[0],2)+Math.Pow(a[1]-b[1],2));
        }
        protected double[] Getmidpoint(int[] a, double[] temp)
        {
            return new double[] {(a[0]+temp[0])/2, (a[1] + temp[1]) / 2 };
        }
    }
} 
