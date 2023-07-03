/*
 * @lc app=leetcode id=2140 lang=csharp
 *
 * [2140] Solving Questions With Brainpower
 */

// @lc code=start
public class Solution {
    public long MostPoints(int[][] questions) {
        var dp = new long[questions.Length];
        var last = questions.Length - 1;

        dp[last] = questions[last][0];
        for (int i = questions.Length - 2; i >= 0; i--)
        {
            if (i + questions[i][1] + 1 < questions.Length)
            {
                dp[i] = Math.Max(dp[i + 1], dp[i + questions[i][1] + 1] + questions[i][0]);
            }
            else
            {
                dp[i] = Math.Max(dp[i + 1], questions[i][0]);
            }
        }

        return dp[0];
    }
}
// @lc code=end

