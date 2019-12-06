using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Respectable
{
    class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int max = 0;
            int maxLevel = 0;
            int cur;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == N + 1)
                {
                    maxLevel = max;
                    continue;
                }
                else if (counters[A[i]-1] < maxLevel)
                    counters[A[i]-1] = maxLevel + 1;
                else
                    counters[A[i]-1]++;
                max = Math.Max(max, counters[A[i]-1]);
            }


            for (int i = 0; i < N; i++)
                if (counters[i] < maxLevel)
                    counters[i] = maxLevel;
            return counters;
        }
    }
}
