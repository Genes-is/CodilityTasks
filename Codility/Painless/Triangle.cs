using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class Triangle
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            for (int i = 0; i < A.Length - 2; i++)
                if (A[i] > A[i + 2] - A[i + 1])
                    return 1;
            return 0;
        }
    }
}
