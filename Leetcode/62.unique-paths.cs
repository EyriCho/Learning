/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start
public class Solution {
    public int UniquePaths(int m, int n) {
        dp[m - 1, n - 1] = 1;
        for (int i = m - 1; i > -1; i--)
            for (int j = n - 1; j > -1; j--)
            {
                if (i > 0)
                    dp[i - 1, j] += dp[i, j];
                if (j > 0)
                    dp[i, j - 1] += dp[i, j];
            }
        
        return dp[0, 0];
    }
}
// @lc code=end

