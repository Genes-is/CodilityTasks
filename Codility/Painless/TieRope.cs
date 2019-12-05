using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    class TieRope
    {
        public int solution(int K, int[] A)
        {
            int count = 0,
            ropeLenght = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (ropeLenght < K)
                {
                    ropeLenght += A[i];
                }
                else
                {
                    count++;
                    ropeLenght = 0;
                }
            }
            if (ropeLenght >= K)
                count++;
            return count;
        }
    }
}
