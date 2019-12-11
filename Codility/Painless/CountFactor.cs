using System;

namespace Codility.Painless
{
    class CountFactor
    {
        public int solution(int N)
        {
            int count = Math.Sqrt(N) == (int)Math.Sqrt(N) ? 1 : 0;
            for (int i = 1; i < Math.Sqrt(N); i++)
                if (N%i == 0)
                    count += 2;
            return count;
        }
    }
}
