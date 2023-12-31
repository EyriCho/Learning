/*
 * @lc app=leetcode id=1913 lang=csharp
 *
 * [1913] Maximum Product Difference Between Two Pairs
 */

// @lc code=start
public class Solution {
    public int MaxProductDifference(int[] nums) {
        int max = 1,
            secondMax = 1,
            min = 10_000,
            secondMin = 10_000;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                secondMax = max;
                max = nums[i];
            }
            else if (nums[i] > secondMax)
            {
                secondMax = nums[i];
            }
            
            if (nums[i] < min)
            {
                secondMin = min;
                min = nums[i];
            }
            else if (nums[i] < secondMin)
            {
                secondMin = nums[i];
            }
        }

        return (max * secondMax) - (min * secondMin);
    }
}
// @lc code=end

