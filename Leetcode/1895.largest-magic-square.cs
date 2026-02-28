/*
 * @lc app=leetcode id=1895 lang=csharp
 *
 * [1895] Largest Magic Square
 */

// @lc code=start
public class Solution {
    public int LargestMagicSquare(int[][] grid) {
        int largestSize = Math.Min(grid.Length, grid[0].Length);

        bool IsMagicSquare(int size, int x, int y)
        {
            int diagonalA = 0,
                diagonalB = 0;
            for (int i = 0; i < size; i++)
            {
                diagonalA += grid[x + i][y + i];
                diagonalB += grid[x + i][y + size - 1 - i];
            }

            if (diagonalA != diagonalB)
            {
                return false;
            }

            int row = 0;
            int[] columns = new int[size];
            for (int i = 0; i < size; i++)
            {
                row = 0;
                for (int j = 0; j < size; j++)
                {
                    row += grid[x + i][y + j];
                    columns[j] += grid[x + i][y + j];
                }
                if (row != diagonalA)
                {
                    return false;
                }
            }

            for (int j = 0; j < size; j++)
            {
                if (columns[j] != diagonalA)
                {
                    return false;
                }
            }

            return true;
        }

        for (int size = largestSize; size > 1; size--)
        {
            for (int i = grid.Length - size; i >= 0; i--)
            {
                for (int j = grid[0].Length - size; j >= 0; j--)
                {
                    if (IsMagicSquare(size, i, j))
                    {
                        return size;
                    }
                }
            }
        }

        return 1;
    }
}
// @lc code=end

