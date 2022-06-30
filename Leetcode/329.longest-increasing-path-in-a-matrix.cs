/*
 * @lc app=leetcode id=329 lang=csharp
 *
 * [329] Longest Increasing Path in a Matrix
 */

// @lc code=start
public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        var steps = new int[matrix.Length, matrix[0].Length];
        
        var directions = new int[,] {
            { -1, 0 },
            { 0, 1 },
            { 1, 0 },
            { 0, -1 }
        };
        
        var result = 0;
        
        void dfs(int i, int j, int step)
        {
            if (steps[i, j] > step)
            {
                return;
            }
            
            steps[i, j] = Math.Max(steps[i, j], step);
            result = Math.Max(result, steps[i, j]);
            
            var next = step + 1;
            for (int k = 0; k < 4; k++)
            {
                int x = i + directions[k, 0],
                    y = j + directions[k, 1];
                
                if (x >= 0 && x < matrix.Length &&
                    y >= 0 && y < matrix[0].Length &&
                    matrix[i][j] < matrix[x][y] &&
                    steps[x, y] < next)
                {
                    dfs(x, y, next);
                }
            }
        }
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                dfs(i, j, 1);
            }
        }
        
        return result;
    }
}
// @lc code=end

