/*
 * @lc app=leetcode id=72 lang=csharp
 *
 * [72] Edit Distance
 */

// @lc code=start
public class Solution {
    public int MinDistance(string word1, string word2) {
        var dp = new int[word1.Length + 1, word2.Length + 1];

        for (int i = 1; i <= word1.Length; i++)
        {
            dp[i, 0] = i;
        }

        for (int j = 1; j <= word2.Length; j++)
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= word1.Length; i++)
        {
            for (int j = 1; j <= word2.Length; j++)
            {
                var c = Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1);
                c = Math.Min(c, dp[i - 1, j - 1] + (word1[i - 1] == word2[j - 1] ? 0 : 1));
                dp[i, j] = c;
            }
        }

        return dp[word1.Length, word2.Length];
    }
}
// @lc code=end

