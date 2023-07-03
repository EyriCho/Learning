/*
 * @lc app=leetcode id=837 lang=csharp
 *
 * [837] New 21 Game
 */

// @lc code=start
public class Solution {
    public double New21Game(int n, int k, int maxPts) {
        if (k == 0)
        {
            return 1D;
        }
        if (k - 1 + maxPts <= n)
        {
            return 1D;
        }

        var dp = new double[k + maxPts];
        dp[0] = 1D;

        for (int i = 1; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1];
            if (i <= maxPts)
            {
                dp[i] += dp[i - 1] / maxPts;
            }
            else
            {
                dp[i] += (dp[i - 1] - dp[i - 1 - maxPts]) / maxPts;
            }

            if (i > k)
            {
                dp[i] -= (dp[i - 1] - dp[k - 1]) / maxPts;
            }
        }

        return dp[n] - dp[k - 1];
    }
}
// @lc code=end

