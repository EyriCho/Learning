/*
 * @lc app=leetcode id=1411 lang=csharp
 *
 * [1411] Number of Ways to Paint N × 3 Grid
 */

// @lc code=start
public class Solution {
    public int NumOfWays(int n) {
        const int mod = 1_000_000_007;
        int row = 1;
        long x = 6L, y = 6L,
            nextX = 0L, nextY = 0L;
        while (row < n)
        {
            nextX = (3 * x + 2 * y) % mod;
            nextY = (2 * x + 2 * y) % mod;
            x = nextX;
            y = nextY;
            row++;
        }

        return (int)((x + y) % mod);
    }
}
// @lc code=end

