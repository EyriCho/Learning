/*
 * @lc app=leetcode id=2962 lang=csharp
 *
 * [2962] Count Subarrays Where Max Element Appears at Least K Times
 */

// @lc code=start
public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int max = 0;
        foreach (int num in nums)
        {
            max = Math.Max(max, num);
        }
        
        int l = 0,
            count = 0;
        long result = 0L;
        for (int r = 0; r < nums.Length; r++)
        {
            count += nums[r] == max ? 1 : 0;
            while (count >= k)
            {
                count -= nums[l++] == max ? 1 : 0;
            }

            result += l;
        }

        return result;
    }
}
// @lc code=end

