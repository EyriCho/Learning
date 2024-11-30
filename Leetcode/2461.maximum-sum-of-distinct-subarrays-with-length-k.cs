/*
 * @lc app=leetcode id=2461 lang=csharp
 *
 * [2461] Maximum Sum of Distinct Subarrays With Length K
 */

// @lc code=start
public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
        HashSet<int> set = new ();
        int l = 0,
            r = 0;
        long sum = 0L,
            max = 0L;

        while (r < nums.Length)
        {
            while (set.Contains(nums[r]))
            {
                set.Remove(nums[l]);
                sum -= nums[l++];
            }

            set.Add(nums[r]);
            sum += nums[r];

            if (r - l + 1 == k)
            {
                max = Math.Max(max, sum);

                set.Remove(nums[l]);
                sum -= nums[l++];
            }
            r++;
        }

        return max;
    }
}
// @lc code=end

