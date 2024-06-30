/*
 * @lc app=leetcode id=409 lang=csharp
 *
 * [409] Longest Palindrome
 */

// @lc code=start
public class Solution {
    public int LongestPalindrome(string s) {
        int[] counts = new int[256];
        foreach (char c in s)
        {
            counts[c - '\0']++;
        }

        bool odd = false;
        int result = s.Length;
        for (int i = 0; i < counts.Length; i++)
        {
            if ((counts[i] & 1) > 0)
            {
                result--;
                odd = true;
            }
        }
        
        return odd ? (result + 1) : result;
    }
}
// @lc code=end

