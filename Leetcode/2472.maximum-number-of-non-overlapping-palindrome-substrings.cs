/*
 * @lc app=leetcode id=2472 lang=csharp
 *
 * [2472] Maximum Number of Non-overlapping Palindrome Substrings
 */

// @lc code=start
public class Solution {
    public int MaxPalindromes(string s, int k) {
        if (k == 1)
        {
            return s.Length;
        }

        bool IsPalindrome(string str)
        {
            int l = 0, r = str.Length - 1;
            while (l < r)
            {
                if (str[l++] != str[r--])
                {
                    return false;
                }
            }

            return true;
        }

        int result = 0;
        for (int i = 0; i <= s.Length - k;)
        {
            if (IsPalindrome(s[i..(i + k)]))
            {
                result++;
                i += k;
            }
            else if (i < s.Length - k && IsPalindrome(s[i..(i + k + 1)]))
            {
                result++;
                i += k + 1;
            }
            else
            {
                i++;
            }
        }

        return result;
    }
}
// @lc code=end

