/*
 * @lc app=leetcode id=1413 lang=csharp
 *
 * [1413] Minimum Value to Get Positive Step by Step Sum
 */

// @lc code=start
public class Solution {
    public int MinStartValue(int[] nums) {
        var start = 0;
        var min = 0;
        foreach (var num in nums)
        {
            start += num;
            min = Math.Min(min, start);
        }
        
        return 1 - min;
    }
}
// @lc code=end

