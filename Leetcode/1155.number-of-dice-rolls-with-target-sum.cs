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
        
        var dp = new long[n + 1, target + 1];
        
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= target; j++)
            {
                if (i == 0 && j == 0)
                {
                    dp[i, j] = 1L;
                }
                else
                {
                    for (int roll = 1; roll <= k; roll++)
                    {
                        if (i - 1 >= 0 && j - roll >= 0)
                        {
                            dp[i, j] = (dp[i, j] + dp[i - 1, j - roll]) % 1_000_000_007;
                        }
                    }
                }
            }
        }
        
        return (int)dp[n, target];
    }
}
// @lc code=end

