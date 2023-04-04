/*
 * @lc app=leetcode id=2444 lang=csharp
 *
 * [2444] Count Subarrays With Fixed Bounds
 */

// @lc code=start
public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long result = 0L;
        for (int i = 0, t = -1, l = -1, r = -1; i < nums.Length; i++)
        {
            if (nums[i] < minK || nums[i] > maxK)
            {
                l = r = -1;
                t = i;
            }
            else
            {
                if (nums[i] == minK) 
                {
                    l = i;
                }
                if (nums[i] == maxK)
                {
                    r = i;
                }
                if (l != -1 && r != -1)
                {
                    result += Math.Min(l, r) - t;
                }
            }
        }

        return result;
    }
}
// @lc code=end

