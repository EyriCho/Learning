/*
 * @lc app=leetcode id=1351 lang=csharp
 *
 * [1351] Count Negative Numbers in a Sorted Matrix
 */

// @lc code=start
public class Solution {
    public int CountNegatives(int[][] grid) {
        int r = grid[0].Length,
            result = 0;

        int Locate(int[] array, int end)
        {
            int l = 0;
            while (l < end)
            {
                int m = (l + end) >> 1;
                if (array[m] >= 0)
                {
                    l = m + 1;
                }
                else
                {
                    end = m;
                }
            }
            return l;
        }

        for (int i = 0; i < grid.Length; i++)
        {
            r = Locate(grid[i], r);

            if (r == 0)
            {
                result += (grid.Length - i) * grid[0].Length;
                break;
            }

            result += grid[0].Length - r;
        }

        return result;
    }
}
// @lc code=end

