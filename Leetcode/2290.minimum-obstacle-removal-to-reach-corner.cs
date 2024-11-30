/*
 * @lc app=leetcode id=2290 lang=csharp
 *
 * [2290] Minimum Obstacle Removal to Reach Corner
 */

// @lc code=start
public class Solution {
    public int MinimumObstacles(int[][] grid) {
        int[,] dp = new int[grid.Length, grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                 dp[i, j] = 100_000;
            }
        }

        int[,] directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        LinkedList<(int, int, int)> list = new ();
        list.AddFirst((0, 0, grid[0][0]));
        int x = 0, y = 0,
            r = 0, c = 0,
            o = 0;

        while (list.Count > 0)
        {
            (x, y, o) = list.First.Value;
            list.RemoveFirst();

            if (dp[x, y] <= o)
            {
                continue;
            }
            dp[x, y] = o;

            for (int i = 0; i < 4; i++)
            {
                r = x + directions[i, 0];
                c = y + directions[i, 1];
                if (r >= 0 && r < grid.Length &&
                    c >= 0 && c < grid[0].Length)
                {
                    if (grid[r][c] == 0)
                    {
                        list.AddFirst((r, c, o));
                    }
                    else
                    {
                        list.AddLast((r, c, o + 1));
                    }
                }
            }
        }

        return dp[grid.Length - 1, grid[0].Length - 1];
    }
}
// @lc code=end

