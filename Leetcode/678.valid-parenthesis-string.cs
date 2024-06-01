/*
 * @lc app=leetcode id=678 lang=csharp
 *
 * [678] Valid Parenthesis String
 */

// @lc code=start
public class Solution {
    public bool CheckValidString(string s) {
        // state machine
        int low = 0,
            high = 0;
        
        foreach (char c in s)
        {
            low += c == '(' ? 1 : -1;
            high += c != ')' ? 1 : -1;
            if (high < 0)
            {
                return false;
            }
            low = Math.Max(0, low);
        }

        return low == 0;
    }
}
// @lc code=end

