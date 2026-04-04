/*
 * @lc app=leetcode id=3130 lang=csharp
 *
 * [3130] Find All Possible Stable Binary Arrays II
 */

// @lc code=start
public class Solution {
    public int NumberOfStableArrays(int zero, int one, int limit) {
        const long mod = 1_000_000_007L;
        long[,,] dp = new long[zero + 1, one + 1, 2];

        for (int z = Math.Min(zero, limit); z >= 0; z--)
        {
            dp[z, 0, 0] = 1L;
        }

        for (int o = Math.Min(one, limit); o >= 0; o--)
        {
            dp[0, o, 1] = 1L;
        }

        for (int z = 1; z <= zero; z++)
        {
            for (int o = 1; o <= one; o++)
            {
                dp[z, o, 0] = dp[z - 1, o, 0] + dp[z - 1, o, 1];
                if (z > limit)
                {
                    dp[z, o, 0] += mod - dp[z - limit - 1, o, 1];
                }
                dp[z, o, 0] %= mod;

                dp[z, o, 1] = dp[z, o - 1, 1] + dp[z, o - 1, 0];
                if (o > limit)
                {
                    dp[z, o, 1] += mod - dp[z, o - limit - 1, 0];
                }
                dp[z, o, 1] %= mod;
            }
        }

        return (int)((dp[zero, one, 0] + dp[zero, one, 1]) % mod);
    }
}
// @lc code=end

