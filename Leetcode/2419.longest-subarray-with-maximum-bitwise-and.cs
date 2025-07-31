/*
 * @lc app=leetcode id=2419 lang=csharp
 *
 * [2419] Longest Subarray With Maximum Bitwise AND
 */

// @lc code=start
public class Solution {
    public int LongestSubarray(int[] nums) {
        int max = nums.Max();

        int i = 0,
            l = 0,
            result = 1;
        while (i < nums.Length)
        {
            if (nums[i] != max)
            {
                i++;
                continue;
            }

            l = i;
            while (i < nums.Length &&
                nums[i] == nums[l])
            {
                i++;
            }

            result = Math.Max(result, i - l);
        }

        return result;
    }
}
// @lc code=end

