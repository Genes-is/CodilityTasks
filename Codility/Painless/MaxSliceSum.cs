using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class MaxSliceSum
    {
        public int solution(int[] A)
        {
            int cur = A[0];
            int max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                cur = Math.Max(A[i], cur + A[i]);
                max = Math.Max(cur, max);
            }
            return max;
        }
    }
}
