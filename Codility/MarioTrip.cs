using System;
using System.Collections.Generic;

namespace Codility.Respectable
{
    class MarioTrip
    {
        public int Solution(int[,] A)
        {
            int N = A.GetLength(0);
            int M = A.GetLength(1);
            int[,] Weight = new int[N, M];

            Weight[0, 0] = A[0, 0];
            for (int i = 1; i < N; i++)
                Weight[i, 0] = Weight[i - 1, 0] + A[i, 0];
            for (int i = 1; i < M; i++)
                Weight[0, i] = Weight[0, i - 1] + A[0, i];

            for (int i = 1; i < N; i++)
                for (int j = 1; j < M; j++)
                    Weight[i, j] = Math.Min(Weight[i, j - 1], Weight[i - 1, j]) + A[i, j];

            return Weight[N - 1, M - 1];
        }

        public bool[,] SolutionRouteOutput(int[,] A)
        {
            int N = A.GetLength(0);
            int M = A.GetLength(1);
            int[,] weight = new int[N, M];

            weight[0, 0] = A[0, 0];
            for (int i = 1; i < N; i++)
                weight[i, 0] = weight[i - 1, 0] + A[i, 0];
            for (int i = 1; i < M; i++)
                weight[0, i] = weight[0, i - 1] + A[0, i];

            for (int i = 1; i < N; i++)
                for (int j = 1; j < M; j++)
                    weight[i, j] = Math.Min(weight[i, j - 1], weight[i - 1, j]) + A[i, j];

            bool[,] path = new bool[N, M];
            int x = N - 1;
            int y = M - 1;
            path[x, y] = true;
            for (int i = 0; i < N+M-2; i++)
            {
                if (x == 0 || (y > 0 && weight[x, y - 1] <= weight[x - 1, y])) 
                    y--;
                else
                    x--;
                path[x, y] = true;
            }
            return path;
        }


        public bool[,] Painfull(int[,] A)
        {
            int N = A.GetLength(0);
            int M = A.GetLength(1);
            int[,] weight = new int[N, M];
            bool[,] marked = new bool[N, M];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    weight[i, j] = int.MaxValue;

            weight[0, 0] = A[0, 0];
            int min;
            int x = 0;
            int y = 0;
            while (!marked[N - 1, M - 1])
            {
                min = int.MaxValue;
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                        if (!marked[i, j] && min > weight[i, j])
                        {
                            min = A[i, j];
                            x = i;
                            y = j;
                        }

                marked[x, y] = true;
                if (y > 0 && !marked[x, y - 1])
                    weight[x, y - 1] = Math.Min(weight[x, y] + A[x, y - 1], weight[x, y - 1]);
                if (x > 0 && !marked[x - 1, y])
                    weight[x - 1, y] = Math.Min(weight[x, y] + A[x - 1, y], weight[x - 1, y]);
                if (y < M - 1 && !marked[x, y + 1])
                    weight[x, y + 1] = Math.Min(weight[x, y] + A[x, y + 1], weight[x, y + 1]);
                if (x < N - 1 && !marked[x + 1, y])
                    weight[x + 1, y] = Math.Min(weight[x, y] + A[x + 1, y], weight[x + 1, y]);
            }

            //return marked;
            return PainfullOutput(weight, marked);
        }

        public bool[,] PainfullOutput(int[,] weight, bool[,] marked)
        {
            int N = weight.GetLength(0);
            int M = weight.GetLength(1);
            int x = N - 1;
            int y = M - 1;
            int xCur;
            int yCur;
            bool[,] path = new bool[N, M];
            path[x, y] = true;

            while (!path[0, 0])
            {
                xCur = x;
                yCur = y;
                if (y > 0 && marked[x, y - 1] && weight[xCur, yCur] > weight[x, y - 1])
                    yCur = y - 1;
                if (x > 0 && marked[x - 1, y] && weight[xCur, yCur] > weight[x - 1, y])
                    xCur = x - 1;
                if (y < M - 1 && marked[x, y + 1] && weight[xCur, yCur] > weight[x, y + 1])
                    yCur = y + 1;
                if (x < N - 1 && marked[x + 1, y] && weight[xCur, yCur] > weight[x + 1, y])
                    xCur = x + 1;
                path[xCur, yCur] = true;
                x = xCur;
                y = yCur;
            }
            return path;
        }
    }
}
