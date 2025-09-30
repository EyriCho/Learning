/*
 * @lc app=leetcode id=2327 lang=csharp
 *
 * [2327] Number of People Aware of a Secret
 */

// @lc code=start
public class Solution {
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        const long mod = 1_000_000_007L;
        long teller = 0;
        long[] dp = new long[n + 1];
        dp[1] = 1L;
        for (int d = 2; d <= n; d++)
        {
            if (d > delay)
            {
                teller = (teller + dp[d - delay] + mod) % mod;
            }
            if (d > forget)
            {
                teller = (teller - dp[d - forget] + mod) % mod;
            }
            dp[d] = teller;
        }
        long result = 0L;
        for (int d = n - forget + 1; d <= n; d++)
        {
            result = (result + dp[d]) % mod;
        }
        return (int)result;
    }
}
// @lc code=end

