/*
 * @lc app=leetcode id=516 lang=csharp
 *
 * [516] Longest Palindromic Subsequence
 */

// @lc code=start
public class Solution {
    public int LongestPalindromeSubseq(string s) {
        var dp = new int[s.Length];

        for (int r = 0; r < s.Length; r++)
        {
            dp[r] = 1;
            var topRight = 0;

            for (int l = r - 1; l >= 0; l--)
            {
                var temp = dp[l];
                if (s[l] == s[r])
                {
                    dp[l] = topRight + 2;
                }
                else
                {
                    dp[l] = Math.Max(dp[l], dp[l + 1]);
                }
                topRight = temp;
            }
        }

        return dp[0];
    }
}
// @lc code=end

