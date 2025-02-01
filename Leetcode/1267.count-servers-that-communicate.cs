/*
 * @lc app=leetcode id=1267 lang=csharp
 *
 * [1267] Count Servers that Communicate
 */

// @lc code=start
public class Solution {
    public int CountServers(int[][] grid) {
        int count = 0;
        int[] rows = new int[grid.Length],
            columns = new int[grid[0].Length];
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                count += grid[i][j];
                rows[i] += grid[i][j];
                columns[j] += grid[i][j];
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            if (rows[i] != 1)
            {
                continue;
            }


            for (int j = 0; j < grid[0].Length; j++)
            {
                if (rows[i] == 1 && columns[j] == 1 && grid[i][j] == 1)
                {
                    count--;
                    break;
                }
            }
        }

        return count;
    }
}
// @lc code=end

