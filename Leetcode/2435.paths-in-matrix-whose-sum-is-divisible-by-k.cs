/*
 * @lc app=leetcode id=2435 lang=csharp
 *
 * [2435] Paths in Matrix Whose Sum Is Divisible by K
 */

// @lc code=start
public class Solution {
    public int NumberOfPaths(int[][] grid, int k) {
        const int mod = 1_000_000_007;
        int[,,] dp = new int[grid.Length, grid[0].Length, k];
        int left = grid[0][0] % k;
        dp[0, 0, left] = 1;
        for (int j = 1; j < grid[0].Length; j++)
        {
            left = (left + grid[0][j]) % k;
            dp[0, j, left] = 1;
        }

        left = grid[0][0] % k;
        for (int i = 1; i < grid.Length; i++)
        {
            left = (left + grid[i][0]) % k;
            dp[i, 0, left] = 1;
        }

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1 ; j < grid[0].Length; j++)
            {
                for (int l = 0; l < k; l++)
                {
                    left = (grid[i][j] + l) % k;
                    if (dp[i - 1, j, l] > 0)
                    {
                        dp[i, j, left] = (dp[i, j, left] + dp[i - 1, j, l]) % mod;
                    }

                    if (dp[i, j - 1, l] > 0)
                    {
                        dp[i, j, left] = (dp[i, j, left] + dp[i, j - 1, l]) % mod;
                    }
                }
            }
        }

        return dp[grid.Length - 1, grid[0].Length - 1, 0];
    }
}
// @lc code=end

