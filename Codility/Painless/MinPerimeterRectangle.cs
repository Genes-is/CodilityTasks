using System;

namespace Codility.Painless
{
    class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            int sqrt = (int)Math.Sqrt(N);
            for (int i = sqrt; i > 0; i--)
                if (N % i == 0)
                    return 2 * (N / i + i);
            return -1;
        }
    }
}
