namespace Codility
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            int N = A.Length;
            if (N < 2)
                return A;
            K = K % N;

            int[] res = new int[N];

            int pos;
            for (int i = 0; i < N; i++)
            {
                pos = i + K < N ? i + K : i + K - N;
                res[pos] = A[i];
            }
            return res;
        }

        public int[] solution2(int[] A, int K)
        {
            int N = A.Length;
            if (N < 2)
                return A;
            K = K % N;
            int[] res = new int[N];
            for (int i = 0; i < N; i++)
                res[i] = A[(i - K + N) % N];
            return res;
        }
    }
}
