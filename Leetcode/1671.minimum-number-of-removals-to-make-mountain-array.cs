/*
 * @lc app=leetcode id=1671 lang=csharp
 *
 * [1671] Minimum Number of Removals to Make Mountain Array
 */

// @lc code=start
public class Solution {
    public int MinimumMountainRemovals(int[] nums) {
        int[] left = new int[nums.Length],
            right = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            left[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    left[i] = Math.Max(left[i], left[j] + 1);
                }
            }
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            right[i] = 1;
            for (int j = nums.Length - 1; j > i; j--)
            {
                if (nums[i] > nums[j])
                {
                    right[i] = Math.Max(right[i], right[j] + 1);
                }
            }
        }

        int result = nums.Length;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (left[i] == 1 || right[i] == 1)
            {
                continue;
            }
            result = Math.Min(result, nums.Length - left[i] - right[i] + 1);
        }

        return result;
    }
}
// @lc code=end

