using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class PermMissingElem
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            bool[] set = new bool[N+2];
            for (int i = 0; i < N; i++)
                set[A[i]] = true;
            for (int i = 1; i < N+2; i++)
                if (set[i] == false)
                    return i;
            return -1;
        }
    }
}
