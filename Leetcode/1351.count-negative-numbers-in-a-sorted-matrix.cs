/*
 * @lc app=leetcode id=1351 lang=csharp
 *
 * [1351] Count Negative Numbers in a Sorted Matrix
 */

// @lc code=start
public class Solution {
    public int CountNegatives(int[][] grid) {
        int r = grid[0].Length - 1,
            result = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            while (r >= 0 && grid[i][r] < 0)
            {
                r--;
            }

            if (r == -1)
            {
                result += (grid.Length - i) * grid[0].Length;
                break;
            }

            result += grid[0].Length - r - 1;
        }

        return result;
    }
}
// @lc code=end

