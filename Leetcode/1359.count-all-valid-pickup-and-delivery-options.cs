/*
 * @lc app=leetcode id=1359 lang=csharp
 *
 * [1359] Count All Valid Pickup and Delivery Options
 */

// @lc code=start
public class Solution {
    public int CountOrders(int n) {
        if (n == 1)
            return 1;
        
        return (int)((long)n * (2 * n - 1) * CountOrders(n - 1) % 1_000_000_007);
    }
}
// @lc code=end

