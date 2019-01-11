using System;
using System.Collections.Generic;
using System.Linq;

// public class DisjointUnionSets 
// { 
//     public int[] rank, parent; 
//     int n; 

//     // Constructor 
//     public DisjointUnionSets(int n) 
//     { 
//         rank = new int[n]; 
//         parent = new int[n]; 
//         this.n = n; 
//         makeSet(); 
//     } 

//     // Creates n sets with single item in each 
//     public void makeSet() 
//     { 
//         for (int i=0; i<n; i++) 
//         { 
//             // Initially, all elements are in 
//             // their own set. 
//             parent[i] = i; 
//         } 
//     } 

//     // Returns representative of x's set 
//     public int find(int x) 
//     { 
//         // Finds the representative of the set 
//         // that x is an element of 
//         if (parent[x]!=x) 
//         { 
//             // if x is not the parent of itself 
//             // Then x is not the representative of 
//             // his set, 
//             parent[x] = find(parent[x]); 

//             // so we recursively call Find on its parent 
//             // and move i's node directly under the 
//             // representative of this set 
//         } 

//         return parent[x]; 
//     } 

//     // Unites the set that includes x and the set 
//     // that includes x 
//     public void union(int x, int y) 
//     { 
//         // Find representatives of two sets 
//         int xRoot = find(x), yRoot = find(y); 

//         // Elements are in the same set, no need 
//         // to unite anything. 
//         if (xRoot == yRoot) 
//             return; 

//          // If x's rank is less than y's rank 
//         if (rank[xRoot] < rank[yRoot]) 

//             // Then move x under y  so that depth 
//             // of tree remains less 
//             parent[xRoot] = yRoot; 

//         // Else if y's rank is less than x's rank 
//         else if (rank[yRoot] < rank[xRoot]) 

//             // Then move y under x so that depth of 
//             // tree remains less 
//             parent[yRoot] = xRoot; 

//         else // if ranks are the same 
//         { 
//             // Then move y under x (doesn't matter 
//             // which one goes where) 
//             parent[yRoot] = xRoot; 

//             // And increment the the result tree's 
//             // rank by 1 
//             rank[xRoot] = rank[xRoot] + 1; 
//         } 
//     } 
// } 

// https://www.hackerrank.com/challenges/components-in-graph/problem 
// find smallest and largest connected components in a graph 
// Sample Input
// 5
// 1 6 
// 2 7
// 3 8
// 4 9
// 2 6
// Sample Output
// 2 4
public class GraphTheory
{

    public int[] Union(List<int[]> pairs, int n)
    {
        var parents = new int[n + 1];

        for (int i = 1; i < parents.Length; i++)
        {
            parents[i] = i;
        }

        int[] rank = new int[2];

        pairs.ForEach(p =>
        {
            var l = parents[p[0]];
            var r = parents[p[1]];

            if (r < l)
            {
                for (int i = 1; i < parents.Length; i++)
                {
                    if (parents[i] == l)
                    {
                        parents[i] = r;
                    }
                }
            }
            else if (r > l)
            {
                for (int i = 1; i < parents.Length; i++)
                {
                    if (parents[i] == r)
                    {
                        parents[i] = l;
                    }
                }
            }
        });

        var g = parents
                .GroupBy(i => i)
                .Select(i => i.ToList().Count())
                .Where(i => i > 1);

        rank[0] = g.Min();
        rank[1] = g.Max();
        return rank;

    }

    public int GetMinKey(int[] keys, bool[] mst)
    {
        int min = Int32.MaxValue;
        int minindex = -1;

        for (int i = 1; i < keys.Length; i++)
        {
            if (keys[i] < min && mst[i] == false)
            {
                min = keys[i];
                minindex = i;
            }
        }
        return minindex;
    }

    Dictionary<int, Node> nodes = new Dictionary<int, Node>();
    public int MST(int[,] g, int v)
    {
        int[] keys = new int[v + 1];
        int[] parents = new int[v + 1];
        bool[] mst = new bool[v + 1];

        for (int k = 1; k < v + 1; k++)
        {
            keys[k] = Int32.MaxValue;
            mst[k] = false;
        }
        keys[0] = 0;
        mst[0] = true;
        parents[0] = -1;
        keys[1] = 0;
        parents[1] = -1;

        for (int i = 1; i < v; i++)
        {
            int min = GetMinKey(keys, mst);
            mst[min] = true;

            for (int j = 1; j < v + 1; j++)
            {
                if (mst[j] == false && g[min, j] != 0 && g[min, j] < keys[j])
                {
                    parents[j] = i;
                    keys[j] = g[min, j];
                }
            }
        }

        for (int i = 1; i < v + 1; i++)
        {
            nodes.Add(i, new Node(parents[i], keys[i]));

        }

        int wt = 0;

        for (int i = 1; i < 6; i++)
        {
            for (int j = i + 1;j < 6; j++)
            {
                wt += GetWeight(j, i, 0);
            }
        }

        var str = Convert.ToString(wt, 2);
        var arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = Convert.ToInt32(arr[i].ToString());
        }

        return keys.Sum();
    }

    public int GetWeight(int n, int p, int wt)
    {

        if (nodes[n].Parent == p || nodes[n].Parent == -1)
        {
            wt += nodes[n].Weight;
            return wt;
        }

        wt += nodes[n].Weight;
        return GetWeight(nodes[n].Parent, p, wt);

    }

    public class Node
    {
        public int Parent { get; set; }
        public int Weight { get; set; }

        public List<Node> Children {get;set;}

        public Node(int p, int w)
        {
            this.Parent = p;
            this.Weight = w;
        }
    }

}