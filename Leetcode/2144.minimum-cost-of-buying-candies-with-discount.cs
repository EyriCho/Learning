/*
 * @lc app=leetcode id=2144 lang=csharp
 *
 * [2144] Minimum Cost of Buying Candies With Discount
 */

// @lc code=start
public class Solution {
    public int MinimumCost(int[] cost) {
        Array.Sort(cost);

        int result = 0;
        for (int i = cost.Length - 1; i >= 0; i -= 3)
        {
            result += cost[i];
            if (i > 0)
            {
                result += cost[i - 1];
            }
        }

        return result;
    }
}
// @lc code=end

