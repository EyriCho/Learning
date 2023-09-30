/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 */

// @lc code=start
public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        if (s.Length == 1)
        {
            return false;
        }

        for (int i = 0; i < s.Length / 2; i++)
        {
            var len = i + 1;
            if (s.Length % len != 0)
            {
                continue;
            }

            int j = len;
            for (; j < s.Length; j++)
            {
                if (s[j] != s[j % len])
                {
                    break;
                }
            }

            if (j == s.Length)
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

