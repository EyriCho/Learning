/*
 * @lc app=leetcode id=1335 lang=csharp
 *
 * [1335] Minimum Difficulty of a Job Schedule
 */

// @lc code=start
public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        if (d > jobDifficulty.Length)
        {
            return -1;
        }
        
        var dp = new int[d + 1, jobDifficulty.Length + 1];
        for (int j = 0; j < jobDifficulty.Length; j++)
        {
            dp[1, j + 1] = Math.Max(dp[1, j], jobDifficulty[j]);
        }
        
        for (int i = 1; i < d; i++)
        {
            for (int k = i + 1; k <= jobDifficulty.Length; k++)
            {
                int max = int.MinValue;
                for (int l = k - 1; l >= i; l--)
                {
                    max = Math.Max(max, jobDifficulty[l]);
                    
                    if (dp[i + 1, k] == 0)
                    {
                        dp[i + 1, k] = dp[i, l] + max;
                    }
                    else
                    {
                        dp[i + 1, k] = Math.Min(dp[i + 1, k], dp[i, l] + max);
                    }
                }
            }
        }
        
        return dp[d, jobDifficulty.Length];
    }
}
// @lc code=end

