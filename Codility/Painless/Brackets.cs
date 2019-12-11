using System;
using System.Collections.Generic;

namespace Codility.Painless
{
    class Brackets
    {
        public int solution(String S)
        {
            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
                if (S[i] == '(' || S[i] == '[' || S[i] == '{')
                    brackets.Push(S[i]);
                else if (brackets.Count == 0 || Math.Abs(brackets.Pop() - S[i]) > 2)
                    return 0;

            if (brackets.Count == 0)
                return 1;

            return 0;
        }
    }
}
