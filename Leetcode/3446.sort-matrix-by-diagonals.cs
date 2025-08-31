/*
 * @lc app=leetcode id=3446 lang=csharp
 *
 * [3446] Sort Matrix by Diagonals
 */

// @lc code=start
public class Solution {
    public int[][] SortMatrix(int[][] grid) {        
        List<int> list = new (grid.Length);

        int i = 0, j = 0,
            k = 0;
        for (j = grid.Length - 2; j > 0; j--)
        {
            list.Clear();
            i = 0;
            k = j;
            while (k < grid.Length)
            {
                list.Add(grid[i++][k++]);
            }

            list.Sort();
            i = 0;
            k = j;
            while (k < grid.Length)
            {
                grid[i][k++] = list[i];
                i++;
            }
        }

        for (i = grid.Length - 2; i >= 0; i--)
        {
            list.Clear();
            j = 0;
            k = i;
            while (k < grid.Length)
            {
                list.Add(grid[k++][j++]);
            }
            
            list.Sort();
            j--;
            k--;
            while (j >= 0)
            {
                grid[k--][j] = list[list.Count - 1 - j];
                j--;
            }
        }

        return grid;
    }
}
// @lc code=end

