using System;
using System.Collections.Generic;

namespace Codility.Respectable
{
    class CountSemiprimes
    {
        private int[] primes;
        private int[] GetPrimes(int n)
        {
            bool[] numbers = new bool[n + 1];
            var primes = new List<int>();

            for (int i = 2; i < (int)Math.Sqrt(n)+1; i++)
                if (!numbers[i])
                    for (int j = i * i; j <= n; j += i)
                        numbers[j] = true;
            for (int i = 2; i < n; i++)
                if (!numbers[i])
                    primes.Add(i);

            return primes.ToArray();
        }

        private int[] GetSemiprimes(int n)
        {
            int[] semiprimes = new int[n + 1];
            int product;
            for (int i = 0; i < n && primes[i] <= Math.Sqrt(n) + 1; i++)
                for (int j = i; j < n; j++)
                {
                    product = primes[i] * primes[j];
                    if (product > n)
                        break;
                    semiprimes[product]++;
                }

            for (int i = 1; i <= n; i++)
                semiprimes[i] += semiprimes[i - 1];
            return semiprimes;
        } 

        public int[] solution(int N, int[] P, int[] Q)
        {
            primes = GetPrimes(N);
            int m = P.Length;

            int qMax = int.MinValue;
            for (int i = 0; i < m; i++)
                qMax = Math.Max(qMax, Q[i]);
            int[] semiprimes = GetSemiprimes(qMax);

            int[] result = new int[m];
            for (int i = 0; i < m; i++)
                result[i] = semiprimes[Q[i]] - semiprimes[P[i]-1];

            return result;
        }
    }
}
