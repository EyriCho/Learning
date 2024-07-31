/*
 * @lc app=leetcode id=1518 lang=csharp
 *
 * [1518] Water Bottles
 */

// @lc code=start
public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int result = numBottles,
            empty = numBottles,
            left = 0;
        
        while (empty >= numExchange)
        {
            result += empty / numExchange;
            left = empty % numExchange;
            empty = empty / numExchange + left;
        }

        return result;
    }
}
// @lc code=end

