/*
 * @lc app=leetcode id=1129 lang=csharp
 *
 * [1129] Shortest Path with Alternating Colors
 */

// @lc code=start
public class Solution {
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges) {
        var result = new int[n];
        Array.Fill(result, -1);
        result[0] = 0;

        var map = new IList<int>[n, 2];
        for (int i = 0; i < n; i++)
        {
            map[i, 0] = new List<int>();
            map[i, 1] = new List<int>();
        }
        foreach (var edge in redEdges)
        {
            map[edge[0], 0].Add(edge[1]);
        }
        foreach (var edge in blueEdges)
        {
            map[edge[0], 1].Add(edge[1]);
        }

        var queue = new Queue<(int, int)>();
        var visited = new bool[n, 2];
        visited[0, 1] = true;
        visited[0, 0] = true;

        var step = 1;
        queue.Enqueue((0, 0));
        queue.Enqueue((0, 1));
        while (queue.Count > 0)
        {
            var count = queue.Count;
            while (count-- > 0)
            {
                var (curr, color) = queue.Dequeue();
                foreach (var next in map[curr, color])
                {
                    if (result[next] == -1)
                    {
                        result[next] = step;
                    }

                    if (!visited[next, color])
                    {
                        visited[next, color] = true;
                        queue.Enqueue((next, color == 1 ? 0 : 1));
                    }
                }
            }

            step++;
        }

        return result;
    }
}
// @lc code=end

