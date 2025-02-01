/*
 * @lc app=leetcode id=2658 lang=csharp
 *
 * [2658] Maximum Number of Fish in a Grid
 */

// @lc code=start
public class Solution {
    public int FindMaxFish(int[][] grid) {
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        int Dfs(int i, int j)
        {
            int rst = grid[i][j];
            grid[i][j] = 0;
            Queue<(int, int)> queue = new ();
            queue.Enqueue((i, j));
            
            int x = 0, y = 0,
                nx = 0, ny = 0;
            while (queue.Count > 0)
            {
                (x, y) = queue.Dequeue();
                
                for (int k = 0; k < 4; k++)
                {
                    nx = x + ds[k, 0];
                    ny = y + ds[k, 1];

                    if (nx >= 0 && nx < grid.Length &&
                        ny >= 0 && ny < grid[0].Length &&
                        grid[nx][ny] > 0)
                    {
                        rst += grid[nx][ny];
                        grid[nx][ny] = 0;
                        queue.Enqueue((nx, ny));
                    }
                }
            }

            return rst;
        }

        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] > 0)
                {
                    result = Math.Max(result, Dfs(i, j));
                }
            }
        }

        return result;
    }
}
// @lc code=end

