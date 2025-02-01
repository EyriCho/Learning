/*
 * @lc app=leetcode id=2116 lang=csharp
 *
 * [2116] Check if a Parentheses String Can Be Valid 
 */

// @lc code=start
public class Solution {
    public bool CanBeValid(string s, string locked) {
        if (s.Length % 2 == 1)
        {
            return false;
        }

        int balance = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (locked[i] == '0' || s[i] == '(')
            {
                balance++;
            }
            else
            {
                balance--;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        balance = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (locked[i] == '0' || s[i] == ')')
            {
                balance++;
            }
            else
            {
                balance--;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

