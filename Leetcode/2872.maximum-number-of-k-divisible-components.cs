/*
 * @lc app=leetcode id=2872 lang=csharp
 *
 * [2872] Maximum Number of K-Divisible Components
 */

// @lc code=start
public class Solution {
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
        if (n == 1)
        {
            return 1;
        }

        long[] totals = new long[n];
        HashSet<int>[] maps = new HashSet<int>[n];
        for (int i = 0; i < n; i++)
        {
            maps[i] = new ();
            totals[i] = values[i];
        }

        foreach (int[] edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        Queue<int> queue = new ();
        for (int i = 0; i < n; i++)
        {
            if (maps[i].Count == 1)
            {
                queue.Enqueue(i);
            }
        }

        int node = 0,
            result = 0;

        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            if (totals[node] % k == 0)
            {
                result++;
            }

            foreach (int parent in maps[node])
            {
                maps[parent].Remove(node);
                if (maps[parent].Count == 1)
                {
                    queue.Enqueue(parent);
                }
                totals[parent] += totals[node];
            }
        }

        return result;
    }
}
// @lc code=end

