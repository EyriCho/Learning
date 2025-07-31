/*
 * @lc app=leetcode id=1695 lang=csharp
 *
 * [1695] Maximum Erasure Value
 */

// @lc code=start
public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        HashSet<int> set = new ();

        int result = 0,
            sum = 0,
            l = 0,
            r = 0;
        
        while (r < nums.Length)
        {
            while (set.Contains(nums[r]))
            {
                sum -= nums[l];
                set.Remove(nums[l++]);
            }

            sum += nums[r];
            set.Add(nums[r++]);
            result = Math.Max(result, sum);
        }

        return result;
    }
}
// @lc code=end

