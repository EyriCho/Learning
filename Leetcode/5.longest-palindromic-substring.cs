/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution {
    public string LongestPalindrome(string s) {
        int left = 0, right = 0,
            start = 0, maxLength = 0, i = 0;
        
        while (i < s.Length)
        {
            left = i - 1;
            right = i + 1;
            while (right < s.Length && s[right] == s[i])
            {
                right++;
            }
            i = right;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            if (maxLength < right - left - 1)
            {
                maxLength = right - left -1;
                start = left + 1;
            }
        }
        
        return s[start..(start + maxLength)];
    }
}
// @lc code=end

