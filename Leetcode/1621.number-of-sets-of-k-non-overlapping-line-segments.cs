/*
 * @lc app=leetcode id=1621 lang=csharp
 *
 * [1621] Number of Sets of K Non-Overlapping Line Segments
 */

// @lc code=start
public class Solution {
    public int NumberOfSets(int n, int k) {
        int[] dp = new int[n],
            prefixSums = new int[n + 1];
        
        const int mod = 1_000_000_007;
        
        for (int j = 0; j < n; j++)
        {
            dp[j] = 1;
            prefixSums[j + 1] = (prefixSums[j] + dp[j]) % mod;
        }

        for (int i = 1; i <= k; i++)
        {
            dp[0] = 0;
            for (int j = 1; j < n; j++)
            {
                dp[j] = (dp[j - 1] + prefixSums[j]) % mod;
            }

            for (int j = 0; j < n; j++)
            {
                prefixSums[j + 1] = (prefixSums[j] + dp[j]) % mod;
            }
        }

        return dp[n - 1];
    }
}
// @lc code=end

