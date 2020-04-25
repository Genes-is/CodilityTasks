using System;
using System.Linq;

namespace Codility.Ambitious
{
    class SlalomSkying
    {
        //using long variables because of integer can be exceeded
        public int solution(int[] A)
        {
            long bound = A.Max();
            int N = A.Length;
            var withMirrors = new long[N * 3];

            for (int i = 0; i < N; i++)
            {
                withMirrors[i * 3] = bound * 2 + A[i] + 1;
                withMirrors[i * 3 + 1] = bound * 2 - A[i] + 1;
                withMirrors[i * 3 + 2] = A[i];
            }

            return GetLongestIncreasingSubsequenceLength1(withMirrors);
        }

        //slow algorithm, O(N^2), 61%
        public int GetLongestIncreasingSubsequenceLength1(long[] A)
        {
            long N = A.Length;
            var lis = new long[N];
  
            /* Initialize LIS values for all indexes */
            for (long i = 0; i < N; i++)  
                lis[i] = 1;  
  
            /* Compute optimized LIS values in bottom up manner */
            for (long i = 1; i < N; i++)  
                for (long j = 0; j < i; j++)  
                    if (A[i] > A[j] && lis[i] < lis[j] + 1)  
                        lis[i] = lis[j] + 1;  
  
            return (int)lis.Max();  
        }

        //O(log(N)) complexity, optimized algorithm, 100%
        public int GetLongestIncreasingSubsequenceLength2(long[] A)
        {
            long N = A.Length;
            var temp = new long[N];
            int len = 1;
            for (int i = 0; i < N; i++)
            {
                long fnd = Array.BinarySearch(temp, 0, len, A[i]);

                if (fnd < 0)
                    fnd = -fnd - 1;

                if (fnd == len)
                    len++;

                temp[fnd] = A[i];
            }
            return len;
        }
    }
}
