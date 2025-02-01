/*
 * @lc app=leetcode id=1930 lang=csharp
 *
 * [1930] Unique Length-3 Palindromic Subsequences
 */

// @lc code=start
public class Solution {
    public int CountPalindromicSubsequence(string s) {
        bool[] middles = new bool[26];
        int result = 0,
            l = 0,
            r = 0,
            m = 0;

        for (char c = 'a'; c <= 'z'; c++)
        {
            l = 0;
            r = s.Length - 1;

            while (l < s.Length && s[l] != c)
            {
                l++;
            }
            while (r >= 0 && s[r] != c)
            {
                r--;
            }

            if (l + 1 >= r)
            {
                continue;
            }

            Array.Fill(middles, false);
            m = l;
            while (++m < r)
            {
                if (!middles[s[m] - 'a'])
                {
                    result++;
                    middles[s[m] - 'a'] = true;
                }
            }
        }

        return result;
    }
}
// @lc code=end

