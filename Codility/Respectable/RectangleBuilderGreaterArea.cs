using System;
using System.Collections.Generic;

namespace Codility
{
    class RectangleBuilderGreaterArea
    {
        public int solution(int[] A, int X)
        {
            int count = 0;
            var fences = new Dictionary<int, int>();

            int n = 0;
            for (int i = 0; i < A.Length; i++)
            {
                n = A[i];
                if (fences.ContainsKey(n))
                    fences[n]++;
                else
                    fences.Add(n, 1);
            }

            var pairs = new List<int>();
            int expected = (int)Math.Sqrt(X);
            expected += expected * expected < X ? 1 : 0;
            foreach (var p in fences)
            {
                if (p.Value < 2)
                    continue;
                else if (p.Value < 4)
                    pairs.Add(p.Key);
                else
                {
                    pairs.Add(p.Key);
                    if (p.Key >= expected)
                        count++;
                }
            }

            pairs.Sort();
            int index;
            for (int i = 0; i < pairs.Count - 1; i++)
            {
                if (count > 1000000000)
                    return -1;

                expected = X / pairs[i] + (X % pairs[i] == 0 ? 0 : 1);
                if(pairs[i] >= expected)
                {
                    count += pairs.Count - 1 - i;
                    continue;
                }

                index = pairs.BinarySearch(expected);
                if (index < 0)
                    index = -index - 1;
                count += pairs.Count - index;
            }

            if (count > 1000000000)
                return -1;
            return count;
        }

        public int solutionVitia(int[] A, int X)
        {
            int res = 0;
            List<int> pairs = new List<int>();
            List<int> doublePairs = new List<int>();
            Array.Sort(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    if (pairs.Count > 0 && pairs[pairs.Count - 1] == A[i])
                        if (doublePairs.Count == 0 || doublePairs[doublePairs.Count - 1] != A[i])
                            doublePairs.Add(A[i]);
                        else
                            pairs.Add(A[i]);
                    i++;
                }
            }

            int expected = (int)Math.Sqrt(X);
            expected += expected * expected < X ? 1 : 0;
            int index = doublePairs.BinarySearch(expected);

            if (index < 0)
                index = -index - 1;
            res += doublePairs.Count - index;

            for (int i = 0; i < pairs.Count - 1; i++)
            {
                if (res > 1000000000)
                    return -1;
                if (pairs[i] >= X)
                {
                    res += pairs.Count - 1 - i;
                    continue;
                }

                expected = X / pairs[i] + (X % pairs[i] == 0 ? 0 : 1);
                index = pairs.BinarySearch(expected);

                if (index < 0)
                    index = -index - 1;
                if (index <= i)
                {
                    res += pairs.Count - 1 - i;
                    continue;
                }
                res += pairs.Count - index;
            }

            if (res > 1000000000)
                return -1;

            return res;
        }
    }
}
