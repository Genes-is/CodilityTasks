using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    i++;
                }
                else
                {
                    return A[i];
                }

            }
            return A[A.Length-1];
        }

        public int solution2(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>(A.Length / 2 + 1);

            for (int i = 0; i < A.Length; i++)
            {
                if (dict.ContainsKey(A[i]))
                {
                    dict[A[i]]++;
                }
                else
                {
                    dict.Add(A[i], 1);
                }
            }

            foreach (var el in dict)
            {
                if (el.Value % 2 == 1)
                {
                    return el.Key;
                }
            }

            return default;
        }
    }
}
