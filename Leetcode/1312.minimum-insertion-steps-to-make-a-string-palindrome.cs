/*
 * @lc app=leetcode id=1312 lang=csharp
 *
 * [1312] Minimum Insertion Steps to Make a String Palindrome
 */

// @lc code=start
public class Solution {
    public int MinInsertions(string s) {
        var dp = new int[s.Length, s.Length];

        for (int i = s.Length - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    dp[i, j] = dp[i + 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Min(dp[i, j - 1], dp[i + 1, j]) + 1;
                }
            }
        }

        return dp[0, s.Length - 1];
    }
}
// @lc code=end

