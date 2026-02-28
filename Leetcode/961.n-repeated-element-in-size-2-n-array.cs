/*
 * @lc app=leetcode id=961 lang=csharp
 *
 * [961] N-Repeated Element in Size 2N Array
 */

// @lc code=start
public class Solution {
    public int RepeatedNTimes(int[] nums) {
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] == nums[i + 1] ||
                nums[i] == nums[i + 2])
            {
                return nums[i];
            }
        }

        return nums[^1];
    }
}
// @lc code=end

