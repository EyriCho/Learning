/*
 * @lc app=leetcode id=164 lang=csharp
 *
 * [164] Maximum Gap
 */

// @lc code=start
public class Solution {
    public int MaximumGap(int[] nums) {
        int min = int.MaxValue,
            max = int.MinValue;
        
        foreach (var num in nums)
        {
            min = Math.Min(num, min);
            max = Math.Max(num, max);
        }
        
        var barrelSize = (max - min) / nums.Length + 1;
        var barrelLen = (max - min) / barrelSize + 1;
        var minBarrels = new int[barrelLen];
        var maxBarrels = new int[barrelLen];
        for (int i = 0; i < barrelLen; i++)
        {
            minBarrels[i] = int.MaxValue;
            maxBarrels[i] = int.MinValue;
        }
        
        foreach (var num in nums)
        {
            var index = (num - min) / barrelSize;
            minBarrels[index] = Math.Min(minBarrels[index], num);
            maxBarrels[index] = Math.Max(maxBarrels[index], num);
        }
        
        int prev = 0, result = 0;
        for (int i = 1; i < barrelLen; i++)
        {
            if (maxBarrels[i] > 0)
            {
                result = Math.Max(result, minBarrels[i] - maxBarrels[prev]);
                prev = i;
            }
        }
        
        return result;
    }
}
// @lc code=end

