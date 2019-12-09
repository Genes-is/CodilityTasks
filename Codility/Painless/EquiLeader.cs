using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class EquiLeader
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int candidate = 0;
            int count = 0;

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

            count = 0;
            int[] counts = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (A[i] == leader)
                    count++;
                counts[i] = count;
            }

            int result = 0;
            for (int i = 0; i < n; i++)
                if (counts[i] > (i + 1) / 2 && (counts[n - 1] - counts[i]) > (n - i - 1) / 2)
                    result++;

            return result;
        }
    }
}
