/*
 * @lc app=leetcode id=32 lang=csharp
 *
 * [32] Longest Valid Parentheses
 */

// @lc code=start
public class Solution {
    public int LongestValidParentheses(string s) {
        int result = 0, l = 0, r = 0;
        for (int i = 0; i < s.Length; i++)
        {
            _ = (s[i] == '(' ? l++ : r++);
            if (l == r)
                result = Math.Max(result, 2 * r);
            else if (l < r)
                l = r = 0;
        }
        
        l = r = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            _ = (s[i] == '(' ? l++ : r++);
            if (l == r)
                result = Math.Max(result, 2 * l);
            else if (l > r)
                l = r = 0;
        }
        return result;
    }
}
// @lc code=end

