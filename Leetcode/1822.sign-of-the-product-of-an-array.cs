/*
 * @lc app=leetcode id=1822 lang=csharp
 *
 * [1822] Sign of the Product of an Array
 */

// @lc code=start
public class Solution {
    public int ArraySign(int[] nums) {
        var production = 1;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                return 0;
            }
            
            if (num < 0)
            {
                production *= -1;
            }
        }

        return production;
    }
}
// @lc code=end

