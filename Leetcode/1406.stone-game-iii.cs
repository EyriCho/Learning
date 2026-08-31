/*
 * @lc app=leetcode id=1406 lang=csharp
 *
 * [1406] Stone Game III
 */

// @lc code=start
public class Solution {
    public string StoneGameIII(int[] stoneValue) {
        int[] dp = new int[stoneValue.Length + 1];
        int stones = 0;
        for (int l = stoneValue.Length - 1; l >= 0; l--)
        {
            stones = 0;
            dp[l] = int.MinValue;

            for (int i = 0; i < 3 && l + i < stoneValue.Length; i++)
            {
                stones += stoneValue[l + i];
                dp[l] = Math.Max(dp[l],
                    stones - dp[l + i + 1]);
            }
        }

        return dp[0] > 0 ? "Alice" :
            (dp[0] == 0 ? "Tie" : "Bob");
    }
}
// @lc code=end

