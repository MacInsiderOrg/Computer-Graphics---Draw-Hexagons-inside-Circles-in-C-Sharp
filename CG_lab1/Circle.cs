using System;
using System.Drawing;
using System.Collections.Generic;

namespace CG_lab1
{
    /**
     * Class Circle
     * Contain x, y, radius, borderColor, bgColor, hexagon variables
     * and 8 methods:
     *   + Circle(x, y, radius)
     *   + Circle(x, y, radius, borderColor, bgColor, hexagonColor)
     *   + getX()
     *   + getY()
     *   + getRadius()
     *   + getBorderColor()
     *   + getBgColor()
     *   + getHexagon()
     */
    public class Circle
    {
        private float x;
        private float y;
        private float radius;
        private Color borderColor;
        private Color bgColor;

        private Hexagon hexagon;

        public Circle(float x, float y, float radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public Circle(float x, float y, float radius, Color borderColor, Color bgColor, Color hexagonColor)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.borderColor = borderColor;
            this.bgColor = bgColor;

            hexagon = new Hexagon(new PointF(x, y), 6, radius, hexagonColor);
        }

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }

        public float GetRadius()
        {
            return radius;
        }

        public Color GetBorderColor()
        {
            return borderColor;
        }

        public Color GetBgColor()
        {
            return bgColor;
        }

        public Hexagon GetHexagon()
        {
            return hexagon;
        }
    }

    /**
     * Class Hexagon
     * Contain center, vertexes, radius, bgColor and points[] variables
     * and 4 methods:
     *   + Hexagon(center, vertexes, radius, bgColor)
     *   + getPoints()
     *   + getCenter()
     *   + getRadius()
     *   + getBgColor()
     */
    public class Hexagon
    {
        private PointF center = new PointF(0, 0);
        private int vertexes = 6;
        private float radius = 0;
        private Color bgColor;
        private List<PointF> points = new List<PointF>();
        
        public Hexagon(PointF center, int vertexes, float radius, Color bgColor)
        {
            this.center = center;
            this.vertexes = vertexes;
            this.radius = radius;
            this.bgColor = bgColor;

            var angle = Math.PI * 2 / vertexes;

            for (int i = 0; i < vertexes; i++)
            {
                points.Add(
                    PointF.Add(
                        center,
                        new SizeF(
                            Convert.ToSingle(Math.Sin(i * angle) * radius),
                            Convert.ToSingle(Math.Cos(i * angle) * radius)
                        )
                    )
                );
            }

            /* points = Enumerable.Range(0, vertexes)
                .Select(i => PointF.Add(center, new SizeF(Convert.ToSingle(Math.Sin(i * angle) * radius), Convert.ToSingle(Math.Cos(i * angle) * radius))))
                .ToArray(); */
        }        

        public List<PointF> GetPoints()
        {
            return points;
        }

        public PointF GetCenter()
        {
            return center;
        }

        public float GetRadius()
        {
            return radius;
        }

        public Color GetBgColor()
        {
            return bgColor;
        }
    }
}
