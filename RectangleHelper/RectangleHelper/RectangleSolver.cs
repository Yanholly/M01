using System;
using System.Drawing;

namespace RectangleHelper
{
    public static class RectangleSolver
    {
        private static double Ab;
        private static double Bc;
        private static double Ca;


        private static bool CheckPoints(Point a, Point b, Point c)
        {
            return a != b && b != c && c != a;
        }

        public static double FindPerimeter(Point a, Point b, Point c)
        {
            if (!CheckPoints(a, b, c))
                return -1;
            Ab = Math.Sqrt(Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.X - a.X, 2));
            Bc = Math.Sqrt(Math.Pow(c.Y - b.Y, 2) + Math.Pow(c.X - b.X, 2));
            Ca = Math.Sqrt(Math.Pow(a.Y - c.Y, 2) + Math.Pow(a.X - c.X, 2));

            return Ab + Bc + Ca;
        }

        public static double FindSquare(Point a, Point b, Point c)
        {
            if (!CheckPoints(a, b, c))
                return -1;
            var perimeter = FindPerimeter(a, b, c)/2;
            var square = Math.Sqrt(perimeter * (perimeter - Ab) * (perimeter - Bc) * (perimeter - Ca));
            return square;
        }
    }
}