/*
 * @lc app=leetcode id=790 lang=csharp
 *
 * [790] Domino and Tromino Tiling
 */

// @lc code=start
public class Solution {
    public int NumTilings(int n) {
        if (n < 3)
        {
            return n;
        }
        long[] dp = new long[n + 1];
        dp[1] = 1L;
        dp[2] = 2L;
        dp[3] = 5L;
        for (int i = 4; i <= n; i++)
        {
            dp[i] = (dp[i - 1] * 2 + dp[i - 3]) % 1_000_000_007L;
        }

        return (int)dp[n];
    }
}
// @lc code=end

