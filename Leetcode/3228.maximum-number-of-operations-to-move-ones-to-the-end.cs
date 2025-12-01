/*
 * @lc app=leetcode id=3228 lang=csharp
 *
 * [3228] Maximum Number of Operations to Move Ones to the End
 */

// @lc code=start
public class Solution {
    public int MaxOperations(string s) {
        int ones = 0,
            result = 0,
            i = 0;
        
        while (i < s.Length)
        {
            if (s[i] == '1')
            {
                ones++;
            }
            else if (i > 0 && s[i - 1] != '0')
            {
                
                result += ones;
            }
            i++;
        }

        return result;
    }
}
// @lc code=end

