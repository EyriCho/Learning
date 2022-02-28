/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        int result = 0,
            sum = 0;
        
        foreach (var num in nums)
        {
            sum += num;
            if (sum == k)
            {
                result++;
            }
            
            var left = sum - k;
            if (dict.ContainsKey(left))
            {
                result += dict[left];
            }
            
            if (dict.ContainsKey(sum))
            {
                dict[sum]++;
            }
            else
            {
                dict[sum] = 1;
            }
        }
        
        return result;
    }
}
// @lc code=end

