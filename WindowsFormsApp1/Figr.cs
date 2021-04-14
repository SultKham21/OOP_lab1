﻿using System.Drawing;
using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class Figure : ICloneable
    {

        public Graphics DrawPanel;
        protected Point startPoint;
        protected Point endPoint = new Point(-1, -1);
        public Pen DrPen;
        public Color FillColor;
        public bool EndOfCurrentFigure = false;



        public Figure(int x0, int y0, Graphics gr, Pen pen, Color Fc)
        {
            startPoint = new Point(x0, y0);
            DrawPanel = gr;
            DrPen = pen;
            FillColor = Fc;
        }

        object ICloneable.Clone()
        {
            return Clone();

        }

        public virtual Figure Clone()
        {
            return null;

        }

        public virtual bool OnePointBack() { return false; }
        public virtual void Redraw()
        { }

        public virtual Point StartPoint
        {
            get
            {
                return startPoint;
            }
            set
            {
                startPoint = value;

            }
        }

        public virtual Point PreDrawEndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                EndPoint = value;

            }

        }

        public virtual Point EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                endPoint = value;

            }

        }

    }
}
