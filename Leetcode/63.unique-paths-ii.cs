/*
 * @lc app=leetcode id=63 lang=csharp
 *
 * [63] Unique Paths II
 */

// @lc code=start
public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var result = 0;
        int lastX = obstacleGrid.Length - 1,
            lastY = obstacleGrid[0].Length - 1;
        
        if (obstacleGrid[lastX][lastY] > 0 ||
            obstacleGrid[0][0] > 0)
        {
            return result;
        }
        
        obstacleGrid[lastX][lastY] = -1;
        for (int i = lastX; i >= 0; i--)
        {
            for (int j = lastY; j >= 0; j--)
            {
                if (obstacleGrid[i][j] > 0)
                {
                    continue;
                }

                if (i > 0 && obstacleGrid[i - 1][j] <= 0)
                {
                    obstacleGrid[i - 1][j] += obstacleGrid[i][j];
                }

                if (j > 0 && obstacleGrid[i][j - 1] <= 0)
                {
                    obstacleGrid[i][j - 1] += obstacleGrid[i][j];
                }
            }
        }
        
        return -obstacleGrid[0][0];
    }
}
// @lc code=end

