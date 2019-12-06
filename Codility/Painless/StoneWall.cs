using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Painless
{
    class StoneWall
    {
        public int solution(int[] H)
        {
            var wall = new Stack<int>();
            int count = 0;

            wall.Push(0);
            for (int i = 0; i < H.Length; i++)
            {
                while (wall.Peek() > H[i])
                    wall.Pop();

                if (wall.Peek() != H[i])
                {
                    wall.Push(H[i]);
                    count++;
                }
            }

            return count;
        }
    }
}
