/*
 * @lc app=leetcode id=2965 lang=csharp
 *
 * [2965] Find Missing and Repeated Values
 */

// @lc code=start
public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int x = 0,
            y = 0,
            temp = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                while (true)
                {
                    x = (grid[i][j] - 1) / grid.Length;
                    y = (grid[i][j] - 1) % grid.Length;

                    if (grid[x][y] == grid[i][j])
                    {
                        break;
                    }

                    temp = grid[x][y];
                    grid[x][y] = grid[i][j];
                    grid[i][j] = temp;
                }
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                temp = i * grid.Length + j + 1;
                if (grid[i][j] != temp)
                {
                    return new int[] { grid[i][j], temp };
                }
            }
        }

        return new int[0];
    }
}
// @lc code=end

