using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class Dominator
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            var values = new Stack<int>();

            for (int i = 1; i < n; i++)
            {
                if (values.Count == 0 || A[i] == values.Peek())
                    values.Push(A[i]);
                else
                    values.Pop();
            }

            if (values.Count > n/2)
                

            return -1;
        }

        public int solution2(int[] A)
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
