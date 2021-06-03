/*
 * @lc app=leetcode id=65 lang=csharp
 *
 * [65] Valid Number
 */

// @lc code=start
public class Solution {
    public bool IsNumber(string s) {
        bool hasDigit = false,
            hasEChar = false,
            hasDot = false;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= '0' && s[i] <= '9')
                hasDigit = true;
            else if (s[i] == 'e' || s[i] == 'E')
            {
                if (hasEChar || !hasDigit)
                    return false;
                hasEChar = true;
                hasDigit = false;
            }
            else if (s[i] == '.')
            {
                if (hasEChar || hasDot)
                    return false;
                hasDot = true;
            }
            else if (s[i] == '+' || s[i] == '-')
            {
                if (i != 0 && (s[i - 1] != 'e' && s[i - 1] != 'E'))
                    return false;
            }
            else
                return false;
        }
        
        return hasDigit;
    }
}
// @lc code=end

