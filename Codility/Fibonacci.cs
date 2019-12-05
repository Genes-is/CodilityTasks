using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    class Fibonacci
    {
        public static int Recursion(int n)
        {

            if (n == 0 || n == 1)
                return 1;
            else
                return Recursion(n - 2) + Recursion(n - 1);
        }

        public static int Loop(int n)
        {
            int a = 1,
                b = 1,
                sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }
    }
}
