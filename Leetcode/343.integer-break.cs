/*
 * @lc app=leetcode id=343 lang=csharp
 *
 * [343] Integer Break
 */

// @lc code=start
public class Solution {
    public int IntegerBreak(int n) {
        if (n < 4)
        {
            return n - 1;
        }
        
        int result = 1;
        while (n > 4)
        {
            result *= 3;
            n -= 3;
        }

        result *= n;
        return result;
    }
}
// @lc code=end

