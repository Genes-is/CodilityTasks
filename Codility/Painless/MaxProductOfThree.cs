using System;

namespace Codility.Painless
{
    class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            Array.Sort(A);
            return Math.Max(A[n - 1] * A[n - 2] * A[n - 3], A[n - 1] * A[0] * A[1]);
        }
    }
}
