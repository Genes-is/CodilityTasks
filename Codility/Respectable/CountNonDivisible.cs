using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Respectable
{
    class CountNonDivisible
    {
        //100%
        public int[] SolutionWithDictionary(int[] A)
        {
            int n = A.Length;
            int max = int.MinValue;
            var values = new Dictionary<int, int>();
            foreach (var i in A) 
            { 
                if (!values.ContainsKey(i))
                {
                    values.Add(i, 1);
                    max = Math.Max(max, i);
                }
                else
                    values[i]++;
            }
                
            int[] divisors = new int[max + 1];
            foreach (var i in values)
                for (int j = i.Key; j <= max; j += i.Key)
                    divisors[j] += i.Value;

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = n - divisors[A[i]];

            return result;
        }

        //88%
        public int[] Solution(int[] A)
        {
            int n = A.Length;
            int max = int.MinValue;
            foreach (var i in A)
                max = Math.Max(max, i);

            int[] divisors = new int[max + 1];
            for (int i = 0; i < n; i++)
                for (int j = A[i]; j <= max; j += A[i])
                    divisors[j]++;

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = n - divisors[A[i]];

            return result;
        }

        //private int[] primeFactor;

        //public int[] solution(int[] A)
        //{
        //    int n = A.Length;
        //    var values = new Dictionary<int, int>();

        //    for (int i = 0; i < n; i++)
        //        if (values.ContainsKey(A[i]))
        //            values[A[i]]++;
        //        else
        //            values.Add(A[i], 1);

        //    int max = int.MinValue;
        //    foreach (var p in values)
        //        max = Math.Max(max, p.Key);
        //    primeFactor = GetDivisors(max);

        //    int[] sortedA = new int[n];
        //    Array.Copy(A, sortedA, n);
        //    Array.Sort(sortedA);

        //    int[] result = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {

        //        for (int i = n; i > 0; i /= primeFactor[i])
        //            count += primeFactor[i];
        //        return count;
        //    }

        //    return default;
        //}

        //public int[] GetDivisors(int n)
        //{
        //    int[] numbers = new int[n + 1];
        //    for (int i = 2; i < (int)Math.Sqrt(n) + 1; i++)
        //        if (numbers[i] == 0)
        //            for (int j = i * i; j <= n; j += i)
        //                if (numbers[j] == 0)
        //                    numbers[j] = i;
        //    return numbers;
        //}


    }
}
