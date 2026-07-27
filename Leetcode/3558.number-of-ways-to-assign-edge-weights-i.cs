/*
 * @lc app=leetcode id=3558 lang=csharp
 *
 * [3558] Number of Ways to Assign Edge Weights I
 */

// @lc code=start
public class Solution {
    public int AssignEdgeWeights(int[][] edges) {
        List<int>[] maps = new List<int>[edges.Length + 2];
        foreach (int[] edge in edges)
        {
            if (maps[edge[0]] == null)
            {
                maps[edge[0]] = new ();
            }
            if (maps[edge[1]] == null)
            {
                maps[edge[1]] = new ();
            }
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        bool[] visited = new bool[maps.Length];
        int length = -1,
            count = 0,
            node = 0;
        Queue<int> queue = new ();
        queue.Enqueue(1);
        while (queue.Count > 0)
        {
            count = queue.Count;
            while (count-- > 0)
            {
                node = queue.Dequeue();
                visited[node] = true;

                foreach (int next in maps[node])
                {
                    if (visited[next])
                    {
                        continue;
                    }

                    queue.Enqueue(next);
                }
            }

            length++;
        }
        length--;

        long result = 1L,
            basement = 2L;
        while (length > 0)
        {
            if ((length & 1) == 1)
            {
                result = result * basement % 1_000_000_007L;
            }

            basement = basement * basement % 1_000_000_007L;
            length >>= 1;
        }

        return (int)result;
    }
}
// @lc code=end

