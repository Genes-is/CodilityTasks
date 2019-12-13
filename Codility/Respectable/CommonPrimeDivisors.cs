namespace Codility.Respectable
{
    class CommonPrimeDivisors
    {
        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        public int solution(int[] A, int[] B)
        {
            int a, b, c, d,
                count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                a = A[i];
                b = B[i];
                d = GCD(a, b);
                while ((c = GCD(a, d)) != 1)
                    a /= c;
                while ((c = GCD(b, d)) != 1)
                    b /= c;
                if (a == 1 && b == 1)
                    count++;
            }
            return count;
        }
    }
}
