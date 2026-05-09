/*
 * @lc app=leetcode id=1320 lang=csharp
 *
 * [1320] Minimum Distance to Type a Word Using Two Fingers
 */

// @lc code=start
public class Solution {
    public int MinimumDistance(string word) {
        int Distance(int idx1, int idx2)
        {
            return Math.Abs(idx1 / 6 - idx2 / 6) + Math.Abs(idx1 % 6 - idx2 % 6);
        }

        int[,,] dp = new int[word.Length + 1, 26, 26];
        int idx = 0;
        for (int i = 1; i <= word.Length; i++)
        {
            idx = word[i - 1] - 'A';
            for (int l = 0; l < 26; l++)
            {
                for (int r = 0; r < 26; r++)
                {
                    dp[i, l, r] = 1_000_000_000;
                }
            }

            for (int l = 0; l < 26; l++)
            {
                for (int r = 0; r < 26; r++)
                {
                    dp[i, l, idx] = Math.Min(dp[i, l, idx], dp[i - 1, l, r] + Distance(r, idx));
                    dp[i, idx, r] = Math.Min(dp[i, idx, r], dp[i - 1, l, r] + Distance(l, idx));
                }
            }
        }

        int result = 1_000_000_000;
        for (int l = 0; l < 26; l++)
        {
            for (int r = 0; r < 26; r++)
            {
                result = Math.Min(result, dp[word.Length, l, r]);
            }
        }
        return result;
    }
}
// @lc code=end

