/*
 * @lc app=leetcode id=3651 lang=csharp
 *
 * [3651] Minimum Cost Path with Teleportations
 */

// @lc code=start
public class Solution {
    public int MinCost(int[][] grid, int k) {
        int maxCost = 0;
        foreach (int[] row in grid)
        {
            foreach (int c in row)
            {
                maxCost = Math.Max(maxCost, c);
            }
        }
        int[] best = new int[maxCost + 1],
            prefix = new int[maxCost + 1];
        Array.Fill(best, int.MaxValue);
        best[grid[^1][^1]] = 0;

        int[,] dp = new int[grid.Length, grid[0].Length];
        dp[grid.Length - 1, grid[0].Length - 1] = 0;
        int cost = 0;
        for (int i = grid.Length - 1; i >= 0; i--)
        {
            for (int j = grid[0].Length - 1; j >= 0; j--)
            {
                if (i == grid.Length - 1 &&
                    j == grid[0].Length - 1)
                {
                    continue;
                }

                cost = int.MaxValue;

                if (i < grid.Length - 1)
                {
                    cost = Math.Min(cost, dp[i + 1, j] + grid[i + 1][j]);
                }
                if (j < grid[0].Length - 1)
                {
                    cost = Math.Min(cost, dp[i, j + 1] + grid[i][j + 1]);
                }

                dp[i, j] = cost;

                best[grid[i][j]] = Math.Min(best[grid[i][j]], cost);
            }
        }

        int currentMin = 0;
        while (k-- > 0)
        {
            currentMin = prefix[0] = best[0];
            for (int c = 1; c <= maxCost; c++)
            {
                currentMin = Math.Min(currentMin, best[c]);
                prefix[c] = currentMin;
            }

            for (int i = grid.Length - 1; i >= 0; i--)
            {
                for (int j = grid[0].Length - 1; j >= 0; j--)
                {
                    if (i == grid.Length - 1 &&
                        j == grid[0].Length - 1)
                    {
                        continue;
                    }

                    cost = int.MaxValue;

                    if (i < grid.Length - 1)
                    {
                        cost = Math.Min(cost, dp[i + 1, j] + grid[i + 1][j]);
                    }
                    if (j < grid[0].Length - 1)
                    {
                        cost = Math.Min(cost, dp[i, j + 1] + grid[i][j + 1]);
                    }

                    cost = Math.Min(cost, prefix[grid[i][j]]);

                    dp[i, j] = cost;

                    best[grid[i][j]] = Math.Min(best[grid[i][j]], cost);
                }
            }
        }

        return dp[0, 0];
    }
}
// @lc code=end

