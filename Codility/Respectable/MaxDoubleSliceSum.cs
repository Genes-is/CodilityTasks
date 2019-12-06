using System;
using System.Collections.Generic;

namespace Codility.Respectable
{
    class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int min = 1;
            int[] S = new int[n];
            var N = new List<int>();

            S[0] = A[0];
            N.Add(0);
            for (int i = 1; i < n-1; i++)
            {
                S[i] = S[i - 1] + A[i];
                if (A[i] <= 0)
                    N.Add(i);
                else if (A[min] > A[i])
                    min = i;
            }
            S[n - 1] = S[n - 2] + A[n - 1];
            N.Add(n - 1);

            int m = N.Count;
            if (m < 3)
                return S[n - 2] - A[min] - A[0];

            min = 0;

            for (int i = 0; i < m; i++)
                for (int j = i + 1; j < m; j++)
                    for (int k = j + 1; k < m; k++)
                        min = Math.Max(min, S[N[k] - 1] - A[N[j]] - S[N[i]]);

            return min;
        }

        public int TheBestSolution(int[] A)
        {
            int n = A.Length;
            int[] XY = new int[n];
            int[] XZ = new int[n];

            for (int i = 1; i < n - 1; i++)
                XY[i] = Math.Max(XY[i - 1] + A[i], 0);
            for (int i = n - 2; i > 0; i--)
                XZ[i] = Math.Max(XZ[i + 1] + A[i], 0);

            int max = 0;
            for (int i = 1; i < n - 1; i++)
                max = Math.Max(max, XY[i - 1] + XZ[i + 1]);

            return max;
        }
    }
}
