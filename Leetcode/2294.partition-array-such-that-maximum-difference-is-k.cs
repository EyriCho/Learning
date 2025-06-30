/*
 * @lc app=leetcode id=2294 lang=csharp
 *
 * [2294] Partition Array Such That Maximum Difference Is K
 */

// @lc code=start
public class Solution {
    public int PartitionArray(int[] nums, int k) {
        Array.Sort(nums);
        int result = 1,
            prev = nums[0],
            i = 1;
        while (i < nums.Length)
        {
            if (nums[i] - prev > k)
            {
                result++;
                prev = nums[i];
            }
            i++;
        }

        return result;
    }
}
// @lc code=end

