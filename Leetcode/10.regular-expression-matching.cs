/*
 * @lc app=leetcode id=10 lang=csharp
 *
 * [10] Regular Expression Matching
 */

// @lc code=start
public class Solution {
    public bool IsMatch(string s, string p) {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[s.Length, p.Length] = true;

        for (int i = s.Length; i >= 0; i--)
        {
            for (int j = p.Length - 1; j >= 0; j--)
            {
                bool charMatch = i < s.Length && (p[j] == '.' || s[i] == p[j]);
                if (j + 1 < p.Length && p[j + 1] == '*')
                {
                    dp[i, j] = dp[i, j + 2] 
                        || charMatch && dp[i + 1, j];
                }
                else
                {
                    dp[i, j] = charMatch && dp[i + 1, j + 1];
                }
            }
        }

        return dp[0, 0];
    }
}
// @lc code=end

