using System;

namespace Codility.Respectable
{
    class NumberOfDiscIntersections
    {

        public int solution(int[] A)
        {
            int N = A.Length;
            int sum = 0;
            int count = 0;

            if (N < 1)
                return 0;

            int[] lborder = new int[N];
            int[] rborder = new int[N];
            for (int i = 0; i < N; i++)
            {
                lborder[Math.Max(0, (long)i - A[i])]++;
                rborder[Math.Min(N - 1, (long)i + A[i])]++;
            }

            for (int i = 0; i < N; i++)
            {
                sum += lborder[i] * count + SumArifmet(lborder[i]);
                count += lborder[i] - rborder[i];
                if (sum > 10000000)
                    return -1;
            }

            return sum;
        }

        private static int SumArifmet(int N)
        {
            int sum = 0;
            for (int i = 1; i < N; i++)
                sum += i;
            return sum;
        }


    }
    struct Circle
    {
        public int O { get; set; }
        public int R { get; set; }
        public static int CompareByRadius(Circle a, Circle b) => a.R.CompareTo(b.R);
    }
}
