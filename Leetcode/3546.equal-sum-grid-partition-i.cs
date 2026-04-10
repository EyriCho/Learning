/*
 * @lc app=leetcode id=3546 lang=csharp
 *
 * [3546] Equal Sum Grid Partition I
 */

// @lc code=start
public class Solution {
    public bool CanPartitionGrid(int[][] grid) {
        long[] horizon = new long[grid.Length],
            verti = new long[grid[0].Length];
        
        long total = 0L,
            prev = 0L;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                horizon[i] += grid[i][j];
                verti[j] += grid[i][j];
                total += grid[i][j];
            }
        }

        for (int i = 0; i < horizon.Length; i++)
        {
            prev += horizon[i];
            if ((prev << 1) == total)
            {
                return true;
            }
        }

        prev = 0L;
        for (int j = 0; j < verti.Length; j++)
        {
            prev += verti[j];
            if ((prev << 1) == total)
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

