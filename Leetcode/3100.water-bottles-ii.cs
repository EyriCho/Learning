/*
 * @lc app=leetcode id=3100 lang=csharp
 *
 * [3100] Water Bottles II
 */

// @lc code=start
public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int result = numBottles,
            empty = numBottles;
        
        while (empty >= numExchange)
        {
            result += 1;
            empty -= numExchange - 1;
            numExchange++;
        }

        return result;
    }
}
// @lc code=end

