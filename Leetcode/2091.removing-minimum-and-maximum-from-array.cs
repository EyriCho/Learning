/*
 * @lc app=leetcode id=2091 lang=csharp
 *
 * [2091] Removing Minimum and Maximum From Array
 */

// @lc code=start
public class Solution {
    public int MinimumDeletions(int[] nums) {
        if (nums.Length < 3)
        {
            return nums.Length;
        }

        int min = nums[0], max = nums[0],
            minIdx = 0, maxIdx = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                minIdx = i;
            }

            if (nums[i] > max)
            {
                max = nums[i];
                maxIdx = i;
            }
        }

        min = Math.Min(minIdx, maxIdx);
        max = Math.Max(minIdx, maxIdx);
        int result = Math.Min(max + 1, nums.Length - min);
        result = Math.Min(result, min + 1 + nums.Length - max);
        return result;
    }
}
// @lc code=end

