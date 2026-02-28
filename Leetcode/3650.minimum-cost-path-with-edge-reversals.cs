/*
 * @lc app=leetcode id=3650 lang=csharp
 *
 * [3650] Minimum Cost Path with Edge Reversals
 */

// @lc code=start
public class Solution {
    public int MinCost(int n, int[][] edges) {
        int[] cost = new int[n];
        List<(int, int)>[] maps = new List<(int, int)>[n];

        for (int i = 0; i < n; i++)
        {
            cost[i] = int.MaxValue;
            maps[i] = new ();
        }

        foreach (int[] edge in edges)
        {
            maps[edge[0]].Add((edge[1], edge[2]));
            maps[edge[1]].Add((edge[0], edge[2] * 2));
        }

        int node = 0,
            c = 0;
        PriorityQueue<(int, int), int> queue = new ();
        queue.Enqueue((0, 0), 0);
        cost[c] = 0;
        while (queue.Count > 0)
        {
            (node, c) = queue.Dequeue();

            foreach ((int next, int w) in maps[node])
            {
                if (c + w < cost[next])
                {
                    cost[next] = c + w;
                    queue.Enqueue((next, cost[next]), cost[next]);
                }
            }
        }

        return cost[^1] == int.MaxValue ? -1 : cost[^1];
    }
}
// @lc code=end

