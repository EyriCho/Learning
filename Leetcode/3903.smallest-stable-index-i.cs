/*
 * @lc app=leetcode id=3903 lang=csharp
 *
 * [3903] Smallest Stable Index I
 */

// @lc code=start
public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        int[] minSuffix = new int[nums.Length];
        minSuffix[^1] = nums[^1];
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            minSuffix[i] = Math.Min(nums[i], minSuffix[i + 1]);
        }

        int max = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);

            if (max - minSuffix[i] <= k)
            {
                return i;
            }
        }

        return -1;
    }
}
// @lc code=end

