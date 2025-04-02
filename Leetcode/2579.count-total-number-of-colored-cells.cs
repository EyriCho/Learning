/*
 * @lc app=leetcode id=2579 lang=csharp
 *
 * [2579] Count Total Number of Colored Cells
 */

// @lc code=start
public class Solution {
    public long ColoredCells(int n) {
        return 1 + (long)n * (n - 1) * 2;
    }
}
// @lc code=end

