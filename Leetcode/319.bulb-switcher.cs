/*
 * @lc app=leetcode id=319 lang=csharp
 *
 * [319] Bulb Switcher
 */

// @lc code=start
public class Solution {
    public int BulbSwitch(int n) {
        // Every factors of number come in pairs (like 2 * 3 = 6, 1 * 5 = 5),
        // except for the perfect square number.
        return (int)Math.Sqrt(n);
    }
}
// @lc code=end

