/*
 * @lc app=leetcode id=2017 lang=csharp
 *
 * [2017] Grid Game
 */

// @lc code=start
public class Solution {
    public long GridGame(int[][] grid) {
        long[,] dp = new long[2, grid[0].Length];
        long first = 0L,
            second = 0L;

        for (int j = 0; j < grid[0].Length; j++)
        {
            dp[0, grid[0].Length - 1 - j] = first;
            first += grid[0][grid[0].Length - 1 - j];
            dp[1, j] = second;
            second += grid[1][j];
        }

        long result = long.MaxValue;
        for (int j = 0; j < grid[0].Length; j++)
        {
            result = Math.Min(result, Math.Max(dp[0, j], dp[1, j]));
        }

        return result;
    }
}
// @lc code=end

