/*
 * @lc app=leetcode id=409 lang=csharp
 *
 * [409] Longest Palindrome
 */

// @lc code=start
public class Solution {
    public int LongestPalindrome(string s) {
        var array = new int[52];
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
                array[c - 'a' + 26]++;
            if (c >= 'A' && c <= 'Z')
                array[c - 'A']++;
        }
        bool hasSingle = false;
        int result = 0;
        for (int i = 0; i < 52; i++)
        {
            if ((array[i] & 1) == 1)
            {
                hasSingle = true;
                array[i]--;
            }
            result += array[i];
        }
        return hasSingle ? result + 1 : result;
    }
}
// @lc code=end

