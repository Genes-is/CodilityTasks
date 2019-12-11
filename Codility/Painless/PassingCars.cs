namespace Codility.Painless
{
    class PassingCars
    {
        public int solution(int[] A)
        {
            int count = 0;
            int east = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    count += east;
                    if (count > 1000000000)
                        return -1;
                }
                else
                    east++;
            }

            return count;
        }
    }
}
