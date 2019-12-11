namespace Codility.Painless
{
    class Dominator
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int candidate = 0;
            int count = 0;
            if (n < 1)
                return -1;

            for (int i = 0; i < n; i++)
            {
                if (count == 0)
                    candidate = i;
                if (A[i] == A[candidate])
                    count++;
                else
                    count--;
            }

            int leader = A[candidate];
            if (count == 0)
                leader = -1;

            count = 0;
            for (int i = 0; i < n; i++)
                if (A[i] == leader)
                    count++;

            if (count <= n / 2)
                return -1;
            return candidate;
        }
    }
}
