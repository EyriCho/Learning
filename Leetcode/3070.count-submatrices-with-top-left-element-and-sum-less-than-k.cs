/*
 * @lc app=leetcode id=3070 lang=csharp
 *
 * [3070] Count Submatrices with Top-Left Element and Sum Less Than k
 */

// @lc code=start
public class Solution {
    public int CountSubmatrices(int[][] grid, int k) {
        if (grid[0][0] == k)
        {
            return 1;
        }
        else if (grid[0][0] > k)
        {
            return 0;
        }
        
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (i != 0 && j != 0)
                {
                    grid[i][j] += grid[i - 1][j] + grid[i][j - 1] - grid[i - 1][j - 1];
                }
                else if (i != 0)
                {
                    grid[i][j] += grid[i - 1][j];
                }
                else if (j != 0)
                {
                    grid[i][j] += grid[i][j - 1];
                }

                if (grid[i][j] > k)
                {
                    break;
                }
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

