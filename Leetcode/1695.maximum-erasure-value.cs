/*
 * @lc app=leetcode id=1695 lang=csharp
 *
 * [1695] Maximum Erasure Value
 */

// @lc code=start
public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        var dict = new Dictionary<int, int>();
        
        int l = 0, r = 0, sum = 0,
            result = 0;
        while (r < nums.Length)
        {
            if (!dict.ContainsKey(nums[r]))
            {
                sum += nums[r];
                dict.Add(nums[r], r);
            }
            else
            {
                while (nums[l] != nums[r])
                {
                    sum -= nums[l];
                    dict.Remove(nums[l]);
                    l++;
                }
                l++;
            }
            
            r++;
            result = Math.Max(result, sum);
        }
        return result;
    }
}
// @lc code=end

