/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public class Solution {
    public int ClimbStairs(int n) {
        if (n < 4) return n;
        int prevByTwo = 2, prev = 3, result = 5;
        for (int i = 3; i < n; i++)
        {
            result = prevByTwo + prev;
            prevByTwo = prev;
            prev = result;
        }
        return result;        
    }
}
// @lc code=end

