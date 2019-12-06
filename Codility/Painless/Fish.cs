using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class Fish
    {
        public int solution(int[] A, int[] B)
        {
            Stack<int> fishes = new Stack<int>();
            int survivedUp = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0)
                {
                    if (fishes.Count == 0)
                        survivedUp++;
                    else
                    {
                        while (fishes.Count != 0 && A[i] > fishes.Peek())
                            fishes.Pop();
                        if (fishes.Count == 0)
                            survivedUp++;
                    }
                }
                else
                    fishes.Push(A[i]);
            }

            return fishes.Count + survivedUp;
        }
    }
}
