/*
 * @lc app=leetcode id=2134 lang=csharp
 *
 * [2134] Minimum Swaps to Group All 1's Together II
 */

// @lc code=start
public class Solution {
    public int MinSwaps(int[] nums) {
        int total = 0;
        foreach (int num in nums)
        {
            total += num;
        }

        int l = 0,
            r = 0,
            current = 0;

        for (; r < total; r++)
        {
            current += nums[r];
        }

        int max = current;

        for (; l < nums.Length; l++, r++)
        {
            max = Math.Max(max, current);
            current += nums[(r % nums.Length)] - nums[l];
        }

        return total - max;
    }
}
// @lc code=end

