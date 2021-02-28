using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Point2D
    {
        private int _x;
        private int _y;

        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public override string ToString()
        {
            return $"Point => ({X},{Y});";
        }
        public Point2D()
        {
            X = default;
            Y = default;
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        // ================RELOADING OPERATORS

        //UNARY ONES

        public static Point2D operator ++(Point2D point2D)
        {
            point2D.X++;
            point2D.Y++;
            return point2D;
        }
        public static Point2D operator --(Point2D point2D)
        {
            point2D.X--;
            point2D.Y--;
            return point2D;
        }
        public static Point2D operator -(Point2D point2D)
        {
            return new Point2D(-point2D.X, -point2D.Y);
        }
        public static bool operator !(Point2D point2D)
        {
            if (point2D) { return true; } else { return false; }
        }

        //BINARY ONES

        //plus
        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }
        public static Point2D operator +(Point2D point, int num)
        {
            return new Point2D(point.X + num, point.Y + num);
        }
        public static Point2D operator +(int num, Point2D point)
        {
            return new Point2D(point.X + num, point.Y + num);
        }
        //minus
        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }
        public static Point2D operator -(Point2D point, int num)
        {
            return new Point2D(point.X - num, point.Y - num);
        }
        public static Point2D operator -(int num, Point2D point)
        {
            return new Point2D(point.X - num, point.Y - num);
        }
        //multiply
        public static Point2D operator *(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X * point2.X, point1.Y * point2.Y);
        }
        public static Point2D operator *(Point2D point, int num)
        {
            return new Point2D(point.X * num, point.Y * num);
        }
        public static Point2D operator *(int num, Point2D point)
        {
            return new Point2D(point.X * num, point.Y * num);
        }
        //divide
        public static Point2D operator /(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X / point2.X, point1.Y / point2.Y);
        }
        public static Point2D operator /(Point2D point, int num)
        {
            return new Point2D(point.X / num, point.Y / num);
        }
        public static Point2D operator /(int num, Point2D point)
        {
            return new Point2D(point.X / num, point.Y / num);
        }

        //equals
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator ==(Point2D point1, Point2D point2)
        {
            return point1.Equals(point2);
        }
        public static bool operator !=(Point2D point1, Point2D point2)
        {
            return !(point1 == point2);
        }
        //true-false
        public static bool operator true(Point2D point2D)
        {
            return (point2D.X > 0 && point2D.Y > 0) ? true : false;
        }
        public static bool operator false(Point2D point2D)
        {
            return (point2D.X < 0 && point2D.Y < 0) ? false : true;
        }

        //indexing
    }
}
