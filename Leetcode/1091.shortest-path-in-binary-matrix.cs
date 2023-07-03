/*
 * @lc app=leetcode id=1091 lang=csharp
 *
 * [1091] Shortest Path in Binary Matrix
 */

// @lc code=start
public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if (grid[0][0] == 1)
        {
            return -1;
        }
        
        var visited = new bool[grid.Length, grid.Length];
        
        var directions = new int[][] {
            new int[] { 1, 1 },
            new int[] { 1, 0 },
            new int[] { 0, 1 },
            new int[] { 1, -1 },
            new int[] { -1, 1 },
            new int[] { 0, -1 },
            new int[] { -1, 0 },
            new int[] { -1, -1 }
        };
        
        var step = 1;
        var queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));
        visited[0, 0] = true;
        while (queue.Count > 0)
        {
            var count = queue.Count;

            while (count-- > 0)
            {
                var (i, j) = queue.Dequeue();

                if (i == grid.Length - 1 && j == grid.Length - 1)
                {
                    return step;
                }
                
                for (int k = 0; k < 8; k++)
                {
                    int x = i + directions[k][0],
                        y = j + directions[k][1];
                    
                    if (x >= 0 && x < grid.Length &&
                        y >= 0 && y < grid.Length &&
                        grid[x][y] == 0 &&
                        !visited[x, y])
                    {
                        queue.Enqueue((x, y));
                        visited[x, y] = true;
                    }
                }
            }

            step++;
        }
        
        return -1;;
    }
}
// @lc code=end

