/*
 * @lc app=leetcode id=1639 lang=csharp
 *
 * [1639] Number of Ways to Form a Target String Given a Dictionary
 */

// @lc code=start
public class Solution {
    public int NumWays(string[] words, string target) {
        if (target.Length > words[0].Length)
        {
            return 0;
        }

        int[,] counts = new int[26, words[0].Length];
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                counts[words[i][j] - 'a', j]++;
            }
        }

        long[,] dp = new long[target.Length, words[0].Length];
        dp[0, 0] = counts[target[0] - 'a', 0];
        for (int j = 1; j < words[0].Length; j++)
        {
            dp[0, j] = dp[0, j - 1] + counts[target[0] - 'a', j];
        }

        for (int i = 1; i < target.Length; i++)
        {
            for (int j = i; j < words[0].Length; j++)
            {
                dp[i, j] = (dp[i, j - 1] + dp[i - 1, j - 1] * counts[target[i] - 'a', j]) % 1_000_000_007;
            }
        }

        return (int)dp[target.Length - 1, words[0].Length - 1];
    }
}
// @lc code=end

