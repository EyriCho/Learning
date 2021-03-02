/*
 * @lc app=leetcode id=1091 lang=csharp
 *
 * [1091] Shortest Path in Binary Matrix
 */

// @lc code=start
public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if (grid[0][0] == 1)
            return -1;
        
        int[,] length = new int[grid.Length, grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                length[i, j] = 10_002;
            }
        }
        length[0, 0] = 1;
        
        int[] dx = { 1, 1, 0, 1, 0, -1, -1, -1 };
        int[] dy = { 1, 0, 1, -1, -1, 1, 0, -1 };
        
        var queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));
        
        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();
            for (int i = 0; i < 8; i++)
            {
                int  nx = x + dx[i],
                    ny = y + dy[i];
                
                if (nx >= 0 && nx < grid.Length &&
                    ny >= 0 && ny < grid[0].Length &&
                   grid[nx][ny] == 0)
                    if (length[nx, ny] > length[x, y] + 1)
                    {
                        length[nx, ny] = length[x, y] + 1;
                        queue.Enqueue((nx, ny));
                    }
            }
        }
        
        if (length[grid.Length - 1, grid[0].Length - 1] < 10_002)
            return length[grid.Length - 1, grid[0].Length - 1];
        else
            return -1;
    }
}
// @lc code=end

