/*
 * @lc app=leetcode id=896 lang=csharp
 *
 * [896] Monotonic Array
 */

// @lc code=start
public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool isIncrease = true,
            isDecrease = true;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                isDecrease = false;
            }
            else if (nums[i] < nums[i - 1])
            {
                isIncrease = false;
            }
        }

        return isIncrease || isDecrease;
    }
}
// @lc code=end

