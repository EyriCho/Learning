/*
 * @lc app=leetcode id=754 lang=csharp
 *
 * [754] Reach a Number
 */

// @lc code=start
public class Solution {
    public int ReachNumber(int target) {
        if (target < 0)
            target = -target;
        
        int i = 0, sum = 0;
        while (sum < target)
        {
            sum += (++i);
        }
        
        while ((sum - target & 1) > 0)
        {
            sum += (++i);
        }
        
        return i;
    }
}
// @lc code=end

