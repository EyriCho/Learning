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
        if (k + maxPts <= n)
        {
            return 1D;
        }
        double[] dp = new double[n + 1];
        dp[0] = 1D;
        double sum = 1D, result = 0D;
        for (int i = 1; i <= n; i++)
        {
            dp[i] = sum / maxPts;
            if (i < k)
            {
                sum += dp[i];
            }
            else
            {
                result += dp[i];
            }

            if (i >= maxPts)
            {
                sum -= dp[i - maxPts];
            }
        }

        return result;
    }
}
// @lc code=end

