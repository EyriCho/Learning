/*
 * @lc app=leetcode id=790 lang=csharp
 *
 * [790] Domino and Tromino Tiling
 */

// @lc code=start
public class Solution {
    public int NumTilings(int n) {
        if (n < 3)
            return n;
        var dp = new long[n + 1];
        const int mod = 1_000_000_007;
        
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 5;
        for (int i = 4; i <= n; i++)
            dp[i] = (dp[i - 1] * 2 + dp[i - 3]) % mod;
        
        return (int)dp[n];
    }
}
// @lc code=end

