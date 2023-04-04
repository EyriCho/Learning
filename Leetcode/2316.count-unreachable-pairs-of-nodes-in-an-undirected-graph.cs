/*
 * @lc app=leetcode id=2316 lang=csharp
 *
 * [2316] Count Unreachable Pairs of Nodes in an Undirected Graph
 */

// @lc code=start
public class Solution {
    public long CountPairs(int n, int[][] edges) {
        var roots = new int[n];
        for (int i = 0; i < n; i++)
        {
            roots[i] = i;
        }
        
        int GetRoot(int num)
        {
            while (roots[num] != num)
            {
                num = roots[num];
            }
            return num;
        }

        foreach (var edge in edges)
        {
            var rootA = GetRoot(edge[0]);
            var rootB = GetRoot(edge[1]);

            if (rootA != rootB)
            {
                roots[rootB] = rootA;
            }
        }

        var dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            var root = GetRoot(i);
            if (!dict.TryGetValue(root, out int count))
            {
                dict[root] = count = 0;
            }
            dict[root] = count + 1;
        }

        var result = (long)n * (n - 1) / 2;
        foreach (var kv in dict)
        {
            result -= (long)kv.Value * (kv.Value - 1) / 2;
        }

        return result;
    }
}
// @lc code=end

