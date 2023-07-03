/*
 * @lc app=leetcode id=2328 lang=csharp
 *
 * [2328] Number of Increasing Paths in a Grid
 */

// @lc code=start
public class Solution {
    public int CountPaths(int[][] grid) {
        var dp = new int[grid.Length, grid[0].Length];
        var directions = new int[,] {
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
            { 0, 1 },
        };

        var result = 0;
        int Dfs(int x, int y)
        {
            if (dp[x, y] != 0)
            {
                return dp[x, y];
            }

            dp[x, y] = 1;

            for (int i = 0; i < 4; i++)
            {
                int dx = x + directions[i, 0],
                    dy = y + directions[i, 1];
                
                if (0 <= dx && dx < grid.Length &&
                    0 <= dy && dy < grid[0].Length &&
                    grid[x][y] < grid[dx][dy])
                {
                    dp[x, y] = (dp[x, y] + Dfs(dx, dy)) % 1_000_000_007;
                }
            }

            result = (result + dp[x, y]) % 1_000_000_007;
            return dp[x, y];
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (dp[i, j] == 0)
                {
                    Dfs(i, j);
                }
            }
        }

        return result;
    }
}
// @lc code=end

