using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            gr.DrawLine(p, 30, 100, 100, 100);
            gr.DrawLine(p, 65, 50, 30, 100);
            gr.DrawLine(p, 65, 50, 100, 100);
            gr.DrawLine(p, 65, 50, 100, 100);
            gr.FillRectangle(Brushes.DarkRed, 30, 100, 70, 140);
            gr.DrawRectangle(p, 30, 100, 70, 140);
            gr.FillEllipse(Brushes.Red, 160, 50, 75, 75);
            gr.FillEllipse(Brushes.Red, 160, 165, 75, 75);
            gr.DrawEllipse(p, 160, 50, 75, 75);
            gr.DrawEllipse(p, 160, 165, 75, 75);
            gr.DrawLine(p, 160, 85, 160, 200);
            gr.DrawLine(p, 235, 85, 235, 200);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Text = e.Location.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.Clear(BackColor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            gr.FillRectangle(Brushes.White,310,50,180,90);
            gr.FillRectangle(Brushes.Green, 310, 80, 180, 60);
            gr.FillRectangle(Brushes.Red, 310, 110, 180, 30);
            gr.DrawLine(p, 310, 50, 310, 240);
            gr.DrawRectangle(p, 310, 50, 180, 90);
            gr.DrawLine(p, 310, 80, 490, 80);
            gr.DrawLine(p, 310, 110, 490, 110);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            gr.FillRectangle(Brushes.Blue, 550, 50, 180, 90);
            gr.FillRectangle(Brushes.Yellow, 550, 80, 180, 30);
            gr.FillRectangle(Brushes.Yellow, 594, 50, 30, 90);
            gr.DrawRectangle(p, 550, 50, 180, 90);
            gr.DrawLine(p, 550, 50, 550, 240);
        }
    }
}
