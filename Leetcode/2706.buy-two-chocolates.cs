/*
 * @lc app=leetcode id=2706 lang=csharp
 *
 * [2706] Buy Two Chocolates
 */

// @lc code=start
public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int min = 100,
            second = 100;
        
        foreach (int price in prices)
        {
            if (price < min)
            {
                second = min;
                min = price;
            }
            else if (price < second)
            {
                second = price;
            }
        }

        return money >= min + second ? (money - min - second) : money;
    }
}
// @lc code=end

