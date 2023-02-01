/*
 * @lc app=leetcode id=2359 lang=csharp
 *
 * [2359] Find Closest Node To Given Two Nodes
 */

// @lc code=start
public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int[] dist1 = new int[edges.Length],
            dist2 = new int[edges.Length];
        Array.Fill(dist1, -1);
        Array.Fill(dist2, -1);
        dist1[node1] = 0;
        dist2[node2] = 0;

        void bfs(int node, int[] dist)
        {
            var queue = new Queue<int>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var n = queue.Dequeue();
                if (edges[n] > -1)
                {
                    if (dist[edges[n]] < 0)
                    {
                        dist[edges[n]] = dist[n] + 1;
                        queue.Enqueue(edges[n]);
                    }
                }
            }
        }

        bfs(node1, dist1);
        bfs(node2, dist2);

        int min = int.MaxValue,
            result = -1;

        for (int i = 0; i < edges.Length; i++)
        {
            if (dist1[i] > -1 && dist2[i] > -1)
            {
                var max = Math.Max(dist1[i], dist2[i]);
                if (max > -1 && max < min)
                {
                    min = max;
                    result = i;
                }
            }

            Console.WriteLine($"{dist1[i]}, {dist2[i]}");
        }

        return result;
    }
}
// @lc code=end

