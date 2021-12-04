/*
 * @lc app=leetcode id=279 lang=csharp
 *
 * [279] Perfect Squares
 */

// @lc code=start
public class Solution {
    public int NumSquares(int n) {
        var dp = new int[n + 1];
        Array.Fill(dp, n);
        dp[0] = 0;
        
        for (int s = 1; s < 101; s++)
        {
            var square = s * s;
            if (square > n)
                break;

            for (int i = square; i <= n; i++)
                dp[i] = Math.Min(dp[i - square] + 1, dp[i]);
        }
        
        return dp[n];
    }
}
// @lc code=end

