/*
 * @lc app=leetcode id=1568 lang=csharp
 *
 * [1568] Minimum Number of Days to Disconnect Island
 */

// @lc code=start
public class Solution {
    public int MinDays(int[][] grid) {
        int CountIsland()
        {
            bool[,] lands = new bool[grid.Length, grid[0].Length];
            Queue<(int, int)> queue = new ();

            int rst = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1 && !lands[i, j])
                    {
                        rst++;
                        queue.Enqueue((i, j));
                        while (queue.Count > 0)
                        {
                            (int x, int y) = queue.Dequeue();
                            if (x < 0 || x >= grid.Length ||
                                y < 0 || y >= grid[0].Length)
                            {
                                continue;
                            }
                            if (grid[x][y] == 0)
                            {
                                continue;
                            }
                            if (lands[x, y])
                            {
                                continue;
                            }
                            lands[x, y] = true;
                            queue.Enqueue((x + 1, y));
                            queue.Enqueue((x - 1, y));
                            queue.Enqueue((x, y + 1));
                            queue.Enqueue((x, y - 1));
                        }
                    }
                }
            }
            return rst;
        }

        if (CountIsland() != 1)
        {
            return 0;
        }
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    grid[i][j] = 0;
                    if (CountIsland() != 1)
                    {
                        return 1;
                    }
                    grid[i][j] = 1;
                }
            }
        }
        return 2;
    }
}
// @lc code=end

