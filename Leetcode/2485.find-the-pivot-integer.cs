/*
 * @lc app=leetcode id=2485 lang=csharp
 *
 * [2485] Find the Pivot Integer
 */

// @lc code=start
public class Solution {
    public int PivotInteger(int n) {
        int total = n * (1 + n) / 2,
            curr = 0;

        for (int i = n >> 1; i <= n; i++)
        {
            curr = i * (i + 1) / 2;
            if (curr == total - curr + i)
            {
                return i;
            }
        }

        return -1;
    }
}
// @lc code=end

