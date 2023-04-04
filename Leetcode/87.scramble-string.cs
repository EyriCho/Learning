/*
 * @lc app=leetcode id=87 lang=csharp
 *
 * [87] Scramble String
 */

// @lc code=start
public class Solution {
    public bool IsScramble(string s1, string s2) {
        if (s1 == s2)
        {
            return true;
        }

        var chars = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            chars[s1[i] - 'a']++;
            chars[s2[i] - 'a']--;
        }

        for (int i = 0; i < 26; i++)
        {
            if (chars[i] != 0)
            {
                return false;
            }
        }

        var dp = new bool[s1.Length + 1, s1.Length, s1.Length];

        for (int len = 1; len <= s1.Length; len++)
        {
            for (int i = 0; i + len <= s1.Length; i++)
            {
                for (int j = 0; j + len <= s1.Length; j++)
                {
                    if (len == 1)
                    {
                        dp[len, i, j] = s1[i] == s2[j];
                    }
                    else
                    {
                        for (int q = 1; q < len; q++)
                        {
                            dp[len, i, j] = (dp[q, i, j] && dp[len - q, i + q, j + q]) ||
                                (dp[q, i, j + len - q] && dp[len - q, i + q, j]);

                            if (dp[len, i, j])
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        return dp[s1.Length, 0, 0];
    }
}
// @lc code=end

