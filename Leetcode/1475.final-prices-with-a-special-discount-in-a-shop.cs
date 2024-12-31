/*
 * @lc app=leetcode id=1475 lang=csharp
 *
 * [1475] Final Prices With a Special Discount in a Shop
 */

// @lc code=start
public class Solution {
    public int[] FinalPrices(int[] prices) {
        Stack<int> stack = new ();
        int discount = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
            {
                prices[stack.Pop()] -= prices[i];
            }

            stack.Push(i);
        }

        return prices;
    }
}
// @lc code=end

