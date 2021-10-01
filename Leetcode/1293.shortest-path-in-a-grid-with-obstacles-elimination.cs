/*
 * @lc app=leetcode id=1293 lang=csharp
 *
 * [1293] Shortest Path in a Grid with Obstacles Elimination
 */

// @lc code=start
public class Solution {
    public int ShortestPath(int[][] grid, int k) {
        if (grid.Length == 1 && grid[0].Length == 1)
            return 0;
        
        var visited = new int[grid.Length, grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                visited[i, j] = -1;
        visited[0, 0] = k;
        
        var queue = new Queue<(int, int, int)>();
        queue.Enqueue((0, 0, k));
        
        int lastRow = grid.Length - 1,
            lastColumn = grid[0].Length - 1;
        
        int step = 1;
        while (queue.Count > 0)
        {
            int count = queue.Count;
            
            while (count-- > 0)
            {
                (int x, int y, int obstacle) = queue.Dequeue();
                
                var directions = new int[,] {
                    {1, 0},
                    {0, 1},
                    {-1, 0},
                    {0, -1}
                };
                
                for (int i = 0; i < 4; i++)
                {
                    int nextX = x + directions[i, 0],
                        nextY = y + directions[i, 1];
                    
                    if (nextX < 0 || nextX > lastRow ||
                       nextY < 0 || nextY > lastColumn)
                        continue;
                    
                    if (nextX == lastRow && nextY == lastColumn)
                        return step;
                    
                    int newObs = obstacle - grid[nextX][nextY];
                    if (newObs < 0)
                        continue;
                    if (visited[nextX, nextY] >= newObs)
                        continue;
                    visited[nextX, nextY] = newObs;
                    queue.Enqueue((nextX, nextY, newObs));
                }
            }
            step++;
        }
        return -1;
    }
}
// @lc code=end

