using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task #1
            Console.WriteLine("L: 1, W: 2, A: " + RectangleArea(1, 2));
            Console.WriteLine("L: 2, W: 4, A: " + RectangleArea(2, 4));
            Console.WriteLine("\n");

            //Task #2
            TimeTable(5);
            Console.WriteLine("\n");
            TimeTable(10);
            Console.WriteLine("\n");


            //Task #3
            int[] set = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Max: " + Max(set));
            Console.WriteLine("Min: " + Min(set));
            Console.WriteLine("Average: " + Average(set));

            //Leave window open
            Console.ReadLine();

        }
        static int RectangleArea(int length, int width)
        {
            return length * width;
        }
        static void TimeTable(int n)
        {
            //Columns
            for (int c = 1; c <= n; c++)
            {
                //Rows
                for (int r = 1; r <= n; r++)
                {
                    Console.Write(c * r + " ");
                }
                Console.WriteLine("\n");
            }
        }
        static int Max(int[] values)
        {
            int max = values[0];
            foreach (int value in values)
            {
                if (max < value)
                {
                    max = value;
                }
            }
            return max;
        }
        static int Min(int[] values)
        {
            int min = values[0];
            foreach (int value in values)
            {
                if (min > value)
                {
                    min = value;
                }
            }
            return min;
        }
        static double Average(int[] values)
        {
            return values.Average();
        }
    }
}
