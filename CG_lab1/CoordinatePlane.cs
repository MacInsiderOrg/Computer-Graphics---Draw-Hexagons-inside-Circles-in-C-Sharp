using System;
using System.Drawing;
using System.Windows.Forms;

namespace CG_lab1
{
    /**
     * Class CoordinatePlane
     * Contain width, height, coordinatePlane, minValue, coefficient,
     * graphics, cellCount, cellSize variables and 10 methods:
     *   +CoordinatePlane()
     *   +CoordinatePlane(width, height)
     *   +DrawCoordinatePlane()
     *   -createGrid()
     *   -createAxises()
     *   -createPointers()
     *   -createNumbers()
     *   +getImage()
     *   -drawHexagon(hexagon)
     *   +drawCircle(circle)
     */
    public class CoordinatePlane
    {
        /* Count of pixels in width and height */
        private int width;
        private int height;

        // Current coordinate plane
        private Bitmap coordinatePlane;

        // Save a current minimum value in coordinate plane
        private float minValue = -20;

        // Save a coefficient, which multiply to x, y and radius
        private float coefficient = 1;

        // Create a graphics
        private Graphics graphics;

        // Count of cells in coordinate plane
        private int cellCount = 50;

        // Cell size
        private int cellSize;

        // Create black color
        Pen blackColor = new Pen(Color.Black);

        /* Default constructor without parameters */
        public CoordinatePlane()
        {
            coordinatePlane = new Bitmap(500, 500);
            graphics = Graphics.FromImage(coordinatePlane);
        }

        /* Contructor with parameters*/
        public CoordinatePlane(int width, int height)
        {
            this.width = width;
            this.height = height;
            cellSize = width / cellCount;

            coordinatePlane = new Bitmap(width, height);
            graphics = Graphics.FromImage(coordinatePlane);
        }

        /* Create Coordinate Plane */
        public void DrawCoordinatePlane()
        {
            graphics.Clear(Color.White);

            // Create a grid
            CreateGrid();

            // Create axises
            CreateAxises();

            // Create pointers
            CreatePointers();

            // Create numbers;
            CreateNumbers();
        }

        /* Create a grid */
        private void CreateGrid()
        {
            int position = 0;
            while (position <= cellCount)
            {
                Pen gainsboroColor = new Pen(Color.Gainsboro, 1);

                // Set cell position
                int cellCoordinate = cellSize * position;

                graphics.DrawLine(
                    gainsboroColor,
                    cellCoordinate, 0,
                    cellCoordinate, height
                );

                graphics.DrawLine(
                    gainsboroColor,
                    0, cellCoordinate,
                    width, cellCoordinate
                );

                position++;
            }
        }

        /* Create axises */
        private void CreateAxises()
        {
            graphics.DrawLine(
                blackColor,
                10, cellSize * 5,
                width - 10, cellSize * 5
            );

            graphics.DrawLine(
                blackColor,
                width - cellSize * 5, 10,
                width - cellSize * 5, height - 10
            );

            /* Create axis names */
            graphics.DrawString("X", Control.DefaultFont, blackColor.Brush, cellSize * 2 - 5, cellSize * 3);
            graphics.DrawString("Y", Control.DefaultFont, blackColor.Brush, width - cellSize * 4, height - cellSize * 2 - 5);

            // Create zero
            graphics.DrawString("0", Control.DefaultFont, blackColor.Brush, width - cellSize * 4, cellSize * 5 + 5);
        }

        /* Create pointers */
        private void CreatePointers()
        {
            Point[] pointsX = new Point[]
            {
                new Point(10, cellSize * 5),
                new Point(20, cellSize * 5 + 4),
                new Point(20, cellSize * 5 - 4)
            };

            Point[] pointsY = new Point[]
            {
                new Point(width - cellSize * 5, height - 10),
                new Point(width - cellSize * 5 - 4, height - 20),
                new Point(width - cellSize * 5 + 4, height - 20)
            };

            graphics.DrawPolygon(blackColor, pointsX);
            graphics.DrawPolygon(blackColor, pointsY);

            graphics.FillPolygon(blackColor.Brush, pointsX);
            graphics.FillPolygon(blackColor.Brush, pointsY);
        }

        /* Create numbers */
        private void CreateNumbers()
        {
            int stepValue = Convert.ToInt32(minValue / 10);
            int number = stepValue;
            int position = 4;

            while (number >= minValue)
            {
                graphics.DrawString(number.ToString(), Control.DefaultFont, blackColor.Brush, width - cellSize * (6 + position) - 3, cellSize * 6);
                graphics.DrawString(number.ToString(), Control.DefaultFont, blackColor.Brush, width - cellSize * 4, cellSize * (4 + position) + 3);
                graphics.DrawLine(blackColor, width - cellSize * (5 + position), cellSize * 5 + 5, width - cellSize * (5 + position), cellSize * 4 + 5);
                graphics.DrawLine(blackColor, width - cellSize * 6 + 5, cellSize * (5 + position), width - cellSize * 5 + 5, cellSize * (5 + position));

                position += 4;
                number += stepValue;
            }
        }

        public void SetCoefficient(float coeff)
        {
            coefficient = coeff;
        }

        public float GetMinValue()
        {
            return minValue;
        }

        public void SetMinValue(float value)
        {
            minValue = value;
        }

        public Bitmap GetImage()
        {
            return coordinatePlane;
        }

        /* Draw circle in coordinate plane */
        public void DrawCircle(Circle circle)
        {
            float x = width - cellSize * 5 + circle.GetX() * coefficient - circle.GetRadius() * coefficient; // ok
            float y = cellSize * 5 - circle.GetY() * coefficient - circle.GetRadius() * coefficient; // ok

            RectangleF rect = new RectangleF(x, y, circle.GetRadius() * 2 * coefficient, circle.GetRadius() * 2 * coefficient);

            graphics.DrawEllipse(new Pen(circle.GetBorderColor()), rect);
            graphics.FillEllipse(new Pen(circle.GetBgColor()).Brush, rect);

            DrawHexagon(circle.GetHexagon());
        }

        /* Draw hexagon inside circle in coordinate plane */
        private void DrawHexagon(Hexagon hexagon)
        {
            PointF[] hexagonPoints = new PointF[6];
                        
            for (int i = 0; i < hexagon.GetPoints().Count; i++)
            {
                hexagonPoints[i].X = width - cellSize * 5 + hexagon.GetPoints()[i].X * coefficient;
                hexagonPoints[i].Y = cellSize * 5 - hexagon.GetPoints()[i].Y * coefficient;
            }

            graphics.DrawPolygon(new Pen(hexagon.GetBgColor()), hexagonPoints);
            graphics.FillPolygon(new Pen(hexagon.GetBgColor()).Brush, hexagonPoints);
        }
    }
}
