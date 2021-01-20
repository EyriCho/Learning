/*
 * @lc app=leetcode id=741 lang=csharp
 *
 * [741] Cherry Pickup
 */

// @lc code=start
public class Solution {
    public int CherryPickup(int[][] grid) {
        int[][][] dp = new int[grid.Length][][];
        for (int i = 0; i < grid.Length; i++)
        {
            dp[i] = new int[grid[0].Length][];
            for (int j = 0; j < grid[0].Length; j++)
            {
                dp[i][j] = new int[grid[0].Length];
            }
        }
        
        for (int i = grid.Length - 1; i >= 0; i--)
        {
            int j1 = Math.Min(i, grid[0].Length - 1);
            int k1 = Math.Max(0, grid[0].Length - i - 1);
            for (int j = 0; j <= j1; j++)
            {
                for (int k = grid[0].Length - 1; k >= k1; k--)
                {
                    dp[i][j][k] = grid[i][j];
                    if (j != k)
                        dp[i][j][k] += grid[i][k];
                    
                    if (i < grid.Length - 1)
                    {
                        int jmin = Math.Max(j - 1, 0);
                        int kmin = Math.Max(k - 1, 0);
                        int jmax = Math.Min(j + 1, grid[0].Length - 1);
                        int kmax = Math.Min(k + 1, grid[0].Length - 1);
                        
                        int max = 0;
                        for (; jmin <= jmax; jmin++)
                            for (int temp = kmin; temp <= kmax; temp++)
                                max = Math.Max(max, dp[i + 1][jmin][temp]);
                        dp[i][j][k] += max;
                    }
                }
            }
            
        }
        
        return dp[0][0][grid[0].Length - 1];
    }
}
// @lc code=end

