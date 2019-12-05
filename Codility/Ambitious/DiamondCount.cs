using System;
using System.Collections.Generic;

namespace Codility
{
    class DiamondCount
    {
        public int solution(int[] X, int[] Y)
        {
            int count = 0,
                N = X.Length;
            List<int>[] graphX = GetGraph(X, N);
            List<int>[] graphY = GetGraph(Y, N);
            List<Pair> PairsX = new List<Pair>();
            List<Pair> PairsY = new List<Pair>();
            for (int i = 0; i < N; i++)
            {
                if (graphX[i] != null)
                    PairsX.AddRange(GetPairs(graphX[i], i, Y));
                if (graphY[i] != null)
                    PairsY.AddRange(GetPairs(graphY[i], i, X));
            }
            foreach(Pair pX in PairsX)
            {
                foreach (Pair pY in PairsY)
                {
                    if (pX.index == pY.avarage && pX.avarage == pY.index)
                        count++;
                }
            }

            return count;
        }

        private List<int>[] GetGraph(int[] X, int N)
        {
            List<int>[] graph = new List<int>[N];
            for (int i = 0; i < N; i++)
            {
                if (graph[X[i]] == null)
                    graph[X[i]] = new List<int>();
                graph[X[i]].Add(i);
            }
            return graph;
        }

        private List<Pair> GetPairs(List<int> list, int index, int[] array)
        {
            var pairs = new List<Pair>();
            int temp,
                p1,
                p2;
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    p1 = array[list[i]];
                    p2 = array[list[j]];
                    temp = Math.Abs(p1 - p2);
                    if (temp%2 == 0)
                        pairs.Add(new Pair() { index = index, avarage = Math.Min(p1, p2) + temp/2});
                }
            }
            return pairs;
        }
    }
    class Pair
    {
        public int index;
        public int avarage;
    }
}
