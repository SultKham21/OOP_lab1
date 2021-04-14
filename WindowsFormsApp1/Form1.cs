using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LinkedList<Type> UsedTypes = new LinkedList<Type>();
        LinkedList<shapeintfc> Creators = new LinkedList<shapeintfc>();
        ustack FiguresBackBuffer = new ustack(), FiguresFrontBuffer = null;

        Graphics gr;
        Pen pen;
        Figure CurrentFigure;
        Bitmap MainPicture = new Bitmap(1000, 1000), TemporaryImage = new Bitmap(1000, 1000);
        int FpsCounter = 0;



        public Form1()
        {
            InitializeComponent();

            if (!LoadModules())
            {
                MessageBox.Show("Error. No figures modules found.");
                Application.Exit();
            }



            comboBox1.SelectedIndex = 0;
            gr = Graphics.FromImage(MainPicture);


            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Width = PenWidthBar.Value;

            shapeintfc CurrentCreator = Creators.ElementAt<shapeintfc>(comboBox1.SelectedIndex);
            CurrentFigure = CurrentCreator.Create(-1, -1, gr, pen, FillColorPanel.BackColor);

            pictureBox1.Image = MainPicture;
        }

        private bool LoadModules()
        {
            bool FiguresExist = false;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type[] types = assembly.GetTypes();
                int k = 0;
                for (int i = 0; i < types.Length; i++)
                {
                    if (types[i].GetInterface(typeof(shapeintfc).FullName) != null)
                    {
                        Creators.AddLast((shapeintfc)Activator.CreateInstance(types[i]));


                        comboBox1.Items.Add(Creators.ElementAt<shapeintfc>(k).Name);
                        FiguresExist = true;
                        k++;
                    }
                }
            }
            catch
            {
                FiguresExist = false;
            }
            return FiguresExist;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            CurrentFigure.StartPoint = new Point(e.X, e.Y);
            PreDrawTimer.Enabled = true;



            FpsCounter = 0;
            timer1.Enabled = true;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CurrentFigure.StartPoint.X < 0)
                return;

            if (!PreDrawTimer.Enabled)
            {
                FpsCounter++;

                TemporaryImage.Dispose();

                TemporaryImage = (Bitmap)MainPicture.Clone();

                pictureBox1.Image = TemporaryImage;
                gr = Graphics.FromImage(TemporaryImage);
                CurrentFigure.DrawPanel = gr;


                CurrentFigure.PreDrawEndPoint = e.Location;
                gr.Dispose();
                PreDrawTimer.Enabled = true;



            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            PreDrawTimer.Enabled = false;

            try
            {

                gr = Graphics.FromImage(MainPicture);
                CurrentFigure.DrawPanel = gr;


                if (e.Button == MouseButtons.Right)
                    CurrentFigure.EndOfCurrentFigure = true;




                CurrentFigure.EndPoint = new Point(e.X, e.Y);

                if (FiguresBackBuffer.Count < 1)
                {
                    FiguresBackBuffer.Push(CurrentFigure);
                    undo.Enabled = true;
                }
                else
                {
                    if (FiguresBackBuffer.LastEnd())
                    {
                        FiguresBackBuffer.Push(CurrentFigure);
                    }
                    else
                    {
                        FiguresBackBuffer.Pop();
                        FiguresBackBuffer.Push(CurrentFigure);
                    }

                }




                CurrentFigure.StartPoint = new Point(-2, -2);
                pictureBox1.Image = MainPicture;

                if (FiguresFrontBuffer != null)
                {
                    FiguresFrontBuffer = null;
                    redo.Enabled = false;
                }

            }
            catch { }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            TopsLabel.Visible = false;
            shapeintfc CurrentCreator = Creators.ElementAt<shapeintfc>(comboBox1.SelectedIndex);

            CurrentFigure = CurrentCreator.Create(-1, -1, gr, pen, FillColorPanel.BackColor);

            if (CurrentCreator.TopsNeeded)
            {
                numericUpDown1.Visible = true;
                TopsLabel.Visible = true;
            }
            if (FiguresBackBuffer.Count > 0)
                FiguresBackBuffer.ElementAt(0).EndOfCurrentFigure = true;
        }

        private void PenWidthBar_Scroll(object sender, EventArgs e)
        {
            pen.Width = PenWidthBar.Value;
            label3.Text = String.Format("Толщина линий: {0}", PenWidthBar.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            (CurrentFigure as RigthPolygon).TopAmount = (int)numericUpDown1.Value;
        }

        private void PenColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PenColorPanel.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FillColorPanel.BackColor = colorDialog1.Color;
                CurrentFigure.FillColor = colorDialog1.Color;


            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PenColorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void undo_Click(object sender, EventArgs e)
        {
            int N = FiguresBackBuffer.Count;
            if (N <= 0)
                return;
            if (FiguresFrontBuffer == null)
                FiguresFrontBuffer = new ustack();
            Figure Last = FiguresBackBuffer.ElementAt(0);
            Last.EndOfCurrentFigure = true;
            FiguresFrontBuffer.Push(Last);
            FiguresBackBuffer.Pop();
            redo.Enabled = true;
            gr = Graphics.FromImage(MainPicture);
            gr.Clear(pictureBox1.BackColor);
            FiguresBackBuffer.DrawStack(gr);
            pictureBox1.Image = MainPicture;
            if (FiguresBackBuffer.Count <= 0)
                undo.Enabled = false;
            shapeintfc CurrentCreator = Creators.ElementAt<shapeintfc>(comboBox1.SelectedIndex);
            CurrentFigure = CurrentCreator.Create(-1, -1, gr, pen, FillColorPanel.BackColor);
        }

        private void redo_Click(object sender, EventArgs e)
        {
            Figure tmp = FiguresFrontBuffer.Pop();
            gr = Graphics.FromImage(MainPicture);
            tmp.DrawPanel = gr;
            tmp.Redraw();
            FiguresBackBuffer.Push(tmp);
            undo.Enabled = true;
            pictureBox1.Image = MainPicture;
            gr.Dispose();
            if (FiguresFrontBuffer.Count == 0)
            {
                redo.Enabled = false;
            }
        }

        private void PreDrawTimer_Tick(object sender, EventArgs e)
        {
            PreDrawTimer.Enabled = false;
        }

        public class UndoStack
        {
            private int StackSize = 10;
            private Stack<Figure> LastFig;
            private int n = 0;
            public Graphics gr;

            public UndoStack(int size)
            {
                StackSize = size;
                LastFig = new Stack<Figure>();
            }
            public UndoStack()
            {
                LastFig = new Stack<Figure>();
            }

        }

    }

}
