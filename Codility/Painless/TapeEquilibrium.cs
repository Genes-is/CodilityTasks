using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            int min = int.MaxValue;
            for (int i = 1; i < N; i++)
                A[i] = A[i] + A[i-1];
            for (int i = 0; i < N-1; i++)
                min = Math.Min(min, Math.Abs(A[i] - (A[N - 1] - A[i])));
            return min;
        }
    }
}
