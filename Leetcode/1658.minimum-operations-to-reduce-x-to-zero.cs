/*
 * @lc app=leetcode id=1658 lang=csharp
 *
 * [1658] Minimum Operations to Reduce X to Zero
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int x) {
        var result = nums.Length;
        
        int l = 0, sum = 0;
        while (l < nums.Length && sum < x)
        {
            sum += nums[l++];
        }
        if (sum == x)
        {
            result = Math.Min(result, l);
            if (l == nums.Length)
                return result;
        }
        if (l == nums.Length)
            return -1;
        
        var r = nums.Length - 1;
        while (l > 0)
        {
            sum -= nums[--l];
            while (r > l && sum < x)
                sum += nums[r--];
            if (sum == x)
                result = Math.Min(result, l + nums.Length - r - 1);
        }
        
        return result == nums.Length ? -1 : result;
    }
}
// @lc code=end

