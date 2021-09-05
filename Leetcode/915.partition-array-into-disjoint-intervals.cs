/*
 * @lc app=leetcode id=915 lang=csharp
 *
 * [915] Partition Array into Disjoint Intervals
 */

// @lc code=start
public class Solution {
    public int PartitionDisjoint(int[] nums) {
        int result = 1, max = nums[0],
            newMax = -1;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
                newMax = Math.Max(newMax, nums[i]);
            else if (nums[i] < max)
            {
                result = i + 1;
                max = Math.Max(newMax, max);
                newMax = -1;
            }
        }
        return result;
    }
}
// @lc code=end

