using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolylineApp
{
    public partial class Form1 : Form
    {
        private Point[] points;
        private Color polylineColor = Color.Black;
        private int selectedPointIndex = -1;
        private bool isDragging = false;
        private Point dragOffset;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int numberOfPoints = (int)numericUpDownPoints.Value;
            points = GenerateRandomPoints(numberOfPoints, panelDraw.Width, panelDraw.Height);
            panelDraw.Invalidate();
        }

        private Point[] GenerateRandomPoints(int numberOfPoints, int maxWidth, int maxHeight)
        {
            Random rand = new Random();
            Point[] points = new Point[numberOfPoints];
            for (int i = 0; i < numberOfPoints; i++)
            {
                points[i] = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
            }
            return points;
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (points != null && points.Length > 1)
            {
                using (Pen pen = new Pen(polylineColor, 2))
                {
                    e.Graphics.DrawLines(pen, points);
                }

                // Отрисовка точек для визуального представления
                foreach (var point in points)
                {
                    e.Graphics.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
                }
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    polylineColor = colorDialog.Color;
                    panelDraw.Invalidate();
                }
            }
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (points != null)
            {
                for (int i = 0; i < points.Length; i++)
                {
                    if (IsPointSelected(points[i], e.Location))
                    {
                        selectedPointIndex = i;
                        isDragging = true;
                        dragOffset = new Point(points[i].X - e.X, points[i].Y - e.Y);
                        break;
                    }
                }
            }
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedPointIndex != -1)
            {
                points[selectedPointIndex] = new Point(e.X + dragOffset.X, e.Y + dragOffset.Y);
                panelDraw.Invalidate();
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedPointIndex = -1;
        }

        private bool IsPointSelected(Point point, Point mouseLocation)
        {
            const int selectionRadius = 5;
            return Math.Abs(point.X - mouseLocation.X) <= selectionRadius && Math.Abs(point.Y - mouseLocation.Y) <= selectionRadius;
        }
    }
}
