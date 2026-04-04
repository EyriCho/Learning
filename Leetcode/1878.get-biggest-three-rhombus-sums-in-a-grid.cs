/*
 * @lc app=leetcode id=1878 lang=csharp
 *
 * [1878] Get Biggest Three Rhombus Sums in a Grid
 */

// @lc code=start
public class Solution {
    public int[] GetBiggestThree(int[][] grid) {
        int maxSide = (Math.Min(grid.Length, grid[0].Length) + 1) / 2,
            length = 0,
            total = 0;

        int count = 0;
        int[] array = new int[3];
        void Set(int num)
        {
            if (num == array[0] ||
                num == array[1] ||
                num == array[2])
            {
                return;
            }

            count++;

            if (num > array[0])
            {
                array[2] = array[1];
                array[1] = array[0];
                array[0] = num;
            }
            else if (num > array[1])
            {
                array[2] = array[1];
                array[1] = num;
            }
            else if (num > array[2])
            {
                array[2] = num;
            }
        }

        for (int s = 1; s <= maxSide; s++)
        {
            length = (s << 1) - 1;

            for (int i = 0; i + length - 1 < grid.Length; i++)
            {
                for (int j = 0; j + length - 1 < grid[0].Length; j++)
                {
                    if (length == 1)
                    {
                        Set(grid[i][j]);
                        continue;
                    }

                    total = 0;
                    for (int l = 1; l < s; l++)
                    {
                        total += grid[i + l][j + s - 1 + l] +
                            grid[i + s - 1 - l][j + l] +
                            grid[i + s - 1 + l][j + length - 1 - l] +
                            grid[i + length - 1 - l][j + s - 1 - l];
                    }
                    Set(total);
                }
            }
        }

        if (count == 1)
        {
            return new int[] { array[0] };
        }
        else if (count == 2)
        {
            return new int[] { array[0], array[1] };
        }
        else
        {
            return array;
        }
    }
}
// @lc code=end

