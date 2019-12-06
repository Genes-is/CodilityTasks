using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Painless
{
    class PermCheck
    {
        public int solution(int[] A)
        {
            int[] B = A.Distinct().ToArray();
            Array.Sort(B);
            int a = A.Length;
            int b = B.Length;

            if (a <= 0) 
                return 0;
            if (a == 1 && A[0] == 1) 
                return 1;

            return (B[b - 1] == b && b == a) ? 1 : 0;
        }
    }
}
