using System;

namespace Codility.Painless
{
    class Nesting
    {
        public int solution(String S)
        {
            int count = 0;
            for (int i = 0; i < S.Length; i++)
                if (S[i] == '(')
                    count++;
                else if (count > 0)
                    count--;
                else
                    return 0;

            if (count == 0)
                return 1;

            return 0;
        }
    }
}
