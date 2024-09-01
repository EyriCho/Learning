/*
 * @lc app=leetcode id=2699 lang=csharp
 *
 * [2699] Modify Graph Edge Weights
 */

// @lc code=start
public class Solution {
    public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target) {
        Dictionary<int, int>[] maps = new Dictionary<int, int>[n];
        for (int i = 0; i < edges.Length; i++)
        {
            maps[edges[i][0]] = maps[edges[i][0]] ?? new ();
            maps[edges[i][1]] = maps[edges[i][1]] ?? new ();
            maps[edges[i][0]].Add(edges[i][1], edges[i][2]);
            maps[edges[i][1]].Add(edges[i][0], edges[i][2]);
        }
        
        int ShortestPath()
        {
            int[] dp = new int[n];
            Array.Fill(dp, int.MaxValue);
            dp[source] = 0;
            Queue<int> queue = new ();
            queue.Enqueue(source);
            int node = 0;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (node == destination)
                {
                    continue;
                }

                foreach (KeyValuePair<int, int> kv in maps[node])
                {
                    if (kv.Value < 0)
                    {
                        continue;
                    }

                    if (dp[node] + kv.Value < dp[kv.Key])
                    {
                        dp[kv.Key] = dp[node] + kv.Value;
                        queue.Enqueue(kv.Key);
                    }
                }
            }

            return dp[destination];
        }

        int shortest = ShortestPath();
        if (shortest < target)
        {
            return new int[0][];
        }

        if (shortest == target)
        {
            foreach (int[] edge in edges)
            {
                if (edge[2] < 0)
                {
                    edge[2] = target + 1;
                }
            }
            return edges;
        }

        int s = 0;

        foreach (int[] edge in edges)
        {
            if (edge[2] > 0)
            {
                continue;
            }

            edge[2] = 1;
            maps[edge[0]][edge[1]] = 1;
            maps[edge[1]][edge[0]] = 1;

            s = ShortestPath();
            if (s <= target)
            {
                edge[2] = 1 + target - s;

                foreach (int[] e in edges)
                {
                    if (e[2] < 0)
                    {
                        e[2] = target + 1;
                    }
                }

                return edges;
            }
        }

        return new int[0][];
    }
}
// @lc code=end

