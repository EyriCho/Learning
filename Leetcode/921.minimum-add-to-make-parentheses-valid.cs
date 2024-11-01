/*
 * @lc app=leetcode id=921 lang=csharp
 *
 * [921] Minimum Add to Make Parentheses Valid
 */

// @lc code=start
public class Solution {
    public int MinAddToMakeValid(string s) {
        int result = 0,
            diff = 0;
        
        foreach (char c in s)
        {
            if (c == '(')
            {
                diff++;
            }
            else
            {
                if (diff == 0)
                {
                    result++;
                }
                else
                {
                    diff--;
                }
            }
        }

        return diff + result;
    }
}
// @lc code=end

