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

        void Bfs(int[] dist, int node)
        {
            while (node != -1)
            {
                if (edges[node] == -1)
                {
                    break;;
                }

                if (dist[edges[node]] > -1)
                {
                    break;
                }

                dist[edges[node]] = dist[node] + 1;
                node = edges[node];
            }
        }

        Bfs(dist1, node1);
        Bfs(dist2, node2);

        int min = edges.Length,
            max = 0,
            result = -1;

        for (int i = 0; i < edges.Length; i++)
        {
            if (dist1[i] == -1 || dist2[i] == -1)
            {
                continue;
            }

            max = Math.Max(dist1[i], dist2[i]);
            if (max < min)
            {
                min = max;
                result = i;
            }
        }

        return result;
    }
}
// @lc code=end

