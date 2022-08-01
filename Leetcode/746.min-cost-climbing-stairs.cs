/*
 * @lc app=leetcode id=746 lang=csharp
 *
 * [746] Min Cost Climbing Stairs
 */

// @lc code=start
public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int prev = cost[0],
            last = cost[1];
        
        for (int i = 2; i < cost.Length; i++)
        {
            var newLast = Math.Min(prev, last) + cost[i];
            prev = last;
            last = newLast;
        }
        
        return Math.Min(prev, last);
    }
}
// @lc code=end

