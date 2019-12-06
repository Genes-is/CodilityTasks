using System;
using System.Collections.Generic;

namespace Codility.Respectable
{
    class GenomicRangeQuery
    {
        public int[] solution(String S, int[] P, int[] Q)
        {
            var A = new List<int>();
            var C = new List<int>();
            var G = new List<int>();

            int n = P.Length;
            for (int i = 0; i < S.Length; i++)
            {
                switch (S[i])
                {
                    case 'A':
                        A.Add(i);
                        break;
                    case 'C':
                        C.Add(i);
                        break;
                    case 'G':
                        G.Add(i);
                        break;
                }
            }

            int index;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                index = A.BinarySearch(P[i]);
                if (index < 0)
                    index = -index - 1;
                if (index != A.Count && A[index] <= Q[i])
                {
                    res[i] = 1;
                    continue;
                }

                index = C.BinarySearch(P[i]);
                if (index < 0)
                    index = -index - 1;
                if (index != C.Count && C[index] <= Q[i])
                {
                    res[i] = 2;
                    continue;
                }

                index = G.BinarySearch(P[i]);
                if (index < 0)
                    index = -index - 1;
                if (index != G.Count && G[index] <= Q[i])
                {
                    res[i] = 3;
                    continue;
                }

                res[i] = 4;
            }
            return res;
        }
    }
}
