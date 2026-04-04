/*
 * @lc app=leetcode id=1594 lang=csharp
 *
 * [1594] Maximum Non Negative Product in a Matrix
 */

// @lc code=start
public class Solution {
    public int MaxProductPath(int[][] grid) {
        long[,,] dp = new long[grid.Length, grid[0].Length, 2];
        dp[0, 0, 0] = dp[0, 0, 1] = grid[0][0];
        for (int i = 1; i < grid.Length; i++)
        {
            dp[i, 0, 0] = dp[i, 0, 1] = dp[i - 1, 0, 0] * grid[i][0];
        }
        for (int j = 1; j < grid[0].Length; j++)
        {
            dp[0, j, 0] = dp[0, j, 1] = dp[0, j - 1, 0] * grid[0][j];
        }

        long min = 0L,
            max = 0L;
        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[0].Length; j++)
            {
                if (grid[i][j] >= 0)
                {
                    min = Math.Min(dp[i - 1, j, 0], dp[i, j - 1, 0]);
                    max = Math.Max(dp[i - 1, j, 1], dp[i, j - 1, 1]);
                }
                else
                {
                    min = Math.Max(dp[i - 1, j, 1], dp[i, j - 1, 1]);
                    max = Math.Min(dp[i - 1, j, 0], dp[i, j - 1, 0]);
                }
                dp[i, j, 0] = min * grid[i][j];
                dp[i, j, 1] = max * grid[i][j];
            }
        }

        return dp[grid.Length - 1, grid[0].Length - 1, 1] < 0 ?
            -1 :
            (int)(dp[grid.Length - 1, grid[0].Length - 1, 1] % 1_000_000_007);
    }
}
// @lc code=end

