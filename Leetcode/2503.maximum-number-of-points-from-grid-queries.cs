/*
 * @lc app=leetcode id=2503 lang=csharp
 *
 * [2503] Maximum Number of Points From Grid Queries
 */

// @lc code=start
public class Solution {
    public int[] MaxPoints(int[][] grid, int[] queries) {
        List<(int h, int c)> list = new ();
        list.Add((0, 0));
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        (int x, int y, int h) current;
        PriorityQueue<(int x, int y, int h), int> queue = new ();
        int[,] ds = new int[,] {
            { 1, 0 },
            { 0, 1 },
            { -1, 0 },
            { 0, -1 },
        };

        visited[0, 0] = true;
        queue.Enqueue((0, 0, grid[0][0]), grid[0][0]);
        int max = 0,
            count = 0,
            nx = 0,
            ny = 0;
        while (queue.Count > 0)
        {
            max = queue.Peek().h;
            while (queue.Count > 0 &&
                queue.Peek().h <= max)
            {
                count++;
                current = queue.Dequeue();

                for (int d = 0; d < 4; d++)
                {
                    nx = current.x + ds[d, 0];
                    ny = current.y + ds[d, 1];

                    if (nx >= 0 && nx < grid.Length &&
                        ny >= 0 && ny < grid[0].Length &&
                        !visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        queue.Enqueue((nx, ny, grid[nx][ny]), grid[nx][ny]);
                    }
                }
            }
            list.Add((max, count));
        }

        int[] result = new int[queries.Length];
        int l = 0,
            m = 0,
            r = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            l = 0;
            r = list.Count;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (list[m].h >= queries[i])
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            result[i] = list[l - 1].c;
        }

        return result;
    }
}
// @lc code=end

