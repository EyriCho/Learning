/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */

// @lc code=start
public class Solution {
    public void ReverseString(char[] s) {
        int l = 0,
            r = s.Length - 1;
        char temp = '\0';

        while (l < r)
        {
            temp = s[l];
            s[l++] = s[r];
            s[r--] = temp;
        }
    }
}
// @lc code=end

