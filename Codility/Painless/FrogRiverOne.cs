namespace Codility.Painless
{
    class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            int count = 0;
            bool[] leafs = new bool[X];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X && !leafs[A[i]])
                {
                    leafs[A[i]] = true;
                    count++;
                    if (count == X)
                        return i;
                }
            }
            return -1;
        }
    }
}
