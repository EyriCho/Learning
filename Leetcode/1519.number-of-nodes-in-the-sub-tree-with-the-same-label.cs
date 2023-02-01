/*
 * @lc app=leetcode id=1519 lang=csharp
 *
 * [1519] Number of Nodes in the Sub-Tree With the Same Label
 */

// @lc code=start
public class Solution {
    public int[] CountSubTrees(int n, int[][] edges, string labels) {
        var maps = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            maps[i] = new List<int>();
        }
        foreach (var edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        var result = new int[n];
        Array.Fill(result, 1);
        var visited = new bool[n];

        var dict = new Dictionary<char, List<int>>();
        dict[labels[0]] = new List<int>();
        dict[labels[0]].Add(0);

        void Travel(int i)
        {
            foreach (var next in maps[i])
            {
                if (!visited[next])
                {
                    if (!dict.TryGetValue(labels[next], out List<int> prevs))
                    {
                        dict[labels[next]] = prevs = new List<int>();
                    }

                    foreach(var prev in prevs)
                    {
                        result[prev]++;
                    }

                    visited[next] = true;

                    prevs.Add(next);
                    Travel(next);
                    prevs.Remove(next);
                }
            }
        }

        visited[0] = true;
        Travel(0);

        return result;
    }
}
// @lc code=end

