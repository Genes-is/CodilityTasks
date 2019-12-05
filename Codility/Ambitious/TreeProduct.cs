using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    class TreeProduct
    {
        public string solution(int[] A, int[] B)
        {
            int n = A.Length;
            int max = n + 1;
            Post[] posts = new Post[n+1];
            posts[0] = new Post(0);

            Post temp;
            for (int i = 1; i <= n; i++)
            {
                posts[i] = new Post(i);
                posts[A[i]].AddChild(posts[i]);
            }

            int N, M, K;
            for (int i = 0; i < n; i++)
            {
                //remove posts[A[i]] -> posts[B[i]]
                N = posts[B[i]].Weight;
                M = n + 1 - posts[B[i]].Weight;
                if (N * M > max) 
                    max = N * M;
                for (int j = 0; j < n; j++)
                {
                    K = posts[B[j]].Weight;
                    if (N * M *K > max)
                        max = N * M;
                }
            }
            return max.ToString();
        }
    }

    class Post
    {
        public int Position { get; set; }
        public int Weight {
            get
            {
                int result = 1;
                foreach(var p in childs)
                    result += p.Weight;
                return result;
            }}
        private List<Post> childs;

        public Post(int position)
        {
            childs = new List<Post>();
            Position = position;
        }
        public void AddChild(Post child) => childs.Add(child);
        public bool Contains(int pos)
        {
            bool result = false;
            foreach(var c in childs)
            {
                if (c.Position == pos)
                    return true;
                result = c.Contains(pos);
                if (result)
                    return true;
            }
            return false;
        }
    }
}
