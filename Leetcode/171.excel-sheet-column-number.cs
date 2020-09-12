/*
 * @lc app=leetcode id=171 lang=csharp
 *
 * [171] Excel Sheet Column Number
 */

// @lc code=start
public class Solution {
    public int TitleToNumber(string s) {
        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var current = s[i] - 'A' + 1;
            result = result * 26 + current;
        }
        return result;
    }
}
// @lc code=end

