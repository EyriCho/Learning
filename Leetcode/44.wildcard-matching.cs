/*
 * @lc app=leetcode id=44 lang=csharp
 *
 * [44] Wildcard Matching
 */

// @lc code=start
public class Solution {
    public bool IsMatch(string s, string p) {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;

        for (int j = 0; j < p.Length; j++)
        {
            if (p[j] == '*')
            {
                dp[0, j + 1] = dp[0, j];
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] == '*')
                {
                    dp[i + 1, j + 1] = dp[i, j + 1] || dp[i + 1, j];
                }
                else if (p[j] == '?' || s[i] == p[j])
                {
                    dp[i + 1, j + 1] = dp[i, j];
                }
            }
        }

        return dp[s.Length, p.Length];
    }
}
// @lc code=end

