/*
 * @lc app=leetcode id=1406 lang=csharp
 *
 * [1406] Stone Game III
 */

// @lc code=start
public class Solution {
    public string StoneGameIII(int[] stoneValue) {
        var dp = new int[stoneValue.Length + 1];

        for (int i = stoneValue.Length - 1; i >= 0; i--)
        {
            var stones = 0;
            dp[i] = int.MinValue;

            for (int j = 0; j < 3 && i + j < stoneValue.Length; j++)
            {
                stones += stoneValue[i + j];
                dp[i] = Math.Max(dp[i], stones - dp[i + j + 1]);
            }
        }

        if (dp[0] > 0)
        {
            return "Alice";
        }
        else if (dp[0] < 0)
        {
            return "Bob";
        }
        else
        {
            return "Tie";
        }
    }
}
// @lc code=end

