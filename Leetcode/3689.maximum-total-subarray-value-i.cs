/*
 * @lc app=leetcode id=3689 lang=csharp
 *
 * [3689] Maximum Total Subarray Value I
 */

// @lc code=start
public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        int min = int.MaxValue,
            max = 0;
        
        foreach (int num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        return (long)(max - min) * k;
    }
}
// @lc code=end

