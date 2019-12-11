using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Respectable
{
    class CountNonDivisible
    {
        private int[] divisors;
        public int[] solution(int[] A)
        {
            int n = A.Length;
            var values = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
                if (values.ContainsKey(A[i]))
                    values[A[i]]++;
                else
                    values.Add(A[i], 1);

            return default;
        }

        public int[] GetDivisors(int n)
        {
            int[] numbers = new int[n + 1];
            for (int i = 2; i < (int)Math.Sqrt(n) + 1; i++)
                if (numbers[i] == 0)
                    for (int j = i * i; j <= n; j += i)
                        if (numbers[j] == 0)
                            numbers[j] = i;
            return numbers;
        }

        public int Factorize(int n)
        {
            int count = 0;
            for (int i = n; i > 0; i++)
            {
            }
            return default;
        }
    }
}
