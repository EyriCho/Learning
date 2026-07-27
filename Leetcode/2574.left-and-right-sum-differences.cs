/*
 * @lc app=leetcode id=2574 lang=csharp
 *
 * [2574] Left and Right Sum Differences
 */

// @lc code=start
public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int right = 0,
            left = 0;

        foreach (int num in nums)
        {
            right += num;
        }
        
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            right -= nums[i];
            result[i] = Math.Abs(right - left);
            left += nums[i];
        }

        return result;
    }
}
// @lc code=end

