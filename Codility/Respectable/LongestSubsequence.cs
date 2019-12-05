namespace Codility.Respectable
{
    class LongestSubsequence
    {
        public int[] Solution(int[] A)
        {
            int n = A.Length;
            int[] P = new int[n];
            int[] L = new int[n];

            P[0] = -1;
            L[0] = 1;
            for (int i = 1; i < n; L[i]++, i++)
                for (int j = 0; j < i; j++)//can be reversed
                    if (A[i] > A[j] && L[j] >= L[i])
                    {
                        L[i] = L[j];
                        P[i] = j;
                    }

            int max = 0;
            int index = 0;
            for (int i = 0; i < n; i++)
                if (L[i] > max)
                {
                    max = L[i];
                    index = i;
                }

            int[] result = new int[max];
            for (int i = max - 1; i >= 0; i--)
            {
                result[i] = A[index];
                index = P[index];
            }

            return result;
        }


        public int[] Solution2(int[] A)
        {
            int N = A.Length;
            int max = 0;
            int[] count = new int[N];

            for (int i = 1; i < N; i++, max = 0)
            {
                for (int j = 0; j < i; j++)
                    if (max < count[j] && A[j] < A[i])
                        max = count[j];
                count[i] = max + 1;
            }

            max = 0;
            for (int i = 0; i < N; i++)
                if (max < count[i])
                    max = count[i];

            int[] res = new int[max + 1];
            for (int i = N - 1; i >= 0; i--)
                if (count[i] == max)
                {
                    res[max] = A[i];
                    max--;
                }

            return res;
        }
    }
}
