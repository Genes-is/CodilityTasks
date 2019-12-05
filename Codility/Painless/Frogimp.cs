using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    class Frogimp
    {
        public int solution(int X, int Y, int D)
        {
            int diff = Y - X;
            return diff % D == 0 ? diff / D : diff / D + 1;
        }
    }
}
