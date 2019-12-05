using System;

namespace Codility
{
    class DwarfsRafting
    {
        public int solution(int N, string S, string T)
        {
            int size = N / 2,
                result = 0;
            int[,] places = new int[2, 2] { { size * size, size * size },
                                            { size * size, size * size } },
                   dwarfs = new int[2, 2];
            if (S != null && S != "")
            {
                var s = S.Split(' ');
                foreach (var el in s)
                {
                    int i = Convert.ToInt32(el.Substring(0, el.Length - 1));
                    int j = (el[el.Length - 1] - 'A') + 1;
                    places[i <= size ? 0 : 1, j <= size ? 0 : 1]--;
                }
            }
            if (T != null && T != "")
            {
                var t = T.Split(' ');
                foreach (var el in t)
                {
                    int i = Convert.ToInt32(el.Substring(0, el.Length - 1));
                    int j = (el[el.Length - 1] - 'A') + 1;
                    dwarfs[i <= size ? 0 : 1, j <= size ? 0 : 1]++;
                    places[i <= size ? 0 : 1, j <= size ? 0 : 1]--;
                    result--;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if(dwarfs[1 - i, 1 - j] > dwarfs[i, j] && places[i, j] < dwarfs[1 - i, 1 - j])
                    {
                        return -1;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    places[i, j] -= dwarfs[1 - i, 1 - j] - dwarfs[i, j];
                    dwarfs[i, j] = dwarfs[1 - i, 1 - j];
                    int freePlace = Math.Min(places[i, j], places[1 - i, 1 - j]);
                    dwarfs[i, j] += freePlace;
                    places[i, j] -= freePlace;
                    dwarfs[1 - i, 1 - j] += freePlace;
                    places[1 - i, 1 - j] -= freePlace;
                }
            }
            result += dwarfs[0, 0] +dwarfs[0, 1] + dwarfs[1, 0] + dwarfs[1, 1];
            return result;
        }
    }
}