/*
 * @lc app=leetcode id=1833 lang=csharp
 *
 * [1833] Maximum Ice Cream Bars
 */

// @lc code=start
public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);

        var i = 0;
        while (i < costs.Length && coins >= costs[i])
        {
            coins -= costs[i++];
        }

        return i;
    }
}
// @lc code=end

