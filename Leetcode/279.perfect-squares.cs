/*
 * @lc app=leetcode id=279 lang=csharp
 *
 * [279] Perfect Squares
 */

// @lc code=start
public class Solution {
    public int NumSquares(int n) {
        int[] dp = new int[n + 1];
        Array.Fill(dp, n);
        dp[0] = 0;

        int square = 0;
        for (int i = 1; i < 101; i++)
        {
            square = i * i;
            if (square > n)
            {
                break;
            }
            
            for (int j = square; j <= n; j++)
            {
                dp[j] = Math.Min(dp[j], dp[j - square] + 1);
            }
        }

        return dp[n];
    }
}
// @lc code=end

