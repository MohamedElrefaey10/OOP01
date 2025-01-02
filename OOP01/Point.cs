using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal struct Point
    {
        public double X;
        public double Y;

        public Point(double A, double B)
        {
            X = A;
            Y = B;
        }

        public static double xxx(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }

    
}
