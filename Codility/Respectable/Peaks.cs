using System.Collections.Generic;

namespace Codility.Respectable
{
    class Peaks
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            List<int> peaks = new List<int>();

            for (int i = 1; i < N - 1; i++)
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                    i++;
                }

            int M = peaks.Count;
            if (M == 0)
                return 0;

            int check;
            for (int i = N / 3; i >= 2; i--)
            {
                if (N % i == 0)
                {
                    check = 1;
                    for (int j = 0; j < peaks.Count; j++)
                    {
                        if (peaks[j] > N / i * check - 1)
                            break;
                        else if (peaks[j] >= N / i * (check - 1)) 
                            check++;
                    }
                    if (check == i+1)
                        return i;
                }
            }

            return 1;
        }
    }
}
