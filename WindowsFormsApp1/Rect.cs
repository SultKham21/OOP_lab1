using System.Drawing;

namespace WindowsFormsApp1
{
    public class Rectangle : Figure
    {

        public Rectangle(int x0, int y0, Graphics gr, Pen pen, Color Fc) : base(x0, y0, gr, pen, Fc) { }
        public override string NameF
        {
            get
            {
                return " Прямоугольник";
            }
        }

        public override Point EndPoint
        {
            get => base.StartPoint;
            set
            {
                endPoint = value;
                Point MainPicture = new Point(startPoint.X, startPoint.Y);

                FindLeftTopPoint(ref startPoint, ref endPoint);

                var brush = new SolidBrush(FillColor);
                DrawPanel.DrawRectangle(DrPen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                DrawPanel.FillRectangle(brush, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                startPoint = MainPicture;
            }
        }

    }
}
