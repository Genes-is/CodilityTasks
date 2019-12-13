namespace Codility.Respectable
{
    class ChocolatesByNumbers
    {
        public int solution(int N, int M) => N / GCD(N, M);

        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        //private int Gcd(int a, int b)
        //{
        //    if (a == b)
        //        return a;
        //    if (a > b)
        //        Gcd(a - b, b);
        //    else
        //        Gcd(a, b - a);
        //    return -1;
        //}
    }
}
