/*
 * @lc app=leetcode id=1784 lang=csharp
 *
 * [1784] Check if Binary String Has at Most One Segment of Ones
 */

// @lc code=start
public class Solution {
    public bool CheckOnesSegment(string s) {
        int i = 0;
        while (i < s.Length && s[i] == '1')
        {
            i++;
        }

        while (i < s.Length && s[i] == '0')
        {
            i++;
        }

        return i == s.Length;
    }
}
// @lc code=end

