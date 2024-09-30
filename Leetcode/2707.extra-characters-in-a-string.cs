/*
 * @lc app=leetcode id=2707 lang=csharp
 *
 * [2707] Extra Characters in a string
 */

// @lc code=start
public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        int[] dp = new int[s.Length + 1];
        for (int i = 1; i <= s.Length; i++)
        {
            dp[i] = dp[i - 1] + 1;
            foreach (string word in dictionary)
            {
                if (i >= word.Length &&
                    s[(i - word.Length)..i] == word)
                {
                    dp[i] = Math.Min(dp[i], dp[i - word.Length]);
                }
            }
        }
        return dp[s.Length];
    }
}
// @lc code=end

