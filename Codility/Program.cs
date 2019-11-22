using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new DwarfsRafting();
            int result = t.solution(4, "1D", "");
            Console.WriteLine(result);
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
