using System.Linq;

namespace Codility.Respectable
{
    class Ladder
    {
        public int[] solution(int[] A, int[] B)
        {
            int n = A.Length;
            int max = A.Max();

            int[] dp = new int[max + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= max; i++)
                dp[i] = dp[i - 1] + dp[i - 2] & 0x3FFFFFFF;

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = dp[A[i]] &((1 << B[i]) - 1);
            return result;
        }
    }
}
