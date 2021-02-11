/*
 * @lc app=leetcode id=1680 lang=csharp
 *
 * [1680] Concatenation of Consecutive Binary Numbers
 */

// @lc code=start
public class Solution {
    public int ConcatenatedBinary(int n) {
        long result = 0;
        
        int mul = 2, len = 1;
        
        for (int i = 1; i <= n; i++)
        { 
            if (i == mul)
            {
                mul <<= 1;
                len++;
            }
            
            result = ((result << len) + i) % 1_000_000_007;
        }
        
        return (int)result;
    }
}
// @lc code=end

