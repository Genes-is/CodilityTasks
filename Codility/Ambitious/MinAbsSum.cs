using System;

namespace Codility
{
    class MinAbsSum
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            int M = 0;
            int S = 0;
            for (int i = 0; i < N; i++)
            {
                A[i] = Math.Abs(A[i]);
                M = Math.Max(M, A[i]);
            }

            int[] counts = new int[M + 1];
            for (int i = 0; i < N; i++)
            {
                S += A[i];
                counts[A[i]]++;
            }
            int[] dp = new int[S + 1];
            dp[0] = 1;
            for (int i = 1; i <= M; i++)
                if (counts[i] > 0)
                    for (int j = 0; j < S; j++)
                        if (dp[j] > 0)
                            dp[j] = counts[i]+1;
                        else if ((j >= i) && (dp[j - i] > 1))
                            dp[j] = dp[j - i] - 1;
            int result = S;
            for (int i = 0; i < (S / 2 + 1); i++)
                if (dp[i] > 0)
                    result = Math.Min(result, S - 2 * i);
            return result;
        }
    }
}