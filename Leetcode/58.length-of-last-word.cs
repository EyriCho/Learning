/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        int p = s.Length - 1;
        while (p >= 0 && s[p] == ' ')
        {
            p--;
        }

        int end = p;
        while (p >= 0 && s[p] != ' ')
        {
            p--;
        }

        return end - p;
    }
}
// @lc code=end

