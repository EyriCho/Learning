/*
 * @lc app=leetcode id=583 lang=csharp
 *
 * [583] Delete Operation for Two Strings
 */

// @lc code=start
public class Solution {
    public int MinDistance(string word1, string word2) {
        var dp = new int[word1.Length + 1, word2.Length + 1];
        
        for (int i = 1; i <= word1.Length; i++)
            for (int j = 1; j <= word2.Length; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        
        return word1.Length + word2.Length - 2 * dp[word1.Length, word2.Length];
    }
}
// @lc code=end

