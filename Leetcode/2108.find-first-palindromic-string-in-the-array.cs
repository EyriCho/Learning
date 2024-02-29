/*
 * @lc app=leetcode id=2108 lang=csharp
 *
 * [2108] Find First Palindromic String in the Array
 */

// @lc code=start
public class Solution {
    public string FirstPalindrome(string[] words) {
        bool IsPalindrome(string w)
        {
            int l = 0,
                r = w.Length - 1;

            while (l < r)
            {
                if (w[l++] != w[r--])
                {
                    return false;
                }
            }

            return true;
        }

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                return word;
            }
        }

        return string.Empty;
    }
}
// @lc code=end

