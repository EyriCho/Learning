/*
 * @lc app=leetcode id=2411 lang=csharp
 *
 * [2411] Smallest Subarrays With Maximum Bitwise OR
 */

// @lc code=start
public class Solution {
    public int[] SmallestSubarrays(int[] nums) {
        int[] bits = new int[32],
            result = new int[nums.Length];
        int last = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            last = i;
            for (int b = 0; b < 31; b++)
            {
                if ((nums[i] & (1 << b)) > 0)
                {
                    bits[b] = i;
                }
                last = Math.Max(last, bits[b]);
            }

            result[i] = last - i + 1;
        }

        return result;
    }
}
// @lc code=end

