/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */

// @lc code=start
public class Solution {
    public void ReverseString(char[] s) {
        if (s == null || s.Length == 0) return;
        int length = s.Length - 1;
        for (int l = 0, r = length; l < r; l++, r--)
        {
            char temp = s[l];
            s[l] = s[r];
            s[r] = temp;
        }        
    }
}
// @lc code=end

