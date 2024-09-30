/*
 * @lc app=leetcode id=2419 lang=csharp
 *
 * [2419] Longest Subarray With Maximum Bitwise AND
 */

// @lc code=start
public class Solution {
    public int LongestSubarray(int[] nums) {
        int max = 0;
        foreach (int num in nums)
        {
            max = Math.Max(num, max);
        }

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
                nums[i] == max)
            {
                i++;
            }

            result = Math.Max(result, i - l);
        }

        return result;
    }
}
// @lc code=end

