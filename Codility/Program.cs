using System;
using System.Diagnostics;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Respectable.GenomicRangeQuery();

            int[] result = t.solution("CAGCCTA",
                new int[] { 2, 5, 0 },
                new int[] { 4, 5, 6 });
            for (int i = 0; i < result.Length; i++)
                Console.Write($"{result[i]}, ");
        }

        static private void TestMario()
        {
            int o = 49;
            var t = new Respectable.MarioTrip();
            int[,] array =
            {
                { 0,1,1,1,1 },
                { 2,2,2,3,1 },
                { 2,4,5,0,100 },
                { 3,2,1,1,0 }
            };
            //{
            //    {1,1,1,1,1,o,1,1,1,1,1,o,o,o },
            //    {o,o,o,o,1,o,1,o,o,o,1,o,o,o },
            //    {1,1,1,o,1,o,1,1,1,o,1,o,o,o },
            //    {1,o,1,o,1,o,o,o,1,o,1,o,o,o },
            //    {1,o,1,1,1,o,1,1,1,o,1,o,o,o },
            //    {1,o,o,o,o,o,1,o,o,o,1,o,o,o },
            //    {1,1,1,1,1,1,1,o,o,o,1,1,1,1 }
            //};
            var result = t.Painfull(array);
            int N = result.GetLength(0);
            int M = result.GetLength(1);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write(result[i, j] ? 1 : 0);
                Console.Write("\n");
            }
        }

        static private void TestArray()
        {
            var t = new OddOccurrencesInArray();
            int n = 1_000_000;
            int[] array = new int[n+1];
            for (int i = n; i >= 0; i--)
            {
                array[i] = (i) / 2;
            }

            var sw = new Stopwatch();
            sw.Start();
            int result = t.solution(array);
            sw.Stop();
            Console.WriteLine($"Sort \n\tresult: {result} \ttime: {sw.Elapsed}");
            sw.Reset();

            sw.Start();
            result = t.solution2(array);
            sw.Stop();
            Console.WriteLine($"Dictionary \n\tresult: {result} \ttime: {sw.Elapsed}");
        }

        static private void TestFibonacci()
        {
            int n = 1_000_000;
            var sw = new Stopwatch();
            sw.Start();
            int result = Fibonacci.Recursion(n);
            sw.Stop();
            Console.WriteLine($"Recursion \n\tresult: {result} \ttime: {sw.Elapsed}");
            sw.Reset();

            sw.Start();
            int result2 = Fibonacci.Loop(n);
            sw.Stop();
            Console.WriteLine($"Loop \n\tresult: {result2} \ttime: {sw.Elapsed}");
        }

        static private void Test1()
        {
            var rnd = new Random();
            var test = new MinPositiveValue();
            const int lenght = 100_000_000;
            int[] arr1 = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr1[i] = rnd.Next();
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var res = test.solution(arr1);
            stopwatch.Stop();
            Console.WriteLine(res);
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void PrintMatrix(int arraySize, int[,] matrix)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int j = 0; j < arraySize; j++)
                Console.Write("\t" + "j=" + (char)(j+65));
            Console.ResetColor();
            Console.Write("\n");

            for (int i = 0; i < arraySize; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("i=" + (i+1) + "\t");
                Console.ResetColor();
                for (int j = 0; j < arraySize; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
}
