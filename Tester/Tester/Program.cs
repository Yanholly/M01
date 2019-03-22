using System;
using System.Drawing;
//using ArrayHelper;
//using RectangleHelper;

namespace Tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Demonstrates BubbleSort class from ArrayHelper. 
            int[] arr = {3, 15, 87, 2, 6, 1, 34};

           BubbleSort.Sort(arr, false); // For ASC reverse:false. For DESC reverse:true.
            Console.Write("Sorted array: ");
            foreach (var t in arr)
                Console.Write($"{t} ");
            Console.WriteLine();

            // Demonstrates SumCounter class from ArrayHelper.
            int[,] mas = {{1, -2, 3}, {-4, 5, -6}, {7, -8, 9}, {-10, 11, -12}};

            Console.WriteLine($"Sum of all positive elements: {SumCounter.Count(mas)}");

            // Demonstrates RectangleSolver class from RectangleHelper.
            var a = new Point(3, 3);
            var b = new Point(9, 3);
            var c = new Point(9, 8);

            Console.WriteLine($"Perimeter of the rectangle: {RectangleSolver.FindPerimeter(a, b, c)}");
            Console.WriteLine($"Square of the rectangle: {RectangleSolver.FindSquare(a, b, c)}");

            Console.ReadKey();
        }
    }
}