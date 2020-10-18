/*
 * @lc app=leetcode id=495 lang=csharp
 *
 * [495] Teemo Attacking
 */

// @lc code=start
public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int result = 0, end = -1;
        
        for (int i = 0; i < timeSeries.Length; i++)
        {
            if (timeSeries[i] > end)
                result += duration;
            else
                result += duration - end + timeSeries[i] - 1;
            
            end = timeSeries[i] + duration - 1;
        }
        
        return result;
    }
}
// @lc code=end

