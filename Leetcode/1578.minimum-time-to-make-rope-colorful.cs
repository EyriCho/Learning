/*
 * @lc app=leetcode id=1578 lang=csharp
 *
 * [1578] Minimum Time to Make Rope Colorful
 */

// @lc code=start
public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int i = 0,
            result = 0;
        
        while (i < colors.Length)
        {
            var c = colors[i];
            int max = neededTime[i],
                total = neededTime[i];
            i++;
            while (i < colors.Length && colors[i] == c)
            {
                max = Math.Max(max, neededTime[i]);
                total += neededTime[i++];
            }
            
            result += total - max;
        }
        
        return result;
    }
}
// @lc code=end

