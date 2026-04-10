/*
 * @lc app=leetcode id=3548 lang=csharp
 *
 * [3548] Equal Sum Grid Partition II
 */

// @lc code=start
public class Solution {
    public bool CanPartitionGrid(int[][] grid) {
        long total = 0L,
            sumTop = 0L, sumBottom = 0L,
            sumLeft = 0L, sumRight = 0L;
        int count = 0;
        
        Dictionary<long, int> dictTop = new (),
            dictBottom = new (),
            dictLeft = new (),
            dictRight = new ();

        bool CheckExist(Dictionary<long, int> dict, int t, int b, int l, int r, long num)
        {
            int rows = b - t + 1,
                cols = r - l + 1;
            
            if (rows * cols == 1)
            {
                return false;
            }

            if (rows == 1)
            {
                return grid[t][l] == num || grid[t][r] == num;
            }

            if (cols == 1)
            {
                return grid[t][l] == num || grid[b][l] == num;
            }

            return dict.TryGetValue(num, out int c) && c > 0;
        }
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                dictBottom.TryGetValue(grid[i][j], out count);
                dictBottom[grid[i][j]] = count + 1;

                dictRight.TryGetValue(grid[i][j], out count);
                dictRight[grid[i][j]] = count + 1;

                total += grid[i][j];
            }
        }

        for (int i = 0; i < grid.Length - 1; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                sumTop += grid[i][j];
                
                dictTop.TryGetValue(grid[i][j], out count);
                dictTop[grid[i][j]] = count + 1;
                
                dictBottom[grid[i][j]]--;
            }

            sumBottom = total - sumTop;
            if (sumBottom == sumTop)
            {
                return true;
            }
            else if (sumTop > sumBottom)
            {
                if (CheckExist(dictTop,
                    0, i, 0, grid[0].Length - 1,
                    sumTop - sumBottom))
                {
                    return true;
                }
            }
            else
            {
                if (CheckExist(dictBottom,
                    i + 1, grid.Length - 1, 0, grid[0].Length - 1,
                    sumBottom - sumTop))
                {
                    return true;
                }
            }
        }

        for (int j = 0; j < grid[0].Length - 1; j++)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                sumLeft += grid[i][j];
                
                dictLeft.TryGetValue(grid[i][j], out count);
                dictLeft[grid[i][j]] = count + 1;
                
                dictRight[grid[i][j]]--;
            }

            sumRight = total - sumLeft;
            if (sumLeft == sumRight)
            {
                return true;
            }
            else if (sumLeft > sumRight)
            {
                if (CheckExist(dictLeft,
                    0, grid.Length - 1, 0, j,
                    sumLeft - sumRight))
                {
                    return true;
                }
            }
            else
            {
                if (CheckExist(dictRight,
                    0, grid.Length - 1, j + 1, grid[0].Length - 1,
                    sumRight - sumLeft))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
// @lc code=end

