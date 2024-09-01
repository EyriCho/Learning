/*
 * @lc app=leetcode id=840 lang=csharp
 *
 * [840] Magic Squares In Grid
 */

// @lc code=start
public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int result = 0;

        bool IsUnique(int x, int y)
        {
            int[] counts = new int[16];
            for (int i = x - 2; i <= x; i++)
            {
                for (int j = y - 2; j <= y; j++)
                {
                    counts[grid[i][j]]++;
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                if (counts[i] != 1)
                {
                    return false;
                }
            }

            return true;
        }

        for (int i = 2; i < grid.Length; i++)
        {
            for (int j = 2; j < grid.Length; j++)
            {
                if (grid[i - 1][j - 1] != 5)
                {
                    continue;
                }

                if (grid[i - 2][j - 2] < 1 || grid[i - 2][j - 2] > 9 ||
                    grid[i - 2][j - 1] < 1 || grid[i - 2][j - 1] > 9 ||
                    grid[i - 2][j] < 1 || grid[i - 2][j] > 9 ||
                    grid[i - 1][j - 2] < 1 || grid[i - 1][j - 2] > 9 ||
                    grid[i - 1][j - 1] < 1 || grid[i - 1][j - 1] > 9 ||
                    grid[i - 1][j] < 1 || grid[i - 1][j] > 9 ||
                    grid[i][j - 2] < 1 || grid[i][j - 2] > 9 ||
                    grid[i][j - 1] < 1 || grid[i][j - 2] > 9 ||
                    grid[i][j] < 1 || grid[i][j] > 9)
                {
                    continue;
                }

                if (grid[i - 2][j - 2] + grid[i - 2][j - 1] + grid[i - 2][j] == 15 &&
                    grid[i - 1][j - 2] + grid[i - 1][j - 1] + grid[i - 1][j] == 15 &&
                    grid[i][j - 2] + grid[i][j - 1] + grid[i][j] == 15 &&
                    grid[i - 2][j - 2] + grid[i - 1][j - 2] + grid[i][j - 2] == 15 &&
                    grid[i - 2][j - 1] + grid[i - 1][j - 1] + grid[i][j - 1] == 15 &&
                    grid[i - 2][j] + grid[i - 1][j] + grid[i][j] == 15 &&
                    grid[i - 2][j - 2] + grid[i - 1][j - 1] + grid[i][j] == 15 &&
                    grid[i - 2][j] + grid[i - 1][j - 1] + grid[i][j - 2] == 15 &&
                    IsUnique(i, j))
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

