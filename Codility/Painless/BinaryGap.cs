namespace Codility
{
    class BinaryGap
    {
        public int solution(int N)
        {
            int max = 0,
                sum = 0,
                cur;

            while (N != 0)
            {
                cur = N & 1;
                N >>= 1;
                if (cur == 1)
                    break;
            }

            while (N != 0)
            {
                cur = N & 1;
                N >>= 1;

                if (cur == 1) 
                { 
                    if (max < sum)
                        max = sum;
                    sum = 0;
                }
                else
                    sum++;
            }

            return max;
        }
    }
}