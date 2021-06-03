/*
 * @lc app=leetcode id=63 lang=csharp
 *
 * [63] Unique Paths II
 */

// @lc code=start
public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int lstX = obstacleGrid.Length - 1,
            lstY = obstacleGrid[0].Length - 1;
        
        if (obstacleGrid[lstX][lstY] > 0 || obstacleGrid[0][0] > 0)
            return 0;
        
        obstacleGrid[lstX][lstY] = -1;
        var queue = new Queue<(int, int)>();
        queue.Enqueue((lstX, lstY));
        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();
            
            if (x > 0 && obstacleGrid[x - 1][y] < 1)
            {
                if (obstacleGrid[x - 1][y] == 0)
                    queue.Enqueue((x - 1, y));
                obstacleGrid[x - 1][y] += obstacleGrid[x][y];
            }
            if (y > 0 && obstacleGrid[x][y - 1] < 1)
            {
                if (obstacleGrid[x][y - 1] == 0)
                    queue.Enqueue((x, y - 1));
                obstacleGrid[x][y - 1] += obstacleGrid[x][y];
            }
        }
        
        return -obstacleGrid[0][0];
    }
}
// @lc code=end

