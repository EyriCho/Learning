/*
 * @lc app=leetcode id=1254 lang=csharp
 *
 * [1254] Number of Closed Islands
 */

// @lc code=start
public class Solution {
    public int ClosedIsland(int[][] grid) {
        var directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        var reachable = new bool[grid.Length, grid[0].Length];

        var queue = new Queue<(int, int)>();

        void MarkReach(int x, int y)
        {
            if (grid[x][y] == 1 || reachable[x, y])
            {
                return;
            }

            queue.Enqueue((x, y));
            while (queue.Count > 0)
            {
                var (i, j) = queue.Dequeue();
                
                reachable[i, j] = true;

                for (int k = 0; k < 4; k++)
                {
                    int i1 = i + directions[k, 0],
                        j1 = j + directions[k, 1];

                    if (i1 >= 0 && i1 < grid.Length &&
                        j1 >= 0 && j1 < grid[0].Length &&
                        grid[i1][j1] == 0 &&
                        !reachable[i1, j1])
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
                if (grid[i][j] == 0 && !reachable[i, j])
                {
                    result++;
                    MarkReach(i, j);
                }
            }
        }

        return result;
    }
}
// @lc code=end

