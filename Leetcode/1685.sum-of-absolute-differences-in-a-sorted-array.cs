/*
 * @lc app=leetcode id=1685 lang=csharp
 *
 * [1685] Sum of Absolute Differences in a Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int leftSum = 0,
            rightSum = 0;
        
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            leftSum += nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            leftSum -= nums[i];
            result[i] += rightSum - nums[i] * (nums.Length - 1 - i);
            result[i] += nums[i] * i - leftSum;

            rightSum += nums[i];
        }

        return result;
    }
}
// @lc code=end

