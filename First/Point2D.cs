using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Point2D
        {
            private int _x, _y;
            private Colors _color;

            public int X
            {
                get { return _x; }
                set { _x = value; }
            }
            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }
            public Colors Color
            {
                get { return _color; }
                set { _color = value; }
            }
            public override string ToString()
            {
                return $"X: {X}; Y = {Y}";
            }
            public override bool Equals(object obj)
            {
                return this.ToString() == obj.ToString();
            }
            public Point2D()
            {
                X = 0; Y = 0; Color = Colors.RED;
            }
            public Point2D(int x, int y, Colors color)
            {
                X = x;
                Y = y;
                Color = color;
            }
            public static Point2D operator ++(Point2D p)
            {
                p.X++;
                p.Y++;
                return p;
            }
            public static Point2D operator --(Point2D p)
            {
                p.X--;
                p.Y--;
                return p;
            }
            public static Point2D operator -(Point2D p)
            {
                return new Point2D { X = -p.X, Y = -p.Y };
            }
            public static Point2D operator +(Point2D left, Point2D right) =>
                new Point2D { X = left.X + right.X, Y = left.Y + right.Y, Color = right.Color };
            public static Point2D operator -(Point2D left, Point2D right) =>
               new Point2D { X = left.X - right.X, Y = left.Y - right.Y, Color = left.Color };

            public static Point2D operator *(Point2D left, Point2D right) =>
               new Point2D { X = left.X * right.X, Y = left.Y * right.Y, Color = left.Color };

            public static Point2D operator *(Point2D left, int right) =>
               new Point2D { X = left.X * right, Y = left.Y * right, Color = left.Color };
            public static Point2D operator *(int left, Point2D right) =>
               new Point2D { X = left * right.X, Y = left * right.Y, Color = right.Color };
            public static Point2D operator /(Point2D left, Point2D right)
            {
                if (right.X == 0 || right.Y == 0)
                    throw new DivideByZeroException();
                return new Point2D { X = left.X / right.X, Y = left.Y / right.Y, Color = left.Color };
            }
            public static bool operator ==(Point2D a, Point2D b) => a.ToString() == b.ToString();
            public static bool operator !=(Point2D a, Point2D b) => !(a == b);
            public static bool operator true(Point2D a) => a.X != 0 && a.Y != 0;
            public static bool operator false(Point2D a) => a.X == 0 && a.Y == 0;

        }
    }
}
