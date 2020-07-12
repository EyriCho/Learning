/*
 * @lc app=leetcode id=441 lang=csharp
 *
 * [441] Arranging Coins
 */

// @lc code=start
public class Solution {
    public int ArrangeCoins(int n) {
        return (int)(Math.Sqrt(2 * (double)n + 0.25D) - 0.5D);
    }
}
// @lc code=end

