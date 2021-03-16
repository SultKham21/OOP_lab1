using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LinkedList<Type> UsedTypes = new LinkedList<Type>();

        Graphics gr;
        Pen pen;
        Figure CurrentFigure;
        Bitmap MainPicture= new Bitmap(1000,1000), TemporaryImage = new Bitmap(1000, 1000);
        int FpsCounter = 0;
        
        

        public Form1()
        {

            InitializeComponent();

            if (!LoadModules())
            {
                MessageBox.Show("Error. No figures");
                Application.Exit();
            }
            
            

            comboBox1.SelectedIndex = 0;
            gr = Graphics.FromImage(MainPicture);


            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Width = PenWidthBar.Value;
            CurrentFigure = (Figure)Activator.CreateInstance(UsedTypes.ElementAt<Type>(comboBox1.SelectedIndex), -1, -1, gr, pen, FillColorPanel.BackColor);

            pictureBox1.Image = MainPicture;


        }

        private bool LoadModules()
        {
            bool FiguresExist = false;

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                
                foreach (PropertyInfo pi in types[i].GetProperties())
                {
                    
                    if ( (pi.Name == "NameF") && (pi.CanRead) && (!pi.CanWrite) )
                    {
                        if (!types[i].IsAbstract)
                        {
                            UsedTypes.AddLast(types[i]);
                            Figure tmp = (Figure)Activator.CreateInstance(types[i], -1, -1, null, null, FillColorPanel.BackColor);
                            //comboBox1.Items.Add(comboBox1.Items.);
                            FiguresExist = true;
                        }                                                                 
                        continue;
                    }
                }
                
            }
            return FiguresExist;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            CurrentFigure.StartPoint = new Point(e.X, e.Y);
           

        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

           
            try
            {

                gr = Graphics.FromImage(MainPicture);
                CurrentFigure.DrawPanel = gr;


                if (e.Button == MouseButtons.Right)
                    CurrentFigure.EndOfCurrentFigure = true;
                CurrentFigure.EndPoint = new Point(e.X, e.Y);

                CurrentFigure.StartPoint = new Point(-2,-2);
                pictureBox1.Image = MainPicture;
                
            }
            catch { }
        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            TopsLabel.Visible = false;
           
            CurrentFigure = (Figure)Activator.CreateInstance(UsedTypes.ElementAt<Type>(comboBox1.SelectedIndex), -1, -1, gr, pen, FillColorPanel.BackColor);


            foreach (PropertyInfo pi in UsedTypes.ElementAt<Type>(comboBox1.SelectedIndex).GetProperties())
            {
                if ((pi.Name == "TopAmount"))
                {
                    numericUpDown1.Visible = true;
                    TopsLabel.Visible = true;
                    break;
                }

            }


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
