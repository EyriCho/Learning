/*
 * @lc app=leetcode id=1877 lang=csharp
 *
 * [1877] Minimize Maximum Pair Sum in Array
 */

// @lc code=start
public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);

        int l = 0,
            r = nums.Length - 1,
            max = 0;

        while (l < r)
        {
            max = Math.Max(max, nums[l++] + nums[r--]);
        }

        return max;
    }
}
// @lc code=end

