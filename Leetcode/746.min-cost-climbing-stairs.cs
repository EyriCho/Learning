/*
 * @lc app=leetcode id=746 lang=csharp
 *
 * [746] Min Cost Climbing Stairs
 */

// @lc code=start
public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var greedy = new int[cost.Length + 1];
        
        for (int i = 2; i <= cost.Length; i++)
            greedy[i] = Math.Min(greedy[i - 2] + cost[i - 2], greedy[i - 1] + cost[i - 1]);
        
        return greedy[cost.Length];
    }
}
// @lc code=end

