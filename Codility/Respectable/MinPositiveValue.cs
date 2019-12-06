using System;

namespace Codility
{
    class MinPositiveValue
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            if(A[0] > 1)
                return 1;
            else if(A[A.Length - 1] < 0)
                return 1;
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 0)
                {
                    index = i;
                    break;
                }
            }
            if (A[index] > 1)
                return 1;
            for (int i = index; i < A.Length-1; i++)
            {
                if (A[i + 1] - A[i] > 1)
                    return A[i] + 1;
            }
            return A[A.Length - 1] + 1;
        }
    }

}
