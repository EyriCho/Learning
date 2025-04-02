/*
 * @lc app=leetcode id=2140 lang=csharp
 *
 * [2140] Solving Questions With Brainpower
 */

// @lc code=start
public class Solution {
    public long MostPoints(int[][] questions) {
        long[] dp = new long[questions.Length];
        dp[^1] = questions[^1][0];

        int nextBrain = 0;
        for (int i = questions.Length - 2; i >= 0; i--)
        {
            nextBrain = i + questions[i][1] + 1;
            dp[i] = Math.Max(dp[i + 1], (nextBrain < dp.Length ? dp[nextBrain] : 0L) + questions[i][0]);
        }

        return dp[0];
    }
}
// @lc code=end

