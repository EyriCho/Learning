/*
 * @lc app=leetcode id=1800 lang=csharp
 *
 * [1800] Maximum Ascending Subarray Sum
 */

// @lc code=start
public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int result = nums[0],
            sum = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];
            }
            else
            {
                sum = nums[i];
            }

            result = Math.Max(result, sum);
        }

        return result;
    }
}
// @lc code=end

