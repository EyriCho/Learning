/*
 * @lc app=leetcode id=2789 lang=csharp
 *
 * [2789] Largest Element in an Array after Merge Operations
 */

// @lc code=start
public class Solution {
    public long MaxArrayValue(int[] nums) {
        long sum = nums[^1];
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] > sum)
            {
                sum = nums[i];
            }
            else
            {
                sum += nums[i];
            }
        }
        return sum;
    }
}
// @lc code=end

