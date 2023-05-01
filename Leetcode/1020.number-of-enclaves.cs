/*
 * @lc app=leetcode id=1020 lang=csharp
 *
 * [1020] Number of Enclaves
 */

// @lc code=start
public class Solution {
    public int NumEnclaves(int[][] grid) {
        var directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        var queue = new Queue<(int, int)>();

        void MarkReach(int x, int y)
        {
            if (grid[x][y] == 0)
            {
                return;
            }

            queue.Enqueue((x, y));
            while (queue.Count > 0)
            {
                var (i, j) = queue.Dequeue();
                
                if (grid[i][j] == 0)
                {
                    continue;
                }

                grid[i][j] = 0;

                for (int k = 0; k < 4; k++)
                {
                    int i1 = i + directions[k, 0],
                        j1 = j + directions[k, 1];

                    if (i1 >= 0 && i1 < grid.Length &&
                        j1 >= 0 && j1 < grid[0].Length &&
                        grid[i1][j1] == 1)
                    {
                        queue.Enqueue((i1, j1));
                    }
                }
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            MarkReach(i, 0);
            MarkReach(i, grid[0].Length - 1);
        }

        for (int j = 0; j < grid[0].Length; j++)
        {
            MarkReach(0, j);
            MarkReach(grid.Length - 1, j);
        }

        var result = 0;
        for (int i = 1; i < grid.Length - 1; i++)
        {
            for (int j = 1; j < grid[0].Length - 1; j++)
            {
                result += grid[i][j];
            }
        }

        return result;
    }
}
// @lc code=end

