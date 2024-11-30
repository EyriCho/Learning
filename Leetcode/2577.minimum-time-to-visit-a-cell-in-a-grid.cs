/*
 * @lc app=leetcode id=2577 lang=csharp
 *
 * [2577] Minimum Time to Visit a Cell In a Grid
 */

// @lc code=start
public class Solution {
    public int MinimumTime(int[][] grid) {
        if (grid[0][1] > 1 && grid[1][0] > 1)
        {
            return -1;
        }

        bool[,] visited = new bool[grid.Length, grid[0].Length];
        visited[0, 0] = true;
        
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        PriorityQueue<(int, int, int), int> queue = new();
        queue.Enqueue((0, 0, 0), 0);
        int x = 0, y = 0,
            r = 0, c = 0,
            t = 0, time = 0;
        while (queue.Count > 0)
        {
            (x, y, t) = queue.Dequeue();
            
            for (int i = 0; i < 4; i++)
            {
                r = x + ds[i, 0];
                c = y + ds[i, 1];

                if (r < 0 || r >= grid.Length ||
                    c < 0 || c >= grid[0].Length ||
                    visited[r, c])
                {
                    continue;
                }

                time = t + 1;
                if (time < grid[r][c])
                {
                    time += (grid[r][c] - t) >> 1 << 1;
                }

                if (r == grid.Length - 1 &&
                    c == grid[0].Length - 1)
                {
                    return time;
                }

                visited[r, c] = true;
                queue.Enqueue((r, c, time), time);
            }
        }

        return -1;
    }
}
// @lc code=end

