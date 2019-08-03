using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        // fibonacci series 10 hops
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34

        static void Main(string[] args)
        {
            int hops = 10;
            FibonacciSeries.PrintFibonacciSeries(hops);

            Console.ReadKey();
        }
    }

    class FibonacciSeries
    {
        public static void PrintFibonacciSeries(int n)
        {
            int f1 = 0, f2 = 1, f3 = 0;

            Console.WriteLine(" *** Fibonacci Series *** ");
            Console.Write(f1 + "," + f2 + ",");

            for (int i = 2; i < n; i++)
            {
                f3 = f1 + f2; // sum of two preceding numbers

                if (i == n - 1)
                    Console.Write(f3);
                else
                    Console.Write(f3 + ",");

                // updating the numbers in the series
                f1 = f2;
                f2 = f3;
            }

        }

    }
}
