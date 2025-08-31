/*
 * @lc app=leetcode id=2787 lang=csharp
 *
 * [2787] Ways to Express an Integer as Sum of Powers
 */

// @lc code=start
public class Solution {
    public int NumberOfWays(int n, int x) {
        int[] dp = new int[n + 1];
        dp[0] = 1;
        int power = 0;
        for (int i = 1; i <= n; i++)
        {
            power = (int)Math.Pow(i, x);
            if (power > n)
            {
                break;
            }

            for (int j = n; j >= power; j--)
            {
                dp[j] = (dp[j] + dp[j - power]) % 1_000_000_007;
            }
        }

        return dp[n];
    }
}
// @lc code=end

