/*
 * @lc app=leetcode id=523 lang=csharp
 *
 * [523] Continuous Subarray Sum
 */

// @lc code=start
public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        int sum = 0;
        var dict = new Dictionary<int, int>();
        dict.Add(0, -1);
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            sum %= k;
            
            if (dict.TryGetValue(sum, out int prev))
            {
                if (i - prev > 1)
                {
                    return true;
                }
            }
            else
            {
                dict[sum] = i;
            }
        }
        
        return false;
    }
}
// @lc code=end

