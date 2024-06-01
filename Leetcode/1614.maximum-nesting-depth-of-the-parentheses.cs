/*
 * @lc app=leetcode id=1614 lang=csharp
 *
 * [1614] Maximum Nesting Depth of the Parentheses
 */

// @lc code=start
public class Solution {
    public int MaxDepth(string s) {
        int depth = 0,
            max = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                depth++;
                max = Math.Max(max, depth);
            }
            else if (c == ')')
            {
                depth--;
            }
        }

        return max;
    }
}
// @lc code=end

