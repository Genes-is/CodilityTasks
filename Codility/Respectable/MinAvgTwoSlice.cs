namespace Codility
{
    class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            int minPos = 0;
            int N = A.Length;
            double minAvg = (A[0] + A[1]) / 2.0;

            for (int i = 0; i < N - 2; i++)
            {
                if (minAvg > (A[i] + A[i + 1]) / 2.0)
                {
                    minAvg = (A[i] + A[i + 1]) / 2.0;
                    minPos = i;
                }
                if (minAvg > (A[i] + A[i + 1] + A[i + 2]) / 3.0)
                {
                    minAvg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    minPos = i;
                }
            }

            if (minAvg > (A[N - 2] + A[N - 1]) / 2.0)
            {
                minAvg = (A[N - 2] + A[N - 1]) / 2.0;
                minPos = N - 2;
            }

            return minPos;
        }
    }
}
