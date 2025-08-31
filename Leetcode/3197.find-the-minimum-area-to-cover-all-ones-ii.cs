/*
 * @lc app=leetcode id=3197 lang=csharp
 *
 * [3197] Find the Minimum Area to Cover All Ones II
 */

// @lc code=start
public class Solution {
    public int MinimumSum(int[][] grid) {
        int[] maskRows = new int[grid.Length],
            maskCols = new int[grid[0].Length];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }

                maskRows[i] |= (1 << j);
                maskCols[j] |= (1 << i);
            }
        }

        int MinRectangle(int l, int r, int t, int b)
        {
            int left = 30, right = -1,
                top = 30, bottom = -1,
                row = 0, col = 0;
            
            for (int i = t; i <= b; i++)
            {
                row = (maskRows[i] >> l) << l;
                row &= (1 << (r + 1)) - 1;
                if (row > 0)
                {
                    top = i;
                    break;
                }
            }
            if (top == 30)
            {
                return 100_000_000;
            }

            for (int i = b; i >= t; i--)
            {
                row = (maskRows[i] >> l) << l;
                row &= (1 << (r + 1)) - 1;
                if (row > 0)
                {
                    bottom = i;
                    break;
                }
            }

            for (int j = l; j <= r; j++)
            {
                col = (maskCols[j] >> t) << t;
                col &= (1 << (b + 1)) - 1;
                if (col > 0)
                {
                    left = j;
                    break;
                }
            }

            for (int j = r; j >= l; j--)
            {
                col = (maskCols[j] >> t) << t;
                col &= (1 << (b + 1)) -1;
                if (col > 0)
                {
                    right = j;
                    break;
                }
            }

            return (bottom - top + 1) * (right - left + 1);
        }

        int result = int.MaxValue,
            a = 0, b = 0, c = 0;

        // Horizontal Split
        for (int i1 = 0; i1 < grid.Length - 2; i1++)
        {
            for (int i2 = i1 + 1; i2 < grid.Length - 1; i2++)
            {
                a = MinRectangle(0, grid[0].Length - 1, 0, i1);
                b = MinRectangle(0, grid[0].Length - 1, i1 + 1, i2);
                c = MinRectangle(0, grid[0].Length - 1, i2 + 1, grid.Length - 1);
                result = Math.Min(result, a + b +c);
            }
        }

        // Vertical Split
        for (int j1 = 0; j1 < grid[0].Length - 2; j1++)
        {
            for (int j2 = j1 + 1; j2 < grid[0].Length - 1; j2++)
            {
                a = MinRectangle(0, j1, 0, grid.Length - 1);
                b = MinRectangle(j1 + 1, j2, 0, grid.Length - 1);
                c = MinRectangle(j2 + 1, grid[0].Length - 1, 0, grid.Length - 1);
                result = Math.Min(result, a + b +c);
            }
        }

        for (int i = 0; i < grid.Length - 1; i++)
        {
            for (int j = 0; j < grid[0].Length - 1; j++)
            {
                a = MinRectangle(0, grid[0].Length - 1, 0, i);
                b = MinRectangle(0, j, i + 1, grid.Length - 1);
                c = MinRectangle(j + 1, grid[0].Length - 1, i + 1, grid.Length - 1);
                result = Math.Min(result, a + b + c);

                a = MinRectangle(0, grid[0].Length - 1, i + 1, grid.Length - 1);
                b = MinRectangle(0, j, 0, i);
                c = MinRectangle(j + 1, grid[0].Length - 1, 0, i);
                result = Math.Min(result, a + b + c);

                a = MinRectangle(0, j, 0, grid.Length - 1);
                b = MinRectangle(j + 1, grid[0].Length - 1, 0, i);
                c = MinRectangle(j + 1, grid[0].Length - 1, i + 1, grid.Length - 1);
                result = Math.Min(result, a + b + c);

                a = MinRectangle(j + 1, grid[0].Length - 1, 0, grid.Length - 1);
                b = MinRectangle(0, j, 0, i);
                c = MinRectangle(0, j, i + 1, grid.Length - 1);
                result = Math.Min(result, a + b + c);
            }
        }

        return result;
    }
}
// @lc code=end

