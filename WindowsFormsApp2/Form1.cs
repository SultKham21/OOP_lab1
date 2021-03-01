using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
          //  DrawTreangle();


        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);

            Pen pen = new Pen(Color.Green);
            graph.DrawLine(pen, 30, 50, 30, 200);

            pen = new Pen(Color.Red);
            graph.DrawLine(pen, 150, 50, 70, 120);
            graph.DrawLine(pen, 70, 120, 150, 120);
            graph.DrawLine(pen, 150, 120, 70, 190);

            pen = new Pen(Color.Aqua);
            PointF point1 = new PointF(250.0F, 50.0F);
            PointF point2 = new PointF(360.0F, 50.0F);
            PointF point3 = new PointF(400.0F, 120.0F);
            PointF point4 = new PointF(360.0F, 190.0F);
            PointF point5 = new PointF(250.0F, 190.0F);
            PointF point6 = new PointF(210.0F, 120.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
             };
            graph.DrawPolygon(pen, curvePoints);

            pen = new Pen(Color.Orange);
            Rectangle rect1 = new Rectangle(450, 50, 200, 200);
            Color customColor1 = Color.FromArgb(50, Color.Red);
            SolidBrush shadowBrush1 = new SolidBrush(customColor1);
            graph.DrawEllipse(pen, rect1);
            graph.FillEllipse(shadowBrush1, rect1);

            Rectangle rect2 = new Rectangle(700, 50, 100, 300);
            Pen penRect = new Pen(Color.Gold);
            Color customColor2 = Color.FromArgb(50, Color.Blue);
            SolidBrush shadowBrush2 = new SolidBrush(customColor2);
            graph.DrawRectangle(penRect,rect2);
            graph.FillRectangle(shadowBrush2, rect2);

            
            pictureBox1.Image = bmp;

        }
        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
