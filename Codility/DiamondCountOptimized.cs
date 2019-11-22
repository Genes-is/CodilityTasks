using System;

namespace Codility
{
    class DiamondCountOptimized
    {
        public int solution(int[] X, int[] Y)
        {
            int[,] table = new int[X.Length, X.Length];

            int res = 0;
            int N = X.Length;

            for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                    if (X[i] == X[j] && Math.Abs(Y[i] - Y[j]) % 2 == 0)
                        table[X[i], Math.Min(Y[i], Y[j]) + Math.Abs(Y[i] - Y[j]) / 2]++;
            for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                    if (Y[i] == Y[j] && Math.Abs(X[i] - X[j]) % 2 == 0)
                        res += table[Math.Min(X[i], X[j]) + Math.Abs(X[i] - X[j]) / 2, Y[i]];
           
            return res;
        }
    }
}