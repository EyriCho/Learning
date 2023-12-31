/*
 * @lc app=leetcode id=1155 lang=csharp
 *
 * [1155] Number of Dice Rolls With Target Sum
 */

// @lc code=start
public class Solution {
    public int NumRollsToTarget(int n, int k, int target) {
        if (n == 0)
        {
            return 0;
        }
        
        long[,] dp = new long[n + 1, target + 1];
        dp[0, 0] = 1L;
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= target; j++)
            {
                for (int roll = 1; roll <= k; roll++)
                {
                    if (j < roll)
                    {
                        break;
                    }
                    
                    dp[i, j] = (dp[i, j] + dp[i - 1, j - roll]) % 1_000_000_007;
                }
            }
        }
        
        return (int)dp[n, target];
    }
}
// @lc code=end

