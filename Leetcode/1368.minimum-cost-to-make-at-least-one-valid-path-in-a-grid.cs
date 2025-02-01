/*
 * @lc app=leetcode id=1368 lang=csharp
 *
 * [1368] Minimum Cost to Make at Least One Valid Path in a Grid
 */

// @lc code=start
public class Solution {
    public int MinCost(int[][] grid) {
        int[,] costs = new int[grid.Length, grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                costs[i, j] = int.MaxValue;
            }
        }

        PriorityQueue<(int, int, int), int> queue = new ();
        queue.Enqueue((0, 0, 0), 0);
        costs[0, 0] = 0;

        int x = 0,
            y = 0,
            c = 0,
            nx = 0,
            ny = 0,
            nc = 0;

        int[,] ds = new int[,] {
            { 0, 1 },
            { 0, -1 },
            { 1, 0 },
            { -1, 0 },
        };

        while (queue.Count > 0)
        {
            (x, y, c) = queue.Dequeue();

            if (x == grid.Length - 1 && y == grid[0].Length - 1)
            {
                return c;
            }

            costs[x, y] = c;

            for (int i = 1; i <= 4; i++)
            {
                nx = x + ds[i - 1, 0];
                ny = y + ds[i - 1, 1];

                if (nx >= 0 && nx < grid.Length &&
                    ny >= 0 && ny < grid[0].Length)
                {
                    nc = c + (i == grid[x][y] ? 0 : 1);
                    if (nc < costs[nx, ny])
                    {
                        costs[nx, ny] = nc;
                        queue.Enqueue((nx, ny, nc), nc);
                    }
                }
            }
        }

        return costs[grid.Length - 1, grid[0].Length - 1];
    }
}
// @lc code=end

