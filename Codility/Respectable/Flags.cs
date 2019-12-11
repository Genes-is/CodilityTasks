using System;

namespace Codility.Respectable
{
    class Flags
    {
        public int solutionBool(int[] A)
        {
            int n = A.Length;
            bool[] peaks = new bool[n];
            int count = 0;

            for (int i = 1; i < n - 1; i++)
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks[i] = true;
                    count++;
                }

            if (count == 0)
                return 0;

            int sum;
            for (int i = Math.Min(count, (int)Math.Sqrt(n)+1); i >= 0; i--) 
            {
                sum = 0;
                for (int j = 1; j < n - 1; j++)
                {
                    if (peaks[j])
                    {
                        sum++;
                        j += i - 1;
                    }
                }
                if (sum >= i)
                    return i;
            }

            return 1;
        }
    }
}