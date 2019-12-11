using System;

namespace Codility.Painless
{
    class MaxProfit
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            if (n < 2)
                return 0;
            int min = A[0];
            int[] diff = new int[n];

            for (int i = 0; i < n; i++)
            {
                diff[i] = A[i] - min;
                if (min > A[i])
                    min = A[i];
            }

            int profit = 0;
            for (int i = 0; i < n; i++)
                profit = Math.Max(profit, diff[i]);

            return profit;
        }
    }
}
