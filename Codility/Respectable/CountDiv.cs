namespace Codility
{
    class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            if (A == B && A % K == 0)
                return 1;
            if (A == B)
                return 0;
            A = A % K == 0 ? A / K : A / K + 1;
            B = B / K;
            return B - A + 1;
        }

        public int sol2(int A, int B, int K) =>
            B / K - (A - 1) / K + (A == 0 && K != 1 ? 1 : 0);

    }
}
