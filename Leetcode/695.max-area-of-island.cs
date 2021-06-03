/*
 * @lc app=leetcode id=695 lang=csharp
 *
 * [695] Max Area of Island
 */

// @lc code=start
public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int result = 0;
        
        var queue = new Queue<(int, int)>();
        var directions = new int[,] {
            { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 }
        };
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] > 0)
                {
                    queue.Enqueue((i, j));
                    int c = 0;
                    while (queue.Count > 0)
                    {
                        var (x, y) = queue.Dequeue();
                        if (grid[x][y] <= 0)
                            continue;
                        
                        c++;
                        grid[x][y] = -1;
                        for (int k = 0; k < 4; k++)
                        {
                            var nx = x + directions[k, 0];
                            var ny = y + directions[k, 1];
                            if (nx > -1 && nx < grid.Length &&
                               ny > -1 && ny < grid[0].Length &&
                               grid[nx][ny] > 0)
                                queue.Enqueue((nx, ny));
                        }
                    }
                    result = Math.Max(c, result);
                }
            }
        
        return result;
    }
}
// @lc code=end

