/*
 * @lc app=leetcode id=2421 lang=csharp
 *
 * [2421] Number of Good Paths
 */

// @lc code=start
public class Solution {
    public int NumberOfGoodPaths(int[] vals, int[][] edges) {
        var maps = new List<int>[vals.Length];
        var roots = new int[vals.Length];
        var dict = new SortedDictionary<int, List<int>>();
        for (int i = 0; i < vals.Length; i++)
        {
            maps[i] = new List<int>();
            roots[i] = i;
            if (!dict.TryGetValue(vals[i], out List<int> g))
            {
                dict[vals[i]] = g = new List<int>();
            }
            g.Add(i);
        }

        foreach (var edge in edges)
        {
            if (vals[edge[0]] > vals[edge[1]])
            {
                maps[edge[0]].Add(edge[1]);
            }
            else
            {
                maps[edge[1]].Add(edge[0]);
            }
        }

        int FindRoot(int node)
        {
            while (node != roots[node])
            {
                roots[node] = roots[roots[node]];
                node = roots[node];
            }
            return node;
        }

        var result = vals.Length;
        foreach (var group in dict)
        {
            foreach (var node in group.Value)
            {
                foreach (var prev in maps[node])
                {
                    var prevRoot = FindRoot(prev);
                    var nodeRoot = FindRoot(node);

                    if (vals[prevRoot] == group.Key)
                    {
                        roots[nodeRoot] = prevRoot;
                    }
                    else
                    {
                        roots[prevRoot] = nodeRoot;
                    }
                }
            }

            var counts = new Dictionary<int, int>();
            foreach (var node in group.Value)
            {
                var root = FindRoot(node);
                if (!counts.TryGetValue(root, out int count))
                {
                    count = 0;
                }
                counts[root] = count + 1;
            }

            foreach (var count in counts)
            {
                result += count.Value * (count.Value - 1) / 2;
            }
        }

        return result;
    }
}
// @lc code=end

