/*
 * @lc app=leetcode id=2256 lang=csharp
 *
 * [2256] Minimum Average Difference
 */

// @lc code=start
public class Solution {
    public int MinimumAverageDifference(int[] nums) {
        if (nums.Length == 1)
        {
            return 0;
        }
        
        var sum = 0L;
        foreach (var num in nums)
        {
            sum += num;
        }
        
        long left = 0L,
            right = sum;
        var min = int.MaxValue;
        var result = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            left += nums[i];
            right -= nums[i];
            
            var diff = Math.Abs(left / (i + 1) - right / (nums.Length - i - 1));
            
            if (diff < min)
            {
                min = (int)diff;
                result = i;
            }
        }
        
        if ((sum / nums.Length) < min)
        {
            result = nums.Length - 1;
        }
        
        return result;
    }
}
// @lc code=end

