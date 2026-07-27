/*
 * @lc app=leetcode id=628 lang=csharp
 *
 * [628] Maximum Product of Three Numbers
 */

// @lc code=start
public class Solution {
    public int MaximumProduct(int[] nums) {
        int max1 = -1_000, max2 = -1_000, max3 = -1_000,
            min1 = 1_000, min2 = 1_000;
        
        foreach (int num in nums)
        {
            if (num > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (num > max2)
            {
                max3 = max2;
                max2 = num;
            }
            else if (num > max3)
            {
                max3 = num;
            }

            if (num < min1)
            {
                min2 = min1;
                min1 = num;
            }
            else if (num < min2)
            {
                min2 = num;
            }
        }

        return Math.Max(
            max1 * max2 * max3,
            min1 * min2 * max1
        );
    }
}
// @lc code=end

