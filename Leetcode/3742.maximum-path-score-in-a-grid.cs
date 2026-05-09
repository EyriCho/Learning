/*
 * @lc app=leetcode id=3742 lang=csharp
 *
 * [3742] Maximum Path Score in a Grid
 */

// @lc code=start
public class Solution {
    public int MaxPathScore(int[][] grid, int k) {
        int[,,] dp = new int[grid.Length, grid[0].Length, k + 1];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                for (int c = 0; c <= k; c++)
                {
                    dp[i, j, c] = int.MinValue;
                }
            }
        }

        dp[0, 0, 0] = 0;
        
        int cost = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                for (int c = 0; c <= k; c++)
                {
                    if (dp[i, j, c] == int.MinValue)
                    {
                        continue;
                    }

                    if (i + 1 < grid.Length)
                    {
                        cost = grid[i + 1][j] == 0 ? 0 : 1;
                        if (c + cost <= k)
                        {
                            dp[i + 1, j, c + cost] = Math.Max(
                                dp[i + 1, j, c + cost],
                                dp[i, j, c] + grid[i + 1][j]
                            );
                        }
                    }

                    if (j + 1 < grid[0].Length)
                    {
                        cost = grid[i][j + 1] == 0 ? 0 : 1;
                        if (c + cost <= k)
                        {
                            dp[i, j + 1, c + cost] = Math.Max(
                                dp[i, j + 1, c + cost],
                                dp[i, j, c] + grid[i][j + 1]
                            );
                        }
                    }
                }
            }
        }

        int result = -1;
        for (int c = 0; c <= k; c++)
        {
            result = Math.Max(result, dp[grid.Length - 1, grid[0].Length - 1, c]);
        }

        return result;
    }
}
// @lc code=end

