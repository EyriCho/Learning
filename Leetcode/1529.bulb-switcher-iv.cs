/*
 * @lc app=leetcode id=1529 lang=csharp
 *
 * [1529] Bulb Switcher IV
 */

// @lc code=start
public class Solution {
    public int MinFlips(string target) {
        int i = 0, result = 0;
        
        char c = '0';
        while (i < target.Length)
        {
            if (c != target[i])
            {
                c = target[i];
                result++;
            }
                
            i++;
        }
        return result;        
    }
}
// @lc code=end

