/*
 * @lc app=leetcode id=1914 lang=csharp
 *
 * [1914] Cyclically Rotating a Grid
 */

// @lc code=start
public class Solution {
    public int[][] RotateGrid(int[][] grid, int k) {
        int height = grid.Length,
            width = grid[0].Length,
            total = 0, shift = 0,
            j = 0,
            x = 0, y = 0,
            nx = 0, ny = 0,
            start = 0;

        (int, int) GetIndex(int x, int y, int w, int h, int idx)
        {
            if (idx < h)
            {
                return (x + idx, y);
            }
            else if (idx < h + w - 1)
            {
                return (x + h - 1, y + idx - h + 1);
            }
            else if (idx < h * 2 + w - 2)
            {
                return (x + h * 2 + w - 3 - idx, y + w - 1);
            }
            else
            {
                return (x, y + h * 2 + w * 2 - 4 - idx);
            }
        }

        int[][] result = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            result[i] = new int[grid[0].Length];
        }
        
        for (;height > 0 && width > 0; start++, height -= 2, width -= 2)
        {
            total = (height - 1) * 2 + (width - 1) * 2;
            shift = k % total;

            for (int i = 0; i < total; i++)
            {
                j = (i + shift) % total;
                
                (x, y) = GetIndex(start, start, width, height, i);
                (nx, ny) = GetIndex(start, start, width, height, j);

                result[nx][ny] = grid[x][y];
            }
        }

        return result;
    }
}
// @lc code=end

